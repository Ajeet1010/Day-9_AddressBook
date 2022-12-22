using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Detail
    {
        public void PersonDetails()
        {
            Console.Write("Enter First Name: ");
            string fname = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lname = Console.ReadLine();

            Console.Write("Enter Address : ");
            string address = Console.ReadLine();

            Console.Write("Enter City : ");
            string city = Console.ReadLine();

            Console.Write("Enter State : ");
            string state = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            string zipcode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneno = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            string email = Console.ReadLine();

            //Adding  details to list
            List<string> Contacts = new List<string>();
            Contacts.Add(fname);
            Contacts.Add(lname);
            Contacts.Add(address);
            Contacts.Add(city);
            Contacts.Add(state);
            Contacts.Add(email);
            Contacts.Add(zipcode);
            Contacts.Add(phoneno);

            foreach (string i in Contacts)
                Console.WriteLine(i);

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Address Book");
                Contacts contacts = new Contacts();

            }
        }
    }
}
