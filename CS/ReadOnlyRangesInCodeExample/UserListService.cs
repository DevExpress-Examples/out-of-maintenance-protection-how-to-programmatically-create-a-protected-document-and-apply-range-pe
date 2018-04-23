using DevExpress.XtraRichEdit.API.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyRangesInCodeExample
{
    #region #MyUserListService
    class MyUserListService : DevExpress.XtraRichEdit.Services.IUserListService
    {
        List<string> users = new List<string>();

        public MyUserListService( List<MyUser> myUsers) {
            foreach (MyUser user in myUsers) { users.Add(user.UserName);}
        }

        public IList<string> GetUsers()
        {
            return users;
        }
    }
    #endregion #MyUserListService
    #region #MyGroupListService
    class MyGroupListService : DevExpress.XtraRichEdit.Services.IUserGroupListService
    {
        List<string> userGroups = CreateUserGroups();

        static List<string> CreateUserGroups()
        {
            List<string> result = new List<string>();
            result.Add(@"Everyone");
            result.Add(@"Administrators");
            result.Add(@"Contributors");
            result.Add(@"Owners");
            result.Add(@"Editors");
            result.Add(@"Current User");
            result.Add("Skywalkers");
            result.Add("Nihlus");
            return result;
        }
        public IList<string> GetUserGroups()
        {
            return userGroups;
        }
    }
    #endregion #MyGroupListService
    #region #MyUser
    public class MyUser
    {
        public MyUser(string s)
        {
            UserName = s;
            Group = String.Empty;
        }
        public MyUser(string s1, string s2)
        {
            UserName = s1;
            Group = s2;
        }
        public string UserName { get; set; }
        public string Group { get; set; }
    }
    #endregion #MyUser
}
