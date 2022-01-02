using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactStoreKernal.Domains
{
    public class Contact
    {
        public string FullName { get; set; }
        public long PhoneNo { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string Category { get; set; }
        public string User { get; set; }
    }
}
