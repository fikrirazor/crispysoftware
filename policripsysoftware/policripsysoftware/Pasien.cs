﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using System.Data;
using System.Windows.Controls;

namespace policripsysoftware
{
    class Pasien
    {
        private int nopasien;
        private string nama;
        private string tanggallahir;
        //private JenisKelamin jeniskelamin;
        private string nohp;
        private string noktp;

        public Pasien()
        {           
        }
        public int np
        {
            get { return nopasien; }
            set { nopasien = value; }
        }
        public string nm
        {
            get { return nama; }
            set { nama = value; }
        }
        public string tl
        {
            get { return tanggallahir; }
            set { tanggallahir = value; }
        }
        public string nh
        {
            get { return nohp; }
            set { nohp = value; }
        }
        public string nk
        {
            get { return noktp; }
            set { noktp = value; }
        }

        public void mendaftar()
        {
            string dbPath = System.Environment.CurrentDirectory + "\\DB";
            string dbFilePath = dbPath + "\\poliklinik.db";
            SQLiteConnection sql_con = new SQLiteConnection(string.Format("Data Source={0};", dbFilePath));
            sql_con.Open();
            SQLiteCommand Query = new SQLiteCommand("insert into pasien(nama,tanggallahir,nohp,noktp) values(@b,@c,@d,@e)", sql_con);
            Query.Parameters.AddWithValue("@b", nama);
            Query.Parameters.AddWithValue("@c", tanggallahir);
            Query.Parameters.AddWithValue("@d", nohp);
            Query.Parameters.AddWithValue("@e", noktp);
            try
            {
                Query.ExecuteNonQuery();
                MessageBox.Show("Pendaftaran Berhasil!");
                PendaftaranBaru pbw = new PendaftaranBaru();
                pbw.Close();
                MainMenu pw = new MainMenu();
                pw.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void add()
        {
            string dbPath = System.Environment.CurrentDirectory + "\\DB";
            string dbFilePath = dbPath + "\\poliklinik.db";
            SQLiteConnection sql_con = new SQLiteConnection(string.Format("Data Source={0};", dbFilePath));
            sql_con.Open();
            SQLiteCommand Query = new SQLiteCommand("insert into pasien(nama,tanggallahir,nohp,noktp) values(@b,@c,@d,@e)", sql_con);
            Query.Parameters.AddWithValue("@b", nama);
            Query.Parameters.AddWithValue("@c", tanggallahir);
            Query.Parameters.AddWithValue("@d", nohp);
            Query.Parameters.AddWithValue("@e", noktp);
            try
            {
                Query.ExecuteNonQuery();
                MessageBox.Show("Pendaftaran Berhasil!");
                PendaftaranBaru pbw = new PendaftaranBaru();
                pbw.Close();
                MainMenu pw = new MainMenu();
                pw.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delete(DataGrid dataGrid)
        {
            string dbPath = System.Environment.CurrentDirectory + "\\DB";
            string dbFilePath = dbPath + "\\poliklinik.db";
            SQLiteConnection sql_con = new SQLiteConnection(string.Format("Data Source={0};", dbFilePath));
            sql_con.Open();

            if (dataGrid.SelectedCells.Count == 0)
                return;

            SQLiteCommand comm = new SQLiteCommand("delete from pasien where nopasien= @rownopasien", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);

        }
        public void update(DataGrid dataGrid)
        {

        }
        public void view(DataGrid dataGrid)
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