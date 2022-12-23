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
        public static void EditContact()
        {
            Console.WriteLine("Enter the First Name: ");
            string name = Console.ReadLine();
            foreach (var data in person)
            {
                if (person.Contains(data))
                {
                    if (data.fname == name)
                    {
                        Console.WriteLine("To edit contacts enter 1.First Name\n 2.Last Name\n 3.Address\n 4.City\n 5.State\n 6.Zipcode\n 7.PhoneNumber\n");
                        int option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 1:
                                string fname = Console.ReadLine();
                                data.fname = fname;
                                break;

                            case 2:
                                string lname = Console.ReadLine();
                                data.lname = lname;
                                break;

                            case 3:
                                string address = Console.ReadLine();
                                data.address = address;
                                break;

                            case 4:
                                string city = Console.ReadLine();
                                data.city = city;
                                break;

                            case 5:
                                string state = Console.ReadLine();
                                data.state = state;
                                break;

                            case 6:
                                int zipcode = Convert.ToInt32(Console.ReadLine());
                                data.zipcode = zipcode;
                                break;

                            case 7:
                                int phoneNumber = Convert.ToInt32(Console.ReadLine());
                                data.phoneno = phoneNumber;
                                break;

                            default:
                                Console.WriteLine("Choose valid option");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Name doesnot match");
                    }
                }
            }
        }
    }
}
