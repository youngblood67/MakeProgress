using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpGrAdE.Models.Interfaces
{
    public interface IPersonRepository
    {
        Person GetPerson(int id);

        List<Person> GetPeople();

        void Add(Person person);
    }
}
