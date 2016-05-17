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
    /// WindowViewBox.xaml 的交互逻辑
    /// </summary>
    public partial class WindowViewBox : Window
    {
        public WindowViewBox()
        {
            InitializeComponent();
        }
        List<StretchHelper> cbStretchList = new List<StretchHelper>();
        List<StretchDirectionHelper> cbStretchDirectionList = new List<StretchDirectionHelper>();
        private void BindDrp()
        {
            //填充comboBox内容
            cbStretchList.Add( new StretchHelper() { StretchModeName = "Fill", theStretchMode = Stretch.Fill } );
            cbStretchList.Add( new StretchHelper() { StretchModeName = "None", theStretchMode = Stretch.None } );
            cbStretchList.Add( new StretchHelper() { StretchModeName = "Uniform", theStretchMode = Stretch.Uniform } );
            cbStretchList.Add( new StretchHelper() { StretchModeName = "UniformToFill", theStretchMode = Stretch.UniformToFill } );
            cbStretch.ItemsSource = cbStretchList;
            cbStretch.DisplayMemberPath = "StretchModeName";
            cbStretchDirectionList.Add( new StretchDirectionHelper() { StretchDirectionName = "DownOnly", theStretchDirection = StretchDirection.DownOnly } );
            cbStretchDirectionList.Add( new StretchDirectionHelper() { StretchDirectionName = "UpOnly", theStretchDirection = StretchDirection.UpOnly } );
            cbStretchDirectionList.Add( new StretchDirectionHelper() { StretchDirectionName = "Both", theStretchDirection = StretchDirection.Both } );
            cbStretchDirection.ItemsSource = cbStretchDirectionList;
            cbStretchDirection.DisplayMemberPath = "StretchDirectionName";
        }

        private void cbStretch_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if ( cbStretch.SelectedItem != null )
            {
                viewBoxTest.Stretch = ( cbStretch.SelectedItem as StretchHelper ).theStretchMode;
            }
        }

        private void cbStretchDirection_SelectionChanged( object sender, SelectionChangedEventArgs e )
        {
            if ( cbStretchDirection.SelectedItem != null )
            {
                viewBoxTest.StretchDirection = ( cbStretchDirection.SelectedItem as StretchDirectionHelper ).theStretchDirection;
            }
        }

        private void Window_Loaded( object sender, RoutedEventArgs e )
        {
            BindDrp();
        }

        #region 定义两个辅助类StretchHelper和StretchDirection
        public class StretchHelper
        {
            public string StretchModeName { get; set; }
            public Stretch theStretchMode { get; set; }
        }
        public class StretchDirectionHelper
        {
            public string StretchDirectionName { get; set; }
            public StretchDirection theStretchDirection { get; set; }
        }
        #endregion



    }
}
