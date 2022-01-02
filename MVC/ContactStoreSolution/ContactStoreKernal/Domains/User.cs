using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactStoreKernal.Domains
{
    public class User
    {
        public User()
        {
            Contacts = new List<Contact>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Tenant { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
