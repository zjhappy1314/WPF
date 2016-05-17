using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// WindowComposite.xaml 的交互逻辑
    /// </summary>
    public partial class WindowComposite : Window
    {
        public WindowComposite()
        {
            InitializeComponent();
        }

        private void grdTransfer_PreviewMouseLeftButtonDown( object sender, MouseButtonEventArgs e )
        {
                        
        }

        private void grdTransfer_PreviewMouseLeftButtonUp( object sender, MouseButtonEventArgs e )
        {

        }

        private void Window_StateChanged( object sender, EventArgs e )
        {
            if ( WindowState != WindowState.Normal && WindowState != WindowState.Minimized )
            {
                WindowState = WindowState.Normal;
            }
        }

        //private void Window_StateChanged( object sender, EventArgs e )
        //{
        //    if ( WindowState != WindowState.Normal && WindowState != WindowState.Minimized )
        //    {
        //        WindowState = WindowState.Normal;
        //    }
        //}

        //private void Window_Loaded( object sender, RoutedEventArgs e )
        //{

        //}
    }
}
