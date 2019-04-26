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
    /// Interaction logic for TransaksiWindow.xaml
    /// ini adalah pasien lama window digunakan jika ada pasien lama yang ingin mendaftar
    /// </summary>
    public partial class TransaksiWindow : Window
    {
        transaksi ts = new transaksi();
        public TransaksiWindow()
        {
            InitializeComponent();
            BindComboBox(pasientxt);

        }
        public void BindComboBox(ComboBox comboBoxName)
        {
            DbCreator db = new DbCreator();
            SQLiteConnection sql_con = db.sql_con();

            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select nama_pasien From pasien", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds, "pasien");

            comboBoxName.ItemsSource = ds.Tables[0].DefaultView;
            comboBoxName.DisplayMemberPath = ds.Tables[0].Columns["nama_pasien"].ToString();
            comboBoxName.SelectedValuePath = ds.Tables[0].Columns["nama_pasien"].ToString();
        }
        private void Input_Transaksi_Click(object sender, RoutedEventArgs e)
        {
            ts.tanggaltransaksi = tanggaltransaksitxt.Text;
            double textBoxValue = double.Parse(hargatxt.Text);
            ts.totalbiaya = textBoxValue;
            string richText = new TextRange(Riwayattxt.Document.ContentStart, Riwayattxt.Document.ContentEnd).Text;
            ts.riw = richText;
            ts.pasiennm = pasientxt.Text;
            ts.add();
        }

        private void view_Click(object sender, RoutedEventArgs e)
        {
            
            ts.view(transaksidata);
        }
    }
}
