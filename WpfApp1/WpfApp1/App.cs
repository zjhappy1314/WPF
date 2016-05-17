using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class App
    {
        [STAThread]
        static void Main()
        {
            //定义Application对象作为整个应用程序入口
            Application app = new Application();

            #region 方法一：调用run方法，这种方式和winform的调用一样
            //MainWindow mWin = new MainWindow();
            //Window1 win = new Window1();
            WindowBindData win = new WindowBindData();
            app.Run( win );            
            #endregion

            #region 方法二：指定application对象的MainWindow属性为启动窗体，然后调用无参数的Run方法
            //MainWindow mwin = new MainWindow();
            //app.MainWindow = mwin;
            //mwin.Show();//必须要这步，否则无法显示窗体
            //Window1 win1 = new Window1();
            //app.MainWindow = win1;
            //win1.Show();
            //app.Run();            
            #endregion

            #region 方法三：通过Url的方式启动
            //app.StartupUri = new Uri( "Window1.xaml", UriKind.Relative );
            //app.StartupUri = new Uri( "WindowThd.xaml", UriKind.Relative );
            //app.ShutdownMode = ShutdownMode.OnMainWindowClose;
            //app.Run();            
            #endregion

        }
    }
}
