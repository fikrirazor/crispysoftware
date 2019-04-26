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
    /// Interaction logic for LoginWindow.xaml
    /// LoginWindow=login window
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        Pegawai peg = new Pegawai();
        DbCreator db = new DbCreator();
        public LoginWindow()
        {
            db.createDbFile();
            db.createDbConnection();
            db.createTables();
            db.fillTable();
            InitializeComponent();
        }
        public void tutup()
        {
            Close();
        }

        private void lb_Click(object sender, RoutedEventArgs e)
        {
            peg.usr = txtusername.Text;
            peg.pass = txtpassword.Password;
            
            peg.login();
            Close();
            
        }

        private void Txtusername_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = string.Empty;
            tb.GotFocus -= Txtusername_GotFocus;
        }

        private void Txtpassword_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox tb = (PasswordBox)sender;
            tb.Password = string.Empty;
            tb.GotFocus -= Txtpassword_GotFocus;
        }

        private void txtusername_keyup(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            e.Handled = true;
            peg.usr = txtusername.Text;
            peg.pass = txtpassword.Password;
            peg.login();
            Close();
        }

        private void txtpassword_keyup(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            e.Handled = true;
            peg.usr = txtusername.Text;
            peg.pass = txtpassword.Password;
            peg.login();
            Close();
        }
    }
}
