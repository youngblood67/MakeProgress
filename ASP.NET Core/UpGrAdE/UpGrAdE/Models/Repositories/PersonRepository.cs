using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UpGrAdE.Models.Interfaces;

namespace UpGrAdE.Models.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        List<Person> _people;
        public PersonRepository()
        {
            _people = new List<Person>();
        }
        public void Add(Person person)
        {
           _people.Add(person);
        }

        public List<Person> GetPeople()
        {
            return _people;
        }

        public Person GetPerson(int id)
        {
            return _people.FirstOrDefault(e => e.Id == id);
        }
    }
}
