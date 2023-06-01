using ContactManager.Applications.RepositoryContracts;
using ContactManager.Core.Domain.Entities;

using System.Linq.Expressions;

namespace ContactManager.Infrastructure.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public Task<Person> AddPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePersonByPersonID(Guid personID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetFilteredPersons(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Person?> GetPersonByPersonID(Guid personID)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdatePerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
