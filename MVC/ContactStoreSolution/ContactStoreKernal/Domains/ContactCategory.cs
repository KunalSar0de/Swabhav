using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactStoreKernal.Domains
{
    public class ContactCategory
    {
        public ContactCategory()
        {
            Category = new List<Contact>();
        }

        public List<Contact> Category { get; set; }
    }
}
