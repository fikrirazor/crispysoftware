using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace policripsysoftware
{
    /// <summary>
    /// Interaction logic for KelolaPengguna.xaml
    /// </summary>
    public partial class KelolaPengguna : Window
    {
        Pasien p = new Pasien();
        Dokter d = new Dokter();

        public KelolaPengguna()
        {
            InitializeComponent();
            BindComboBox(doktertxt);
            BindComboBox2(nopasientxt);
            BindComboBox3(nodoktertxt);
        }
        public void BindComboBox(ComboBox comboBoxName)
        {
            DbCreator db = new DbCreator();
            SQLiteConnection sql_con = db.sql_con();

            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select nama_dokter From dokter", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds, "dokter");

            comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["nama_dokter"].ToString();
            comboBoxName.SelectedValuePath = ds.Tables[0].Columns["nama_dokter"].ToString();
        }
        public void BindComboBox2(ComboBox comboBoxName)
        {
            DbCreator db = new DbCreator();
            SQLiteConnection sql_con = db.sql_con();

            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select no_pasien From pasien", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds, "pasien");

            comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["no_pasien"].ToString();
            comboBoxName.SelectedValuePath = ds.Tables[0].Columns["no_pasien"].ToString();
        }
        public void BindComboBox3(ComboBox comboBoxName)
        {
            DbCreator db = new DbCreator();
            SQLiteConnection sql_con = db.sql_con();

            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select no_dokter From dokter", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds, "dokter");

            comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["no_dokter"].ToString();
            comboBoxName.SelectedValuePath = ds.Tables[0].Columns["no_dokter"].ToString();
        }
        private void Adddokter_Click(object sender, RoutedEventArgs e)
        {
            d.namadokter=namadoktertxt.Text;
            d.spes=spesialistxt.Text;
            d.add();
        }

        private void Viewdokter_Click(object sender, RoutedEventArgs e)
        {
            d.view(datagriddokter);
        }

        private void Updatedokter_Click(object sender, RoutedEventArgs e)
        {
            d.nodokter = int.Parse(nodoktertxt.Text);
            d.namadokter = namadoktertxt.Text;
            d.spes = spesialistxt.Text;
            d.update();
        }

        private void Deletedokter_Click(object sender, RoutedEventArgs e)
        {
            d.delete(datagriddokter);
        }

        private void Addpasien_Click(object sender, RoutedEventArgs e)
        {
            p.namapasien = namatxt.Text;
            p.tanggallahir = tanggallahirtxt.Text;
            p.gen = Jenisklamintxt.Text;
            p.np = nohptxt.Text;
            p.ala = alamattxt.Text;
            p.dokternm = doktertxt.Text;
            p.add();
        }

        private void viewpasien_Click(object sender, RoutedEventArgs e)
        {
            DbCreator db = new DbCreator();
            db.showpasien(datapasiengrid);
        }
        private void DeleteButtonPasien_Click(object sender, RoutedEventArgs e)
        {
            p.delete(datapasiengrid);
        }

        private void Updatepasien_Click(object sender, RoutedEventArgs e)
        {
            p.nopasien = int.Parse(nopasientxt.Text);
            p.namapasien = namatxt.Text;
            p.tanggallahir = tanggallahirtxt.Text;
            p.gen = Jenisklamintxt.Text;
            p.np = nohptxt.Text;
            p.ala = alamattxt.Text;
            p.dokternm = doktertxt.Text;
            p.update();
        }

        private void Nohptxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(nohptxt.Text, "^(^\\+62\\s?|^0)(\\d{3,4}-?){2}\\d{3,4}$"))
            {
                MessageBox.Show("Format salah Contoh : 085641910342.");
                nohptxt.Text = nohptxt.Text.Remove(nohptxt.Text.Length - 1);
            }
        }
    }
}
