using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
            public static void Main(string[] args)
            {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Welcome to Address Book Program");
                Console.WriteLine("1) Creating contacts details\n" +
                    "2) Displaying the details of Contacts\n" +
                    "3) Edit details of contacts\n" +
                    "4) Delete details of contacts\n" +
                    "5) Adding multiple details\n" +
                  "Select Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        NewContacts.CreateContacts();
                        break;

                    case 2:
                        NewContacts.Display();
                        break;

                    case 3:
                        NewContacts.EditContact();
                        break;

                    case 4:
                        NewContacts.DeleteContact();
                        break;
                    case 5:
                        NewContacts.AddContact();
                        break;
                    default:
                        Console.WriteLine("Choose valid option");
                        break;
                }
            }

        }
    }
}
