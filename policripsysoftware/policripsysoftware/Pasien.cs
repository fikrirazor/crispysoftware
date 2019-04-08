using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;

namespace policripsysoftware
{
    class pasien
    {
        private int nopasien;
        private string nama;
        private string tanggallahir;
        //private JenisKelamin jeniskelamin;
        private string nohp;
        private string noktp;

        public pasien()
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
                MessageBox.Show("Pendaftaran Berhasil!")
                pbw pbw = new pbw();
                pbw.Close();
                pw pw = new pw();
                pw.Show();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void delete()
        {
            
        }

        public void show()
        {

        }
    }
}