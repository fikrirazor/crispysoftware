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

/// <summary>
/// ini adalah pasien baru window digunakan untuk pendaftaran pasien.
/// </summary>
namespace policripsysoftware
{
    /// <summary>
    /// Interaction logic for PendaftaranBaru.xaml
    /// </summary>
    public partial class PendaftaranBaru : Window
    {
        Pasien ps = new Pasien();
        public PendaftaranBaru()
        {
            InitializeComponent();
        }

        private void Pbb_Click(object sender, RoutedEventArgs e)
        {
            ps.nm = namatxt.Text;
            ps.nk = noktptxt.Text;
            ps.nh = nohptxt.Text;
            ps.tl = tanggallahirtxt.SelectedDate.ToString();
            ps.mendaftar();
                        
            
        }
    }
}
