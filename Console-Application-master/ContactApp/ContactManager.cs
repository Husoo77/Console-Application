using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace ContactApp
{
    public class ContactManager
    {
        private const string FilePath = "contacts.json";
        private readonly List<Contact> _contacts;

        public ContactManager()
        {
            _contacts = LoadContacts();
        }

        public void AddContact(Contact contact)
        {
            _contacts.Add(contact);
            SaveContacts();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }

        private void SaveContacts()
        {
            var json = JsonSerializer.Serialize(_contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        private List<Contact> LoadContacts()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }
            return new List<Contact>();
        }
    }
}
