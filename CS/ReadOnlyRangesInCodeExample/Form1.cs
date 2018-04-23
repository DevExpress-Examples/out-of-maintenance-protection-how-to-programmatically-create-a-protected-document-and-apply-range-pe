using System;
using System.Collections.Generic;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Services;
#endregion #usings

namespace ReadOnlyRangesInCodeExample
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public List<MyUser> myUserList = new List<MyUser>();

        public Form1()
        {
            InitializeComponent();
            ribbonControl1.SelectedPage = ribbonControl1.Pages[1];
            myUserList.AddRange(new MyUser[]{
                new MyUser("Nancy Skywalker","Skywalkers"),
                new MyUser("Andrew Nihlus","Nihlus"),
                new MyUser("Janet Skywalker", "Skywalkers"),
                new MyUser("Margaret","Editors")
            });

            #region #RegisterUserListService
            richEditControl1.ReplaceService<IUserListService>(new MyUserListService(myUserList));
            #endregion #RegisterUserListService
            #region #RegisterGroupListService
            richEditControl1.ReplaceService<IUserGroupListService>(new MyGroupListService());
            #endregion #RegisterGroupListService

            richEditControl1.DocumentLoaded += richEditControl1_DocumentLoaded;

            richEditControl1.CreateNewDocument();
            #region #AddPermissionsToRanges
            // Create document ranges.
            DocumentRange rangeAdmin = AppendDocument("Documents\\administrator.docx");
            DocumentRange rangeBody = AppendDocument("Documents\\body.docx");
            DocumentRange rangeSignature = AppendDocument("Documents\\signature.docx");

            // Protect document ranges.
            RangePermissionCollection rangePermissions = richEditControl1.Document.BeginUpdateRangePermissions();
            rangePermissions.AddRange(CreateRangePermissions(rangeAdmin, String.Empty, "Admin@somecompany.com", "Nancy Skywalker"));
            rangePermissions.AddRange(CreateRangePermissions(rangeBody, "Everyone", String.Empty));
            rangePermissions.AddRange(CreateRangePermissions(rangeSignature, "Skywalkers", String.Empty));            
            richEditControl1.Document.EndUpdateRangePermissions(rangePermissions);
            // Enforce protection and set password.
            richEditControl1.Document.Protect("123");
            #endregion #AddPermissionsToRanges

            UpdateUserNameLoginCombo();
        }

        #region #AppendDocument
        private DocumentRange AppendDocument(string filename)
        {
            richEditControl1.Document.InsertParagraph(richEditControl1.Document.Range.End);
            DocumentPosition pos = richEditControl1.Document.CreatePosition(richEditControl1.Document.Range.End.ToInt() - 2);
            DocumentRange range = richEditControl1.Document.InsertDocumentContent(pos, filename, DocumentFormat.OpenXml);
            return range;
        }
        #endregion #AppendDocument
        #region #CreatePermissions
        private static List<RangePermission> CreateRangePermissions(DocumentRange range, string userGroup, params string[] usernames)
        {
            List<RangePermission> rangeList = new List<RangePermission>();
            foreach (string username in usernames)
            {
                RangePermission rp = new RangePermission(range);
                rp.Group = userGroup;
                rp.UserName = username;
                rangeList.Add(rp);
            }
            return rangeList;
        }
        #endregion #CreatePermissions

        #region #FetchUsers
        void richEditControl1_DocumentLoaded(object sender, EventArgs e)
        {
            UpdateUserNameLoginCombo();
            richEditControl1.Options.Authentication.UserName = String.Empty;
        }
        private void UpdateUserNameLoginCombo()
        {
            cmbUserName.SelectedValueChanged-=cmbUserName_SelectedValueChanged;
            RangePermissionCollection rangePermissions = richEditControl1.Document.BeginUpdateRangePermissions();
            richEditControl1.Document.CancelUpdateRangePermissions(rangePermissions);
            List<String> users = new List<string>();
            foreach (RangePermission rangePermission in rangePermissions)
            {
                string userName = rangePermission.UserName;
                if (users.Contains(userName))
                    continue;
                if (!String.IsNullOrEmpty(userName))
                    users.Add(userName);
            }
            cmbUserName.Properties.BeginUpdate();
            cmbUserName.Properties.Items.Clear();
            cmbUserName.Properties.Items.Add(String.Empty);
            cmbUserName.Properties.Items.AddRange(users);
            foreach (MyUser user in myUserList) {
                if (!users.Contains(user.UserName)) cmbUserName.Properties.Items.Add(user.UserName);
            }
            cmbUserName.SelectedIndex = 0;
            cmbUserName.Properties.EndUpdate();
            cmbUserName.SelectedValueChanged += cmbUserName_SelectedValueChanged;
        }

        private void cmbUserName_SelectedValueChanged(object sender, EventArgs e)
        {
            string username = cmbUserName.SelectedItem.ToString();
            richEditControl1.Options.Authentication.UserName = username;
            MyUser myuser = myUserList.Find(s => s.UserName == username);
            richEditControl1.Options.Authentication.Group = (myuser != null) ? myuser.Group : String.Empty;

        }
        #endregion #FetchUsers

    }
}