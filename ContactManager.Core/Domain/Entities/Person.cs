namespace ContactManager.Core.Domain.Entities
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public Guid? CountryId { get; set; }
        public string? Address { get; set; }
        public bool? RecieveNewsLetter { get; set; }
        public virtual Country? Country { get; set; }
        public override string ToString()
        {
            return $"Person Id :{PersonId}, Person Name :{Name}";
        }
    }
}
