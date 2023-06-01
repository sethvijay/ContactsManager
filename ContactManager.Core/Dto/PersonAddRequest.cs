using ContactManager.Core.Domain.Entities;
using ContactManager.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Core.Dto
{
    public class PersonAddRequest
    {
        [Required(ErrorMessage = "Person name can't be blank")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Email should be a valid email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        public GenderOptions? Gender { get; set; }
        [Required(ErrorMessage = "Please select a country")]
        public Guid? CountryId { get; set; }
        [Required(ErrorMessage = "Address can't be blank")]
        public string? Address { get; set; }
        public bool RecieveNewsLetter { get; set; }

        /// <summary>
        /// Converts the current object of PersonAddRequest into a new object of Person type
        /// </summary>
        /// <returns></returns>
        public Person ToPerson()
        {
            return new Person() { Name = Name, Email = Email, DateOfBirth = DateOfBirth, Gender = Gender.ToString(), CountryId = CountryId, Address = Address, RecieveNewsLetter= RecieveNewsLetter };
        }
    }
}
