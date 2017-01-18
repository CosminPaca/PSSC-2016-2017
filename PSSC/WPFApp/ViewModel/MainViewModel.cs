using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFApp
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private string _id;
        public string ID
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
        private string _nume;
        public string Nume
        {
            get { return _nume; }
            set
            {
                _nume = value;
                OnPropertyChanged("Nume");
            }
        }
        private string _credite;
        public string Credite
        {
            get { return _credite; }
            set
            {
                _credite = value;
                OnPropertyChanged("Credite");
            }
        }

        public ICommand GetStatusCommand
        {
            get { return new RelayCommand(e => GetStatus()); }
        }

        public void GetStatus()
        {
            //ToDo
            MessageBox.Show("Status ready");
           
        }


        #region INotifyPropertyChanged Methods

        public void OnPropertyChanged(string propertyName)
        {
            this.OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, args);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}

