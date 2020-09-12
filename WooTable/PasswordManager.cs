using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CredentialManagement;

namespace WooTable
{
    public static class PasswordManager
    {
        public static void SavePassword(string target, string username, string password)
        {
            using (var cred = new Credential())
            {
                cred.Password = password;
                cred.Username = username;
                cred.Target = target;
                cred.Type = CredentialType.Generic;
                cred.PersistanceType = PersistanceType.LocalComputer;
                cred.Save();
            }
        }

        public static Tuple<string, string> GetPassword(string target)
        {
            try
            {
                using (var cred = new Credential())
                {
                    cred.Target = target;
                    cred.Load();
                    return new Tuple<string, string>(cred.Username, cred.Password); ;
                }
            }
            catch 
            {
                return new Tuple<string, string>("", "");
            }
        }
    }
}
