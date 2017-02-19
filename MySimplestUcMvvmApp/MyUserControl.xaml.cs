using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySimplestUcMvvmApp
{
    /// <summary>
    /// Interaktionslogik für MyUserControl.xaml
    /// </summary>
    public partial class MyUserControl : UserControl, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private String stringFromUserControl;
        public String StringFromUserControl
        {
            get { return stringFromUserControl; }
            set
            {
                if (value != StringFromUserControl)
                {
                    stringFromUserControl = value;
                    OnPropertyChanged("StringFromMainWindowViewModelToUserControlDP");
                }
            }
        }

        public String StringDPForUserControlToSetFromOutside
        {
            get { return (String)GetValue(StringDPForUserControlToSetFromOutsideProperty); }
            set { SetValue(StringDPForUserControlToSetFromOutsideProperty, value); }
        }
        public static readonly DependencyProperty StringDPForUserControlToSetFromOutsideProperty =
            DependencyProperty.Register("StringDPForUserControlToSetFromOutside", typeof(string), typeof(MyUserControl), new PropertyMetadata(""));

        public MyUserControl()
        {
            InitializeComponent();
            DataContext = this;

            StringFromUserControl = "String From UserControl";
        }

        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
