using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfApp1
{
    public class Student : DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        static Student()
        {
            NameProperty = DependencyProperty.Register( "Name", typeof( string ), typeof( Student ), new PropertyMetadata( "名称", OnValueChanged ) );
        }

        private static void OnValueChanged( DependencyObject d, DependencyPropertyChangedEventArgs e )
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { return ( string )GetValue( NameProperty ); }
            set { SetValue( NameProperty, value ); }
        }
    }
}
