using ContactManager.Applications.RepositoryContracts;
using ContactManager.Core.Domain.Entities;

namespace ContactManager.Infrastructure.Repository
{
    public class CountryRepository : ICountryRepository
    {
        public Task<Country> AddCountry(Country country)
        {
            throw new NotImplementedException();
        }

        public Task<List<Country>> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Task<Country?> GetCountryById(Guid countryID)
        {
            throw new NotImplementedException();
        }

        public Task<Country?> GetCountryByName(string countryName)
        {
            throw new NotImplementedException();
        }
    }
}
