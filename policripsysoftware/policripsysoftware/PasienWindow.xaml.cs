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
    /// Interaction logic for PasienWindow.xaml
    /// </summary>
    public partial class PasienWindow : Window
    {
        private char l;

        public PasienWindow()
        {
            InitializeComponent();
        }

        private void PerempuanButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void LakiButton_Checked(object sender, RoutedEventArgs e)
        {
            char p, l;
            var J = new JenisKelamin(l,p);
            l = l;
            J.validationgender(l, p);

        }
    }
}
