using System;
using System.Collections.Generic;
using System.Data;

namespace TestApplication
{
    class Employees
    {
        SQLiteHelper Helper { get; set; }
        readonly List<string> ColumnName = new List<string> { "Name", "Date", "Post", "Salary", "pid" };
        readonly List<SQLiteTypes> ColumnTypeLite = new List<SQLiteTypes> { SQLiteTypes.VARCHAR, SQLiteTypes.VARCHAR, SQLiteTypes.VARCHAR, SQLiteTypes.VARCHAR, SQLiteTypes.INTEGER };
        readonly List<bool> ColumnAllowNull = new List<bool> { false, false, false, false, true };
        public Employees(string dbfile)
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
            Table table = new Table { Name = "Employees", Columns = header };
            Helper.CreateTable(table);
        }
        public void AddEntry(string Name, DateTime Date, string Post, int Salary)
        {
            EntryList Entry = new EntryList();
            List<DbType> ColumnType = new List<DbType> { DbType.String, DbType.String, DbType.String, DbType.Int16, DbType.Int16 };
            List<string> ColumnContent = new List<string> { Name, Date.ToShortDateString(), Post, Salary.ToString(), null };
            Entry.ColumnName = ColumnName;
            Entry.DbType = ColumnType;
            Entry.Content = ColumnContent;
            Helper.CreateEntry("Employees", Entry);
        }
        public void AddEntry(string Name, DateTime Date, string Post, int Salary, int pid)
        {
            EntryList Entry = new EntryList();
            List<DbType> ColumnType = new List<DbType> { DbType.String, DbType.String, DbType.String, DbType.Int16, DbType.Int16 };
            List<string> ColumnContent = new List<string> { Name, Date.ToShortDateString(), Post, Salary.ToString(), pid.ToString() };
            Entry.ColumnName = ColumnName;
            Entry.DbType = ColumnType;
            Entry.Content = ColumnContent;
            Helper.CreateEntry("Employees", Entry);
        }
        public List<ListWithName> GenEntries(string ColumName)
        {
            return Helper.GenEntries("Employees", ColumName);
        }
    }
}
