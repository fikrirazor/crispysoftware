﻿using System;
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
        
        pegawai peg = new pegawai();
        public lw()
        {
            InitializeComponent();
        }

        private void Lb_Click(object sender, RoutedEventArgs e)
        {
           
            
            peg.usr = txtusername.Text;
            peg.pass = txtpassword.Password;
            peg.login();

        }
    }
}
