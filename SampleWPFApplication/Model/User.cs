using System.ComponentModel;

namespace SampleWPFApplication.Model
{
    class User : INotifyPropertyChanged
    {
        int userId;
        string firstName;
        string lastName;
        string city;
        string state;
        string country;

        public int UserId { get { return userId; } set { userId = value; OnPropertyChanged("UserId"); } }
        public string FirstName { get { return firstName; }set{ firstName = value; OnPropertyChanged("FirstName"); } }
        public string LastName { get { return lastName; } set { lastName = value; OnPropertyChanged("LastName"); } }
        public string City { get { return city; }set { city = value; OnPropertyChanged("City"); } }
        public string State { get { return state; } set { state = value; OnPropertyChanged("State"); } }
        public string Country { get { return country; } set { country = value; OnPropertyChanged("Country"); } }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
