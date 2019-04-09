using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HomeWork
{
    public partial class MainPage : ContentPage
    {
        public class Student :INotifyPropertyChanged
        {
            public int _StudentID;
            public string _Name;
            public string _Surname;
            public int StudentID
            {
                get
                {
                    return _StudentID;
                }
                set
                {
                    _StudentID = value;
                }
            }
            public string Name
            {
                get
                {
                    return _Name;
                }
                set
                {
                    _Name = value;
                    OnPropertyChanged();
                }
            }
            public  string Surname
            {
                get
                {
                    return _Surname;
                }
                set
                {
                    _Surname = value;
                    OnPropertyChanged();
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(propertyName));
                
            }
            
        }
        public MainPage()
        {
            InitializeComponent();
            List<Student> st = new List<Student>();
            st.Add(new Student { StudentID = 1,Name="Yasin", Surname = "Firat" });
            st.Add(new Student { StudentID = 1, Name = "Yasinx", Surname = "Firat" });
            st.Add(new Student { StudentID = 2, Name = "Aydin", Surname = "Firat" });
            list.BindingContext = st;
           
        }
        private void onSelect(object sender,SelectedItemChangedEventArgs e)
        {
            item.BindingContext = list.SelectedItem;

        }
    }
}
