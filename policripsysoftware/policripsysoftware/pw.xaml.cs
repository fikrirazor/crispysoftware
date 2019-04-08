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
    /// Interaction logic for pw.xaml
    /// </summary>
    public partial class pw : Window
    {
        public pw()
        {
            InitializeComponent();
        }

        private void Bb_Click(object sender, RoutedEventArgs e)
        {
            var p = new pbw();
            p.Show();
            Close();
        }

        private void Bl_Click(object sender, RoutedEventArgs e)
        {
            var pl = new plw();
            pl.Show();
            Close();
        }

        private void Bkp_Click(object sender, RoutedEventArgs e)
        {
            var kpw = new kpw();
            kpw.Show();
            Close();
        }
    }
}
