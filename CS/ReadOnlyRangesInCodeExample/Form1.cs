using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Commands;
#endregion #usings

namespace ReadOnlyRangesInCodeExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richEditControl1.Options.Authentication.EMail = comboBoxEdit1.SelectedItem.ToString();
            richEditControl1.Options.RangePermissions.Visibility = RichEditRangePermissionVisibility.Visible;

            richEditControl1.CreateNewDocument();

            DocumentRange rangeEditable = AppendDocument("Documents\\editable.docx");
            DocumentRange rangeBody = AppendDocument("Documents\\body.docx");
            DocumentRange rangeSignature = AppendDocument("Documents\\signature.docx");

            RangePermissionCollection rangePermissions = richEditControl1.Document.BeginUpdateRangePermissions();
            rangePermissions.AddRange(CreateRangeWithPermissions(rangeEditable, String.Empty,"Employee@somecompany.com", "Admin@somecompany.com"));
            rangePermissions.AddRange(CreateRangeWithPermissions(rangeBody, "Everyone", String.Empty));
            rangePermissions.AddRange(CreateRangeWithPermissions(rangeSignature, String.Empty, "Employee@somecompany.com"));            
            richEditControl1.Document.EndUpdateRangePermissions(rangePermissions);

            ProtectDocumentCommand cmd = new ProtectDocumentCommand(richEditControl1);
            cmd.Execute();
        }
        #region #appenddocument
        private DocumentRange AppendDocument(string filename)
        {
            richEditControl1.Document.InsertParagraph(richEditControl1.Document.Range.End);
            DocumentPosition pos = richEditControl1.Document.CreatePosition(richEditControl1.Document.Range.End.ToInt() - 2);
            DocumentRange range = richEditControl1.Document.InsertDocumentContent(pos, filename, DocumentFormat.OpenXml);
            return range;
        }
        #endregion #appenddocument
        private static List<RangePermission> CreateRangeWithPermissions(DocumentRange range, string userGroup, params string[] emails)
        {
            List<RangePermission> rangeList = new List<RangePermission>();
            foreach (string email in emails) {
                RangePermission rp = new RangePermission(range);
                rp.Group = userGroup;
                rp.UserName = email;
                rangeList.Add(rp);
            }
            return rangeList;
        }

        private void comboBoxEdit1_SelectedValueChanged(object sender, EventArgs e)
        {
            richEditControl1.Options.Authentication.EMail = comboBoxEdit1.SelectedItem.ToString();
        }
    }
}