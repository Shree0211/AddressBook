using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
   public class Contacts
    {
        public string fName;
        public string lName;
        public string city;
        public string address;
        public string state;
        public string zip;
        public string phoneNo;
        public string email;
    
    public void GetInfo()
        {
            Console.Write("First name: ");
            fName = Console.ReadLine();
            Console.Write("Last Name: ");
            lName = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
            Console.Write("Phone: ");
            phoneNo = Console.ReadLine();
            Console.Write("City: ");
            city = Console.ReadLine();
            Console.Write("State: ");
            state = Console.ReadLine();
            Console.Write("Zip: ");
            zip = Console.ReadLine();   
            Console.Write("Address: ");
            address = Console.ReadLine();
        }

        
        
    }

    
}
