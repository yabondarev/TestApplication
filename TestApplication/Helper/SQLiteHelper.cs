using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace TestApplication
{
    public enum SQLiteTypes { VARCHAR, INTEGER, DATE };
    public class EntryList
    {
        public List<string> ColumnName { get; set; }
        public List<DbType> DbType { get; set; }
        public List<string> Content { get; set; }
        public EntryList()
        {
            ColumnName = new List<string>();
            DbType = new List<DbType>();
            Content = new List<string>();
        }
    }
    public class ListWithName
    {
        public string Text { set; get; }
        public List<string> SubItems { set; get; }
        public ListWithName()
        {
            SubItems = new List<string>();
        }
    }
    public class ColumnProperties
    {
        public string Name { get; set; }
        public SQLiteTypes DataType { get; set; }
        public bool AllowNull { get; set; }
    }

    public class ColumnList : IEnumerable<ColumnProperties>
    {
        List<ColumnProperties> cols = new List<ColumnProperties>();
        public ColumnList()
        {
            cols = new List<ColumnProperties>();
        }
        public IEnumerator<ColumnProperties> GetEnumerator()
        {
            return cols.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(string Name, SQLiteTypes DataType, bool AllowNull)
        {
            ColumnProperties col = new ColumnProperties { Name = Name, DataType = DataType, AllowNull = AllowNull };
            cols.Add(col);
        }
    }
    public class Table
    {
        public string Name { set; get; }
        public ColumnList Columns { get; set; }
        public Table()
        {
            Columns = new ColumnList();
        }
    }
    class SQLiteHelper
    {
        SQLiteDataReader DataReader;
        public string dbfile { set; get; }
        SQLiteConnection db = new SQLiteConnection();
        void SetConnection()
        {
            if (db.State == ConnectionState.Open)
                db.Close();
            db.ConnectionString = @"Data Source = ./database/" + dbfile + ";";
            db.Open();
        }
        public void CreateTable(Table Table)
        {
            SetConnection();
            string firstline = "create table if not exists [" + Table.Name + "]([id] INTEGER not null primary key autoincrement, ";
            StringBuilder querybuilder = new StringBuilder();
            querybuilder.Append(firstline);
            foreach (var i in Table.Columns)
            {
                string col = "";
                if (i.AllowNull) col = "NULL";
                else col = "NOT NULL";
                querybuilder.Append("[" + i.Name + "] " + (i.DataType).ToString() + " " + col + ", ");
            }
            querybuilder.Remove(querybuilder.Length - 2, 2);
            querybuilder.Append(")");
            SQLiteCommand query = new SQLiteCommand(querybuilder.ToString(), db);
            query.ExecuteNonQuery();
            db.Close();
        }
        public void CreateEntry(string TableName, EntryList EntryList)
        {
            SetConnection();
            StringBuilder querybuilder = new StringBuilder();
            querybuilder.Append("insert into " + TableName + " (");
            foreach (var i in EntryList.ColumnName)
            {
                querybuilder.Append(i + ", ");
            }
            querybuilder.Remove(querybuilder.Length - 2, 2);
            querybuilder.Append(")");
            querybuilder.Append(" values (");
            foreach (var i in EntryList.ColumnName)
            {
                querybuilder.Append("@" + i + ", ");
            }
            querybuilder.Remove(querybuilder.Length - 2, 2);
            querybuilder.Append(")");
            SQLiteCommand query = new SQLiteCommand(querybuilder.ToString(), db);
            for (int i = 0; i < EntryList.ColumnName.Count; i++)
            {
                query.Parameters.Add("@" + EntryList.ColumnName[i], EntryList.DbType[i]).Value = EntryList.Content[i];
            }
            query.ExecuteNonQuery();
            db.Close();
        }
        public List<ListWithName> GenEntries(string TableName, string ColumnNames)
        {
            List<ListWithName> list = new List<ListWithName>();
            SetConnection();
            SQLiteCommand query = new SQLiteCommand("select " + ColumnNames + " from " + TableName, db);
            DataReader = query.ExecuteReader();
            while (DataReader.Read())
            {
                ListWithName lwn = new ListWithName();
                for (int i = 0; i < DataReader.FieldCount; i++)
                {
                    lwn.SubItems.Add(DataReader[i].ToString());
                }
                list.Add(lwn);
            }
            db.Close();
            return list;
        }
    }

}
