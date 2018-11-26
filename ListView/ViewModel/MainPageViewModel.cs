using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ListView.Model;
using static System.Math;
namespace ListView.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<Person> People {get; set;}= new ObservableCollection<Person>();
        public MainPageViewModel()
        {
                var person = new Person();
                //person.Name = "Jesse Libeerty " + i.ToString();
                //person.Age = (decimal)(35 + random.NextDouble());
                person.FirstName = "George";
                person.LastName = "Washington";
            person.PhoneNumber = "555-1212";
                //person.Address = i.ToString() + " Main Street";
                People.Add(person);
            PopulatePeople();
            //foreach (var p in Person.People)
            //{
            //    People.Add(p);
            //}
        }
        private async void PopulatePeople(){
            List<Person> people = await App.DataBase.GetPeopleAsync();
            foreach (var person in people)
            {
                People.Add(person);
            }
        }
    }
}
