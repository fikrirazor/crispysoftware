using System;
using System.Collections.Generic;
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
        }

        private void Input_Transaksi_Click(object sender, RoutedEventArgs e)
        {
            ts.tanggaltransaksi = tanggaltransaksitxt.Text;
            //ts.totalbiaya = hargatxt.Text;
            ts.add();
        }
    }
}
