using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBooks
    {
        public Dictionary<string ,Contacts> contacts = new Dictionary<string, Contacts>();
        public string name;
        public void CreateContact()
        {
            Contacts contact = new Contacts();
            contact.GetInfo();
            contacts.Add(contact.fName+ " " +contact.lName, contact);

        }
        public void EditInfo()
        {
            Console.WriteLine("Enter name of contact:");
            String name = Console.ReadLine();

            if (contacts.ContainsKey(name))
            {
                contacts[name].GetInfo();
            }
            else
                Console.WriteLine("Contact doesnt exists");
        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter name of contact to delete:");
            String name = Console.ReadLine();

            if (contacts.ContainsKey(name))
            {
                contacts.Remove(name);
            }
            else
                Console.WriteLine("Contact doesnt exists");
        }

        public void AddMultipleContacts()
        {
            int numberOfContacts;
           Console.Write("Enter no of Contacts to add: ");
            numberOfContacts = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfContacts; i++)
                CreateContact();
        }
    }
}
