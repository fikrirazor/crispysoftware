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

/// <summary>
/// ini adalah pasien baru window digunakan untuk pendaftaran pasien.
/// </summary>
namespace policripsysoftware
{
    /// <summary>
    /// Interaction logic for Pendaftaran.xaml
    /// </summary>
    public partial class Pendaftaran : Window
    {
        Pasien ps = new Pasien();
        public Pendaftaran()
        {
            InitializeComponent();
            BindComboBox(doktertxt);
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
    

    private void Pbb_Click(object sender, RoutedEventArgs e)
        {
            ps.namapasien = namatxt.Text;
            ps.tanggallahir = tanggallahirtxt.Text;
            ps.gen = Jenisklamintxt.Text;
            ps.np = nohptxt.Text ;
            ps.ala = alamattxt.Text;
            ps.add();
                        
            
        }

       
    }
}
