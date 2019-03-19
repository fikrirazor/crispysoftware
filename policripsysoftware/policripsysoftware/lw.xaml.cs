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
        string dbConnectionString = string.Format(@"Data Source=\\db\\poliklinik.db;Version=3;New=False;Compress=True;Journal Mode=Off"); 
        public lw()
        {
            InitializeComponent();
        }

        private void Lb_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection sqliteCon = new SQLiteConnection(dbConnectionString,true);
            // Open Connection to database
            try
            {
                sqliteCon.Open();
                string Query = "select * from karyawan where username='" + this.txtusername.Text + "' and password='" + this.txtpassword.Password + "' ";
                SQLiteCommand createCommand = new SQLiteCommand(Query, sqliteCon);

                createCommand.ExecuteNonQuery();
                SQLiteDataReader dr = createCommand.ExecuteReader();

                int count = 0;
                while (dr.Read())
                {
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Username and Password is Correct");
                }
                if (count > 1)
                {
                    MessageBox.Show("Duplicate Username and password Try Again");
                }
                if (count < 1)
                {
                    MessageBox.Show("Username and password is not correct");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
