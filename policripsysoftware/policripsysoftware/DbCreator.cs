using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Controls;
using System.Data;

namespace policripsysoftware
{
    class DbCreator
    {
        SQLiteConnection dbConnection;
        SQLiteCommand command;
        string sqlCommand;
        string dbPath = System.Environment.CurrentDirectory + "\\DB";
        string dbFilePath;

        public void createDbFile()
        {
            if (!string.IsNullOrEmpty(dbPath) && !Directory.Exists(dbPath))
                Directory.CreateDirectory(dbPath);
            dbFilePath = dbPath + "\\poliklinik.db";
            if (!System.IO.File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
        }
        public SQLiteConnection sql_con()
        {
            string dbPath = System.Environment.CurrentDirectory + "\\DB";
            string dbFilePath = dbPath + "\\poliklinik.db";
            SQLiteConnection sql_con = new SQLiteConnection(string.Format("Data Source={0};", dbFilePath));
            return sql_con;
        }
        public string createDbConnection()
        {
            string strCon = string.Format("Data Source={0};", dbFilePath);
            dbConnection = new SQLiteConnection(strCon);
            dbConnection.Open();
            command = dbConnection.CreateCommand();
            return strCon;
        }

        public void createTables()
        {
            if (!checkIfExist("pegawai"))
            {
                sqlCommand = "CREATE TABLE pegawai(no_peg INTEGER PRIMARY KEY, nama_peg TEXT NOT NULL, username TEXT NOT NULL UNIQUE, password TEXT  NOT NULL);";
                executeQuery(sqlCommand);
            }            
        }

        public bool checkIfExist(string tableName)
        {
            command.CommandText = "SELECT name FROM sqlite_master WHERE name='" + tableName + "'";
            var result = command.ExecuteScalar();

            return result != null && result.ToString() == tableName ? true : false;
        }

        public void executeQuery(string sqlCommand)
        {
            SQLiteCommand triggerCommand = dbConnection.CreateCommand();
            triggerCommand.CommandText = sqlCommand;
            triggerCommand.ExecuteNonQuery();
        }

        public bool checkIfTableContainsData(string tableName)
        {
            command.CommandText = "SELECT count(*) FROM " + tableName;
            var result = command.ExecuteScalar();

            return Convert.ToInt32(result) > 0 ? true : false;
        }

        public void fillTable()
        {
            if (!checkIfTableContainsData("pegawai"))
            {
                sqlCommand = "insert into pegawai (no_peg,nama_peg, username, password) VALUES (1, 'admin', 'admin', 'admin');";
                executeQuery(sqlCommand);
            }
        }
        public void showpasien(DataGrid dataGrid)
        {
            string dbPath = System.Environment.CurrentDirectory + "\\DB";
            string dbFilePath = dbPath + "\\poliklinik.db";
            SQLiteConnection sql_con = new SQLiteConnection(string.Format("Data Source={0};", dbFilePath));
            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From pasien", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGrid.ItemsSource = dt.AsDataView();

        }
    }
}
