using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySimplestUcMvvmApp
{
    class MainWindowViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private String stringFromMainWindowViewModelToMainWindowView;
        public String StringFromMainWindowViewModelToMainWindowView
        {
            get { return stringFromMainWindowViewModelToMainWindowView; }
            set
            {
                if (value != StringFromMainWindowViewModelToMainWindowView)
                {
                    stringFromMainWindowViewModelToMainWindowView = value;
                    OnPropertyChanged("StringFromMainWindowViewModelToUserControlDP");
                }
            }
        }

        private String stringFromMainWindowViewModelToUserControlsDP;
        public String StringFromMainWindowViewModelToUserControlDP
        {
            get { return stringFromMainWindowViewModelToUserControlsDP; }
            set
            {
                if (value != StringFromMainWindowViewModelToUserControlDP)
                {
                    stringFromMainWindowViewModelToUserControlsDP = value;
                    OnPropertyChanged("StringFromMainWindowViewModelToUserControlDP");
                }
            }
        }

        public MainWindowViewModel()
        {
            StringFromMainWindowViewModelToMainWindowView = "String From MainWindow ViewModel To MainWindow View";
            StringFromMainWindowViewModelToUserControlDP = "String From MainWindow ViewModel To UserControl DP";
        }

        private void OnPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }
    }
}
