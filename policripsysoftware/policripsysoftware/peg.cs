﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Data.SQLite;
namespace policripsysoftware
{
    class peg
    {
        private int no_peg;
        private string nama_peg;
        private string password;
        private string dbConnectionString = string.Format(@"Data Source=//db//poliklinik.db;Version=3;New=False;Compress=True;Journal Mode=Off");
        public peg(int no_peg, string nama_peg)
        {
            this.no_peg = no_peg;
            this.nama_peg = nama_peg;
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
        public string login(string username, string password)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString, true);
            // Open Connection to database
            try
            {
                sqliteCon.Open();
                string Query = "select * from karyawan where username='" + username + "' and password='" + password + "' ";
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
