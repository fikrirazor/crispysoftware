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
    /// Interaction logic for lw.xaml
    /// </summary>
    public partial class lw : Window
    {
        string dbConnectionString = string.Format(@"Data Source=//db//poliklinik.db;Version=3;New=False;Compress=True;Journal Mode=Off"); 
        public lw()
        {
            InitializeComponent();
        }

        private void Lb_Click(object sender, RoutedEventArgs e)
        {
            peg peg = new peg();
            peg.login(this.txtusername.Text,this.txtpassword.Password);

        }
    }
}
