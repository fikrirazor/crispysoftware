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
    /// Interaction logic for plw.xaml
    /// ini adalah pasien lama window digunakan jika ada pasien lama yang ingin mendaftar
    /// </summary>
    public partial class plw : Window
    {
        public plw()
        {
            InitializeComponent();
            DbCreator db = new DbCreator();
            db.showpasien(this.datapasien);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
