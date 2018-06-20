using System.Collections.Generic;
using System.Data;

namespace TestApplication
{
    class Login
    {
        SQLiteHelper Helper { get; set; }
        readonly List<string> ColumnName = new List<string> { "Login", "Password" };
        readonly List<SQLiteTypes> ColumnTypeLite = new List<SQLiteTypes> { SQLiteTypes.VARCHAR, SQLiteTypes.VARCHAR };
        readonly List<bool> ColumnAllowNull = new List<bool> { false, false };

        public Login(string dbfile)
        {
            Helper = new SQLiteHelper { dbfile = dbfile };
        }
        public void Fill()
        {
            ColumnList header = new ColumnList();
            for (int i = 0; i < ColumnName.Count; i++)
            {
                header.Add(ColumnName[i], ColumnTypeLite[i], ColumnAllowNull[i]);
            }
            Table table = new Table { Name = "SignIn", Columns = header };
            Helper.CreateTable(table);
        }
        public void AddEntry(string Login, string Password)
        {
            EntryList Entry = new EntryList();
            List<DbType> ColumnType = new List<DbType> { DbType.String, DbType.String };
            List<string> ColumnContent = new List<string> { Login, Password };
            Entry.ColumnName = ColumnName;
            Entry.DbType = ColumnType;
            Entry.Content = ColumnContent;
            Helper.CreateEntry("SignIn", Entry);
        }
        public List<ListWithName> GenEntries(string ColumName)
        {
            return Helper.GenEntries("SignIn", ColumName);
        }
    }
}
