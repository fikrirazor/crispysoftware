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
    /// Interaction logic for kpw.xaml
    /// </summary>
    public partial class kpw : Window
    {
        public kpw()
        {
            InitializeComponent();
        }

        private void Btv_Click(object sender, RoutedEventArgs e)
        {
            /*
            string dbPath = System.Environment.CurrentDirectory + "\\DB";
            string dbFilePath = dbPath + "\\poliklinik.db";
            SQLiteConnection sql_con = new SQLiteConnection(string.Format("Data Source={0};", dbFilePath));
            sql_con.Open();
            SQLiteCommand comm = new SQLiteCommand("Select * From pasien", sql_con);
            SQLiteDataAdapter da = new SQLiteDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            */
            pasien ps = new pasien();
            //this.dataGrid.ItemsSource = dt.AsDataView();
            ps.show(this.dataGrid);

             
        }
    }
}
