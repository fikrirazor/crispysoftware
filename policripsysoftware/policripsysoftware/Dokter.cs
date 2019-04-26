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
    class Dokter
    {
        private int no_dokter;
        private string nama_dokter;
        private string spesialis;
        DbCreator db = new DbCreator();
        public int nodokter { get { return no_dokter; } set { no_dokter = value; } }
        public string namadokter { get { return nama_dokter; } set { nama_dokter = value; } }
        public string spes { get { return spesialis; } set { spesialis = value; } }


        ///Method untuk menambahkan data pada database
        public void add()
        {
            //melakukan koneksi database
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            //Query SQL untuk menambahkan data pada tabel pasien
            SQLiteCommand Query = new SQLiteCommand("insert into pasien(nama_dokter,spesialis) values(@b,@c)", sql_con);
            Query.Parameters.AddWithValue("@b", namadokter);
            Query.Parameters.AddWithValue("@c", spes);
            try
            {
                Query.ExecuteNonQuery();
                MessageBox.Show("Berhasil ditambahklan!");
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


            foreach (var item in dataGrid.SelectedItems.Cast<DataRowView>())
            {
                //Query sql untuk menghapus data 
                using (SQLiteCommand comm = new SQLiteCommand("DELETE FROM dokter WHERE no_pasien=" + item["no_pasien"], sql_con))
                {
                    comm.ExecuteNonQuery();
                }
            }
        }
        //Method untuk mengupdate data
        public void update(DataGrid dataGrid)
        {

        }
        //Method untuk melihat data
        public void view(DataGrid dataGrid)
        {
            SQLiteConnection sql_con = db.sql_con();
            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From dokter", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGrid.ItemsSource = dt.AsDataView();
        }
    }
}
