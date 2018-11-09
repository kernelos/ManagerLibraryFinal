using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DB;
namespace Services.Entities
{
    public class UserAwareEntitySet:DBTable
    {
        private readonly string CurrentUserName;
        #region Regex check format entity
        private readonly string rUsername = "^([a-zA-Z])\\w{4,18}$";
        private readonly string rPassword = "^\\S{5,}$";
        private readonly string rPersonalId = "^\\d{9,12}$";
        private readonly string rStudentId = "^\\d{7,10}$";
        public bool ValidFormatFeild(string username, string password, string personalId)
        {
            if ((!Regex.IsMatch(username, rUsername) && !Regex.IsMatch(username, rStudentId)) ||
               !Regex.IsMatch(password, rPassword))
                return false;
            if (String.IsNullOrEmpty(personalId))
                return true;
            if (!Regex.IsMatch(personalId, rPersonalId))
                return false;
            return true;
        }
        #endregion


        public UserAwareEntitySet(string username)
        {

            if (!Regex.IsMatch(username, rUsername)&&!Regex.IsMatch(username,rStudentId)&&username!= "_Leding_Form")
                throw new FormatException("Formart of Username invalid");
            CurrentUserName = username;
        }

        protected LibManager GetCurrentManager(LibraryManagementEntities dataContext)
        {
            var manager = dataContext.LibManagers.FirstOrDefault(x => x.Username == CurrentUserName);
            if (null == manager)
                throw new Exception("Acesss Exception");
            else
                return manager;
        }
    }
}
