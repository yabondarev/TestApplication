using System.Collections.Generic;

namespace TestApplication
{
    static class LRepository
    {
        static Login login = new Login(SignIn.dbname);       
        public static List<ListWithName> table = login.GenEntries("*");
        static public void Reset()
        {
            login = new Login(SignIn.dbname);
            table = login.GenEntries("*");
        }
        public static void AddEntry(string Login, string Password)
        {
            login.AddEntry(Login, Password);
        }
    }
}
