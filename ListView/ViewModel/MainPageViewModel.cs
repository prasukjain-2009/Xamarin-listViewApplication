using System;
using System.Collections.ObjectModel;
using ListView.Model;

namespace ListView.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Person> People {get; set;}= new ObservableCollection<Person>();
        public MainPageViewModel()
        {
            for (int i = 0; i < 5; i++){
                Person person = new Person();
                person.FirstName = "Jesse";
                person.LastName = "Liberty " + i.ToString();
                person.Address = i.ToString() + " Main Street";
                People.Add(person);
            }
        }
    }
}
