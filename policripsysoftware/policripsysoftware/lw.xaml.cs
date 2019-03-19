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

using System.Data.SQLite;
namespace policripsysoftware
{
    /// <summary>
    /// Interaction logic for lw.xaml
    /// </summary>
    public partial class lw : Window
    {
        string dbConnectionString = @"Data Source=db\poliklinik.db;Version=3;";
        public lw()
        {
            InitializeComponent();
        }

        private void Lb_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString);
            // Open Connection to database
            try
            {
                sqliteCon.Open();
                string Query = "select * from karyawan where username='"
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message)
            }
        }
    }
}
