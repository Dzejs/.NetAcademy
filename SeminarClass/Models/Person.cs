namespace SeminarClass.Models
{
    public abstract class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string AddressId { get; set; }

        public Person(string name, DateTime birthDay, string email, Address address)
        {
            Name = name;
            BirthDay = birthDay;
            Email = email;
            Address = address;
        }
    }
}
