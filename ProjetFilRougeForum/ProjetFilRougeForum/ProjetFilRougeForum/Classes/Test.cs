using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFilRougeForum.Classes
{
    internal class Test
    {
        static Dictionary<string, string> Toto = new Dictionary<string, string> { { "Toto", "Titi" }, { "Corentin", "Biroute" }, { "Jerome", "Toto" }, { "Mickael", "Lesboubis" }, { "Wilfrid", "AFK" } };
        static object[] admin = new object[] { "Admin", "password" };

        public static int TestUser(string name, string password)
        {
            if (Convert.ToString(Test.admin[0]) == name)
            {
                if (Convert.ToString(Test.admin[1]) == password)
                {
                    return 1;
                }
            }

            foreach (KeyValuePair<string, string> item in Toto)
            {
                if (item.Key == name)
                {
                    if (item.Value == password)
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
    }
}