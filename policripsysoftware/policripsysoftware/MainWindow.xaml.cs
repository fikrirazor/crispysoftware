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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace policripsysoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void PasienButton_Click(object sender, RoutedEventArgs e)
        {
            var WP = new WindowPasien();
            WP.Show();
            this.Close();
        }

        private void KeuanganButton_Click(object sender, RoutedEventArgs e)
        {
            var LK = new LaporanKeuangan();
            LK.Show();
            this.Close();
        }
    }
}
