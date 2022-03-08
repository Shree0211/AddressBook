using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBooks
    {
        public List<Contacts> contacts = new List<Contacts>();

        public void CreateContact()
        {
            Contacts contact = new Contacts();
            contact.GetInfo();
            contacts.Add(contact);

        }
    }
}
