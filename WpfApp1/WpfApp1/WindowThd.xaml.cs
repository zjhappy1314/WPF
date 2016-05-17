using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// WindowThd.xaml 的交互逻辑
    /// </summary>
    public partial class WindowThd : Window
    {
        public WindowThd()
        {
            InitializeComponent();
        }

        private void ModifyUI()
        {
            //模拟一些工作正在进行
            Thread.Sleep( TimeSpan.FromSeconds( 2 ) );
            //lblHello.Content = "欢迎你光临WPF的世界，Dispatcher";
            this.Dispatcher.Invoke( DispatcherPriority.Normal, ( ThreadStart )delegate() {
                lblHello.Content = "欢迎你光临WPF的世界，Dispatcher 同步方法！！";
            } );
        }

        private void btnThd_Click( object sender, RoutedEventArgs e )
        {
            Thread thread = new Thread( ModifyUI );
            thread.Start();
        }

        private void btnAppBeginInvoke_Click( object sender, RoutedEventArgs e )
        {
            new Thread( () =>
                {
                    Application.Current.Dispatcher.BeginInvoke( DispatcherPriority.Normal,
                        new Action(()=>
                            {
                                Thread.Sleep( TimeSpan.FromSeconds( 2 ) );
                                this.lblHello.Content = "欢迎你光临WPF的世界，Dispatcher异步方法" + DateTime.Now.ToString();                                
                            }) );
                } ).Start();
        }
    }
}
