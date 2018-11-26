using System;
using ListView.Model;

namespace ListView.ViewModel
{
    public class EntryPageViewModel
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public EntryPageViewModel()
        {
        }

        public void AddToPeople()
        {
            var person = new Person();
            person.FirstName = FirstName;
            Console.WriteLine("IN ADD TO PEOPLE");
            person.LastName = LastName;
            person.PhoneNumber = PhoneNumber;
            //Person.People.Add(person);
            App.DataBase.SavePersonAsync(person);
        }
    }
}
