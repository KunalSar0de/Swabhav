using ContactStoreKernal.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactStoreKernal
{
    public class ContactDbContext:DbContext
    {
        public ContactDbContext()
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactCategory> Categories { get; set; }
        public DbSet<ContactAddress> Address { get; set; }
        public DbSet<Tanent> Tanents { get; set; }
    }
}
