using ContactManager.Core.Domain.Entities;

namespace ContactManager.Applications.Dto
{
    /// <summary>
    /// DTO class for adding country
    /// </summary>
    public class CountryAddRequest
    {
        public string? CountryName { get; set; }

        public Country ToCountry()
        {
            return new Country() { CountryName = CountryName };
        }
    }
}
