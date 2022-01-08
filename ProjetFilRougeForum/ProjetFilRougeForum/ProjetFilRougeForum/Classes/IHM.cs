using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFilRougeForum.Classes
{
    internal class IHM
    {
        string usernameTmp;
        string mdpTmp;
        string emailTmp;
        bool accessUser;
        bool accessAdmin;
        Users user = new Users();

        public void Start()
        {
            Console.WriteLine("Bienvenue sur le forum des Nuls!");
            do
            {
                Menu();
            } while (!accessUser && !accessAdmin);

            if (accessAdmin)
            {
                AffichageAdmin();
            }
            else
            {
                Forum();
            }
        }

        public void Menu()
        {
            int choix = 0;
            Console.WriteLine("Que souhaitez vous faire?\n1 pour Login\n2 pour Signup");
            choix = int.Parse(Console.ReadLine());
            Console.Clear();
            if (choix == 1)
            {
                LogIn();
                if (user.TestUsers(user.UserName, user.Password)==2)
                {
                    Console.WriteLine("Connexion en cours...");
                    //Console.Read();
                    accessAdmin = true;
                }
                else if (user.TestUsers(user.UserName, user.Password) == 0)
                {
                    Console.WriteLine("Connexion en cours...");
                    //Console.Read();
                    accessUser = true;
                }
                else
                {
                    Console.WriteLine("T'es nul, c'est pas le bon mdp!");
                }
            }
            else if (choix == 2)
            {
                Inscription();
                if (user.SignUp(emailTmp, usernameTmp, mdpTmp) == true)
                {
                    Console.WriteLine("Félicitations, votre compte est créé!");
                }
                else if (user.SignUp(emailTmp, usernameTmp, mdpTmp) == false)
                {
                    Console.WriteLine("Nom d'utilisateur et/ou Email déjà existant!");
                }


            }

        }

        public void LogIn()
        {
            Console.WriteLine("**** Connexion à votre compte ****");
            Console.Write("\tUsername: ");
            usernameTmp = Console.ReadLine();
            Console.Write("\tMot de passe: ");
            mdpTmp = Console.ReadLine();
        }

        public void Inscription()
        {

            Console.WriteLine("**** Création de votre compte ****");
            Console.Write("\tEmail: ");
            emailTmp = Console.ReadLine();
            Console.Write("\tUsername: ");
            usernameTmp = Console.ReadLine();
            Console.Write("\tMot de passe: ");
            mdpTmp = Console.ReadLine();
        }

        public void Forum()
        {
            Console.Clear();
            Console.WriteLine("***** Forum des Nuls *****");
            Console.WriteLine("1 - Poster un nouveau sujet");
            Console.WriteLine("2 - Accéder à un sujet");
            Console.WriteLine("3 - Ecrire un commentaire");
            Console.WriteLine("4 - Modifier ses informations");
            Console.WriteLine("0 - Déconnexion");
            Console.Write("Entrez votre choix: ");
            int choix = int.Parse(Console.ReadLine());
        }

        public void AffichageAdmin()
        {
            Console.Clear();
            Console.WriteLine("Bienvenue sur votre forum, cher administrateur");
            Console.WriteLine("\nQu'allons nous faire aujourd'hui?");
            Console.WriteLine("1 - Valider les utilisateurs en attente");
            Console.WriteLine("2 - Ajouter un nouvel utilisateur");
            Console.WriteLine("3 - Supprimer un utilisateur");
            Console.WriteLine("4 - Accéder aux informations d'un utilisateur");
            Console.WriteLine("0 - Quitter l'interface Administrateur");
            Console.Write("Entrez votre choix: ");
            int choix = int.Parse(Console.ReadLine());
        }
    }
}
