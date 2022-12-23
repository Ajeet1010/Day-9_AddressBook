using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Program
    {
            public static List<Contacts> Person = new List<Contacts>();
            public static void Main(string[] args)
            {
                AddressBook.NewContacts.CreateContacts();

            }
    }
}
