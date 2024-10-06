using AndroidX.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
        {
        new Contact { ContactId = 1, Name = "John Doe", Email = "JohnDoe@gmail.com" },
        new Contact { ContactId = 2, Name = "Jane Doe", Email = "JaneDoe@yahoo.com" },
        new Contact { ContactId = 3, Name = "Tom Hanks", Email = "TomHanks@hollywood.com" },
        new Contact { ContactId = 4, Name = "Frank Liu", Email = "FrankLiu@gmail.com" },
        new Contact { ContactId = 5, Name = "Emily Clark", Email = "EmilyC@gmail.com" },
        new Contact { ContactId = 6, Name = "Michael Smith", Email = "MichaelS@outlook.com" },
        new Contact { ContactId = 7, Name = "Sophia Williams", Email = "SophiaW@yahoo.com" },
        new Contact { ContactId = 8, Name = "David Johnson", Email = "DavidJ@gmail.com" },
        new Contact { ContactId = 9, Name = "Linda Brown", Email = "LindaB@gmail.com" },
        new Contact { ContactId = 10, Name = "James White", Email = "JamesWhite@company.com" }
        };

        public static List<Contact> GetContacts() => _contacts;

        public static Contact GetContactById(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);

            if (contact != null)
                return new Contact
                {
                    ContactId = contactId,
                    Address = contact.Address,
                    Email = contact.Email,
                    Name = contact.Name,
                    Phone = contact.Phone

                };
            return null;
        }

        public static void UpdateContact(int contactId, Contact contact)
        {
            if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if (contactToUpdate != null)
            {
                //Automapper
                contactToUpdate.Address = contact.Address;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Name = contact.Name;
                contactToUpdate.Phone = contact.Phone;
            }
            
        }

        public static void AddContact(Contact contact) 
        {
            var maxId = _contacts.Max(x => x.ContactId);
            contact.ContactId = maxId + 1;
            _contacts.Add(contact);
        }

        public static void DeleteContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
            if(contact != null)
            {
                _contacts.Remove(contact);
            }
        }
    }
}
