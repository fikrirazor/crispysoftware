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
    class transaksi
    {
        private int no_transaksi;
        private string tanggal_transaksi;
        private double total_biaya;
        private string riwayat;
        private string pasien;
        DbCreator db = new DbCreator();
        public int notransaksi { get { return no_transaksi; } set { no_transaksi = value; } }
        public string tanggaltransaksi { get { return tanggal_transaksi; } set { tanggal_transaksi = value; } }
        public double totalbiaya { get { return total_biaya; } set { total_biaya = value; } }
        public string riw { get { return riwayat; } set { riwayat = value; } }
        public string pasiennm { get { return pasien; } set { pasien = value; } }
        public void add()
        {
            //melakukan koneksi database
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            if (!(tanggaltransaksi == String.Empty || riw == String.Empty || pasiennm == String.Empty))
            {
                //Query SQL untuk menambahkan data pada tabel pasien
                SQLiteCommand Query = new SQLiteCommand("insert into transaksi(tanggal_transaksi,total_biaya,riwayat,pasien) values(@b,@c,@d,@e)", sql_con);
            Query.Parameters.AddWithValue("@b", tanggaltransaksi);
            Query.Parameters.AddWithValue("@c", totalbiaya);
            Query.Parameters.AddWithValue("@d", riw);
            Query.Parameters.AddWithValue("@e", pasiennm);
            try
            {
                Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil ditambahklan!");
                TransaksiWindow tw = new TransaksiWindow();
                tw.Close();
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            }
            else
            {
                MessageBox.Show("Data tidak boleh Kosong!");
                
            }
        }
        
        //Method untuk melihat data
        public void view(DataGrid dataGrid)
        {
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From transaksi", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGrid.ItemsSource = dt.AsDataView();
            MessageBox.Show("Data Disegarkan!");
        }
    }
}
