using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class NewContacts
    {
        public static List<Contacts> person = new List<Contacts>();
        public static void CreateContacts()
        {
            Contacts contacts = new Contacts();

            Console.WriteLine("Enter First Name: ");
            contacts.fname = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            contacts.lname = Console.ReadLine();

            Console.WriteLine("Enter address: ");
            contacts.address = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            contacts.city = Console.ReadLine();

            Console.WriteLine("Enter State: ");
            contacts.state = Console.ReadLine();

            Console.WriteLine("Enter Zipcode: ");
            contacts.zipcode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Phone Number: ");
            contacts.phoneno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter E-mail: ");
            contacts.email = Console.ReadLine();
            
        }
    }
}
