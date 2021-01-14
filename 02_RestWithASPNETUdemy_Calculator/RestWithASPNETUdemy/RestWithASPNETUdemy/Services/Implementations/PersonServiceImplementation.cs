using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        public Person Creste(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();

            for (int i=0; i<8; i++)
            {
                persons.Add(new Person()
                {
                    Id = i,
                    FirstName = "Person Name " + i,
                    LastName = "Person Lastname " + i,
                    Address = "Person Address " + i,
                    Gender = "Male"
                });
            }

            return persons;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = id,
                FirstName = "Leandro",
                LastName = "Costa",
                Address = "Bauru / São Paulo / Brasil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
           return person;
        }
    }
}
