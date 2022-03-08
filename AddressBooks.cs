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
    }
}
