using ContactApp; // Import the namespace of your main project
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ContactAppTests
{
    [TestClass]
    public class ContactManagerTests
    {
        [TestMethod]
        public void AddContact_ShouldIncreaseContactCount()
        {
            // Arrange
            var manager = new ContactManager();
            var initialCount = manager.GetAllContacts().Count();

            var newContact = new Contact
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "1234567890",
                Address = "123 Main St",
                ZipCode = "12345",
                City = "Anytown"
            };

            // Act
            manager.AddContact(newContact);
            var finalCount = manager.GetAllContacts().Count();

            // Assert
            Assert.AreEqual(initialCount + 1, finalCount, "Contact count did not increase as expected.");
        }
    }
}
