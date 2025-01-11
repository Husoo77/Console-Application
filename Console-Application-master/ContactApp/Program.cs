using System;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var contactManager = new ContactManager();
            while (true)
            {
                Console.WriteLine("\nContact Manager");
                Console.WriteLine("1. List all contacts");
                Console.WriteLine("2. Add a new contact");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListContacts(contactManager);
                        break;
                    case "2":
                        AddContact(contactManager);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void ListContacts(ContactManager manager)
        {
            var contacts = manager.GetAllContacts();
            Console.WriteLine("\nContacts:");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
                Console.WriteLine(new string('-', 40));
            }
        }

        static void AddContact(ContactManager manager)
        {
            var contact = new Contact();
            Console.Write("First Name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Email: ");
            contact.Email = Console.ReadLine();
            Console.Write("Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Zip Code: ");
            contact.ZipCode = Console.ReadLine();
            Console.Write("City: ");
            contact.City = Console.ReadLine();

            manager.AddContact(contact);
            Console.WriteLine("Contact added successfully!");
        }
    }
}
