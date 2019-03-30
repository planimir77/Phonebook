using Phonebook.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phonebook.Data
{
    public class DataAccess
    {
        static DataAccess()
        {
            
            Contacts = new List<Contact>();
            Contacts.OrderBy(x => x.Name).ToList();
        }

        public static List<Contact> Contacts { get; set; }
    }
}
