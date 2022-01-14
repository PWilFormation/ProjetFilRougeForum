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
        private object[] utilisateurs = new object[] { };
        private int compteur = 0;

        public Users()
        {

        }

        public Users(string userName, string password, string email, int compteur, object[] utilisateurs)
        {
            this.UserName = userName;
            this.Password = password;
            this.Email = email;
            this.Compteur = compteur;
            this.utilisateurs = utilisateurs;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Compteur { get => compteur; set => compteur = value; }
        public object[] Utilisateurs { get => utilisateurs; set => utilisateurs = value; }

        public int SignUp(string mail, string pseudo, string mdp)
        {
            Email = mail;
            UserName = pseudo;
            Password = mdp;

            //Compteur = 1;
            //Utilisateurs[0] = new object[] { mail, pseudo, mdp };
            return 1;

            //if (CheckUsernameExist() == false && CheckEmailUserExist() == false)
            //{

            //    return 1;
            //}
            //else
            //{
            //    return 2;
            //}

        }

        //public bool CheckUsernameExist()
        //{
        //    foreach (int i in Utilisateurs)
        //    {
        //        if (utilisateurs[i](1) == UserName)
        //        {

        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public bool CheckEmailUserExist()
        //{
        //    foreach (var item in DicoUserMail)
        //    {
        //        if (item.Value == email)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public int TestUsers(string name, string password)
        {
            //if (Convert.ToString(Test.admin[0]) == name)
            //{
            //    if (Convert.ToString(Test.admin[1]) == password)
            //    {
            //        return 1;
            //    }
            //}

            if (UserName == name)
            {
                if (Password == password)
                {
                    return 2;
                }

                //foreach (KeyValuePair<int, string> mddp in DicoUserMDP)
                //{

                //}
            }

            //foreach ()
            //{
                
            //}
            return 0;
        }
    }
}
