using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookCollection
    {
        public Dictionary<string, AddressBooks> addressbooks = new Dictionary<string, AddressBooks>();
        public void CreateAddressBook()
        {
            AddressBooks addressbook = new AddressBooks();
            Console.WriteLine("Enter name of Address Book: ");
            string name = Console.ReadLine();
            addressbook.name = name;
            addressbooks.Add(name, addressbook);

        }

        public void AddBook(AddressBooks obj)
        {
            addressbooks.Add(obj.name, obj);
        }

    }
}
