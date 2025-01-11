using System;

namespace ContactApp
{
    public class Contact
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nName: {FirstName} {LastName}\nEmail: {Email}\nPhone: {PhoneNumber}\nAddress: {Address}, {City}, {ZipCode}";
        }
    }
}
