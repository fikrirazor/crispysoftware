using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace policripsysoftware
{
    class pegawai
    {
        private int no_peg;
        private string nama_peg;
        private string username;
        private string password;
        string dbPath = System.Environment.CurrentDirectory + "\\DB";
        string dbFilePath;
       
        public pegawai()
        {
        }

        public pegawai(int no_peg, string nama_peg, string username, string password)
        {
            this.no_peg = no_peg;
            this.nama_peg = nama_peg;
            this.username = username;
            this.password = password;
        }
        public string namapeg
        {
            get
            {
                return this.nama_peg;
            }
            set
            {
                this.nama_peg = value;
            }
        }
        public string pass
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value ;
            }
        }
        public string usr
        {
            get
            {
                return this.username;
            }
            set
            {
                this.username = value;
            }
        }

        public void login()
        {
            dbFilePath = dbPath + "\\poliklinik.db";
            string dbConnectionString = string.Format(@"Data Source={0};Version=3;New=False;Compress=True;Journal Mode=Off", dbFilePath);
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString, true);
            //Open Connection to database
            try
            {
                sqliteCon.Open();
                string Query = "select * from karyawan where username='" + usr + "' and password='" + pass + "' ";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);

                createCommand.ExecuteNonQuery();
                SQLiteDataReader dr = createCommand.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password is Correct");
                    pw pw = new pw();
                    pw.Show();
                    lw lw = new lw();
                    lw.Close();
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password Try Again");
                }
                if (count < 1)
                {
                    MessageBox.Show("Username and password is not correct");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
