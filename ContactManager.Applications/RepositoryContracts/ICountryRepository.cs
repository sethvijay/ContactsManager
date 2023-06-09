﻿using ContactManager.Core.Domain.Entities;

namespace ContactManager.Applications.RepositoryContracts
{
    /// <summary>
    /// Represents data access logic for managing Country entity
    /// </summary>
    public interface ICountryRepository
    {
        /// <summary>
        /// Adds a new country object to the data store
        /// </summary>
        /// <param name="country">Country object to add</param>
        /// <returns>Returns country object after adding it to the data store</returns>
        Task<Country> AddCountry(Country country);

        /// <summary>
        /// Returns all countries in the data store
        /// </summary>
        /// <returns>All countries from the table</returns>
        Task<List<Country>> GetAllCountries();

        /// <summary>
        /// Returns a country object based on the given country id otherwise it returns null
        /// </summary>
        /// <param name="countryID">countryID to search</param>
        /// <returns>Matching country or null</returns>
        Task<Country?> GetCountryById(Guid countryID);

        /// <summary>
        /// Returns a country object based on the given country name
        /// </summary>
        /// <param name="countryName">Country name to search</param>
        /// <returns>Matching country or null</returns>
        Task<Country?> GetCountryByName(string countryName);
    }
}
