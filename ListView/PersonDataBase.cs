using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ListView.Model;
using SQLite;

namespace ListView.Data
{
    public class PersonDataBase
    {
        readonly SQLiteAsyncConnection database;

        public PersonDataBase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Person>().Wait();
        }

        public Task<List<Person>> GetPeopleAsync()
        {
            return database.Table<Person>().ToListAsync();
        }
        public Task<Person> GetPersonAsync(int ID)
        {
            return database.Table<Person>().Where(i => i.ID == ID).FirstOrDefaultAsync();
        }

        public Task<int> SavePersonAsync(Person person)
        {
            Console.WriteLine("SAVE PERSON");
            if (person.ID == 0)
            {
                return database.UpdateAsync(person);
            }
            else
            {
                return database.InsertAsync(person);
            }
        }

        public Task<int> DeletePersonAsync(Person person)
        {
            return database.DeleteAsync(person);
        }
    }
}
