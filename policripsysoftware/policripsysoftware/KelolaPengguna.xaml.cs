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

        public KelolaPengguna()
        {
            InitializeComponent();
        }

        private void Btv_Click(object sender, RoutedEventArgs e)
        {
            DbCreator db = new DbCreator();
            db.showpasien(this.dataGrid);

             
        }

        private void DeleteButtonPasien_Click(object sender, RoutedEventArgs e)
        {
            p.delete(this.dataGrid);
        }
    }
}
