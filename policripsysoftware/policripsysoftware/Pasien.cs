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
        private int no_pasien;
        private string nama_pasien;
        private string tanggal_lahir;
        private string gender;
        private string nohp;
        private string alamat;
        Dokter dokter = new Dokter();
     
        DbCreator db = new DbCreator();

        public Pasien()
        {           
        }
        public int nopasien { get { return no_pasien; } set { no_pasien = value; } }
        public string namapasien { get { return nama_pasien; } set { nama_pasien = value; } }
        public string tanggallahir { get { return tanggal_lahir; } set { tanggal_lahir = value; } }
        public string gen { get { return gender; } set { gender = value; } }
        public string np { get { return nohp; } set { nohp = value; } }
        public string ala { get { return alamat ; } set { alamat = value; } }
        public string dokternm { get { return dokter.namadokter; } set { dokter.namadokter = value; } }
        
        ///Method untuk menambahkan data pada database
        public void add()
        {
            //melakukan koneksi database
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            //Query SQL untuk menambahkan data pada tabel pasien
            SQLiteCommand Query = new SQLiteCommand("insert into pasien(nama_pasien,tanggal_lahir,gender,nohp,alamat,dokter) values(@b,@c,@d,@e,@f,@g)", sql_con);
            Query.Parameters.AddWithValue("@b", namapasien);
            Query.Parameters.AddWithValue("@c", tanggallahir);
            Query.Parameters.AddWithValue("@d", gen);
            Query.Parameters.AddWithValue("@e", np);
            Query.Parameters.AddWithValue("@f", ala);
            Query.Parameters.AddWithValue("@g", dokternm);
            try
            {
                Query.ExecuteNonQuery();
                MessageBox.Show("Pendaftaran Berhasil!");
                Pendaftaran pbw = new Pendaftaran();
                pbw.Close();
                MainMenu MM = new MainMenu();
                MM.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void delete(DataGrid dataGrid)
        {
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            if (dataGrid.SelectedItem == null)
                return;
            
            
            foreach(var item in dataGrid.SelectedItems.Cast<DataRowView>())
            {
                //Query sql untuk menghapus data 
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM pasien WHERE no_pasien=" + item["no_pasien"], sql_con))
                {
                    comm.ExecuteNonQuery();
                }
            }
        }
        //Method untuk mengupdate data
        public void update()
        {
            SQLiteConnection sql_con = db.sql_con();
            SQLiteCommand Query = new SQLiteCommand("update pasien(nama,tanggallahir,nohp,noktp) values(@b,@c,@d,@e)", sql_con);
            Query.Parameters.AddWithValue("@b", namapasien);
            Query.Parameters.AddWithValue("@c", tanggallahir);
            Query.Parameters.AddWithValue("@d", gen);
            Query.Parameters.AddWithValue("@e", np);
            Query.Parameters.AddWithValue("@f", ala);


            ///tes

        }
        //Method untuk melihat data
        public void view(DataGrid dataGrid)
        {
            SQLiteConnection sql_con = db.sql_con();
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