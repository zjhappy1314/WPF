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
    /// WindowStack.xaml 的交互逻辑
    /// </summary>
    public partial class WindowStack : Window
    {
        public WindowStack()
        {
            InitializeComponent();
        }

        private void Button_Click( object sender, RoutedEventArgs e )
        {
            if ( this.stackPanel.Orientation != Orientation.Horizontal )
            {
                this.stackPanel.Orientation = Orientation.Vertical;
            }
            else
            {
                this.stackPanel.Orientation = Orientation.Horizontal;
            }
            
        }

        private void StackPanels()
        {
            StackPanel sp = new StackPanel();
            this.Content = sp;
            sp.Margin = new Thickness( 0, 105, 0, 0 );
            sp.Background = new SolidColorBrush( Colors.Transparent );
            sp.Orientation = Orientation.Vertical;
            Button b1 = new Button();
            b1.Content = "后台代码，第一个";
            sp.Children.Add( b1 );
            Button b2 = new Button();
            b2.Content = "后台代码，第一个";
            sp.Children.Add( b2 );
            Button b3 = new Button();
            b3.Content = "后台代码，第一个";
            sp.Children.Add( b3 );
        }
        private void Button_Click_1( object sender, RoutedEventArgs e )
        {
            StackPanels();
        }

       
    }
}
