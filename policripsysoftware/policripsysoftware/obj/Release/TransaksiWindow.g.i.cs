﻿#pragma checksum "..\..\TransaksiWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "F1C29AA30AEBBC2E15C50EAD08E3169DCD4789DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using policripsysoftware;


namespace policripsysoftware {
    
    
    /// <summary>
    /// TransaksiWindow
    /// </summary>
    public partial class TransaksiWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pasientxt;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox hargatxt;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker tanggaltransaksitxt;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox Riwayattxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid transaksidata;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Input_Transaksi;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\TransaksiWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button view;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/policripsysoftware;component/transaksiwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TransaksiWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pasientxt = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.hargatxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\TransaksiWindow.xaml"
            this.hargatxt.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Hargatxt_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tanggaltransaksitxt = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.Riwayattxt = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 5:
            this.transaksidata = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.Input_Transaksi = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\TransaksiWindow.xaml"
            this.Input_Transaksi.Click += new System.Windows.RoutedEventHandler(this.Input_Transaksi_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.view = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\TransaksiWindow.xaml"
            this.view.Click += new System.Windows.RoutedEventHandler(this.view_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

