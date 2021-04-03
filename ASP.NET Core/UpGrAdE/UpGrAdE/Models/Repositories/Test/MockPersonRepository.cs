using UpGrAdE.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Repositories
{
    public class MockPersonRepository : IPersonRepository
    {
        private List<Person> _peopleList;


        public MockPersonRepository()
        {
            _peopleList = new List<Person> {
                new Person {
                    Id = 1,
                    Firstname="SCHAEFFER",
                    LastName="Philippe",
                    Email = "philippeschaeffer67@gmail.com",
                    Birthdate = new DateTime(1982,9,11)
                },
                new Person {
                    Id = 2,
                    Firstname="SCHAEFFER",
                    LastName="Marie",
                    Email = "charp.marie@gmail.com",
                    Birthdate = new DateTime(1982,5,9)
                },
                 new Person {
                    Id = 3,
                    Firstname="SCHAEFFER",
                    LastName="Camille",
                    Email = "",
                    Birthdate = new DateTime(2013,4,18)
                }
            };
        }

        public void Add(Person person)
        {
            throw new NotImplementedException();
        }

        List<Person> IPersonRepository.GetPeople()
        {
            return _peopleList;
        }

        Person IPersonRepository.GetPerson(int id)
        {
            return this._peopleList.FirstOrDefault(e => e.Id == id);
        }
    }
}
