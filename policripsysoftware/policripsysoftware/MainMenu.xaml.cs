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
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Bb_Click(object sender, RoutedEventArgs e)
        {
            var p = new Pendaftaran();
            MainArea.Children.Clear();

            object content = p.Content;
            p.Content = null;
            MainArea.Children.Add(content as UIElement);        
        }

        private void Bl_Click(object sender, RoutedEventArgs e)
        {
            var pl = new TransaksiWindow();
            MainArea.Children.Clear();

            object content = pl.Content;
            pl.Content = null;
            MainArea.Children.Add(content as UIElement);
        }

        private void Bkp_Click(object sender, RoutedEventArgs e)
        {
            var kpw = new KelolaPengguna();
            MainArea.Children.Clear();

            object content = kpw.Content;
            kpw.Content = null;
            MainArea.Children.Add(content as UIElement);
        }

        private void Btn_keluar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
