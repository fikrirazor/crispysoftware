using System;
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
        DbCreator db = new DbCreator();

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
        ///Method untuk menambahkan data pada database
        public void add()
        {
            //melakukan koneksi database
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            //Query SQL untuk menambahkan data pada tabel pasien
            SQLiteCommand Query = new SQLiteCommand("insert into pasien(nama,tanggallahir,nohp,noktp) values(@b,@c,@d,@e)", sql_con);
            Query.Parameters.AddWithValue("@b", nama);
            Query.Parameters.AddWithValue("@c", tanggallahir);
            Query.Parameters.AddWithValue("@d", nohp);
            Query.Parameters.AddWithValue("@e", noktp);
            try
            {
                Query.ExecuteNonQuery();
                MessageBox.Show("Pendaftaran Berhasil!");
                Pendaftaran pbw = new Pendaftaran();
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
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            if (dataGrid.SelectedItem == null)
                return;
            
            
            foreach(var item in dataGrid.SelectedItems.Cast<DataRowView>())
            {
                //Query sql untuk menghapus data 
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM pasien WHERE nopasien=" + item["nopasien"], sql_con))
                {
                    comm.ExecuteNonQuery();
                }
            }
        }
        //Method untuk mengupdate data
        public void update(DataGrid dataGrid)
        {
            SQLiteConnection sql_con = db.sql_con();
            SQLiteCommand Query = new SQLiteCommand("update pasien(nama,tanggallahir,nohp,noktp) values(@b,@c,@d,@e)", sql_con);
            Query.Parameters.AddWithValue("@b", nama);
            Query.Parameters.AddWithValue("@c", tanggallahir);
            Query.Parameters.AddWithValue("@d", nohp);
            Query.Parameters.AddWithValue("@e", noktp);
            
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