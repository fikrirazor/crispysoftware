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

        private void viewpasien(object sender, RoutedEventArgs e)
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
            p.update();
        }
    }
}
