using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BELayer
{
    public class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int Id;

        public int id
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("id"); }
        }
        private string Name;

        public string name
        {
            get { return Name; }
            set { Name = value; OnPropertyChanged("name"); }
        }

        private string Email;

        public string email
        {
            get { return Email; }
            set { Email = value; OnPropertyChanged("email"); }
        }
        

        private String _gender = "Choose your gender";
        public String gender
        {
            get { return _gender; }
            set
            {
                if (value != _gender)
                {
                    _gender = value;
                    OnPropertyChanged("gender");
                }
            }
        }

        
        private String _status = "please select";
        public String status
        {
            get { return _status; }
            set
            {
                if (value != _status)
                {
                    _status = value;
                    OnPropertyChanged("status");
                }
            }
        }


    }
}
