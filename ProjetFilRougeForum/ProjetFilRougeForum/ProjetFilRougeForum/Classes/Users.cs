using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFilRougeForum.Classes
{
    internal class Users
    {
        private string userName;
        private string password;
        private string email;
        private Dictionary<int, string> DicoUserMail = new Dictionary<int, string>();
        private Dictionary<int, string> DicoUserName = new Dictionary<int, string>();
        private Dictionary<int, string> DicoUserMDP = new Dictionary<int, string>();

        public Users()
        {

        }

        public Users(string userName, string password, string email)
        {
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public bool SignUp(string mail, string pseudo ,string mdp)
        {
            //Email = mail;
            //UserName = pseudo;
            //Password = mdp;
            
            if (CheckUsernameExist() == false && CheckEmailUserExist() == false)
            {
                DicoUserMail.Add(DicoUserMail.Count + 1, Email);
                DicoUserName.Add(DicoUserName.Count + 1, UserName);
                DicoUserMDP.Add(DicoUserMDP.Count + 1, Password);
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CheckUsernameExist()
        {
            foreach (var user in DicoUserMail)
            {
                if (user.Value == email)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckEmailUserExist()
        {
            foreach (var item in DicoUserMail)
            {
                if (item.Value == email)
                {
                    return true;
                }
            }
            return false;
        }

        public int TestUsers(string name, string password)
        {
            //if (Convert.ToString(Test.admin[0]) == name)
            //{
            //    if (Convert.ToString(Test.admin[1]) == password)
            //    {
            //        return 1;
            //    }
            //}

            foreach (KeyValuePair<int, string> item in DicoUserName)
            {
                if (item.Value == name)
                {
                    foreach (KeyValuePair<int, string> mddp in DicoUserMDP)
                    {
                        if (item.Value == password)
                        {
                            return 2;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
