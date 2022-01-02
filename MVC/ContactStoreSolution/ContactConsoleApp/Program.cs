using System;
using System.Linq;
using ContactStoreKernal;
using ContactStoreKernal.Domains;
namespace ContactConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ContactDbContext();

            var user1 = new User { UserName = "kunal", Password = "kunal" };
            var contact1 = new Contact
            {
                FullName = "sohan sarode",
                DOB = new DateTime(2000, 11, 24),
                Category = "Family",
                Address = "Bhusawal",
                PhoneNo = 9284948669,
                User = "kunal"
            };

            user1.Contacts.Add(contact1);
            db.Users.Add(user1);
            PrintContact(db);
            Console.ReadKey();
        }

        public static void PrintContact(ContactDbContext dbContext)
        {
            var contactsOfUser = dbContext.Users;
            contactsOfUser.ToList().ForEach(user => Console.WriteLine("{0}\t{1}\t{1}\t{1}\t{1}\t{1}\t{1}",
                user.UserName, user.Password, user.Contacts));
        }
    }
}
