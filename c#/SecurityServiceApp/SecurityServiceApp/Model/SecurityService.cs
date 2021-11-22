using System;
using System.Collections.Generic;

namespace SecurityServiceApp.Model
{
    class SecurityService
    {
        readonly Dictionary<string, User> credentials = new Dictionary<string, User>();
        public SecurityService()
        {
            Initializtion();
        }
        public void Initializtion()
        {
            AddUser(101, "sohan", "sarode", "sohansarode916@gmail.com", "nablo123");
            AddUser(102, "kunal", "sarode", "kunalsarode@gmail.com", "kunu1");
            AddUser(103, "ojas", "jawale", "binarycipher@gmail.com", "sonu@123");
            AddUser(104, "nablo", "sarode", "nabloescobar@hotmail.com", "sonu");
            AddUser(105, "ash", "pawar", "ojasjawale@yahoo.com", "ashwini@1");
        }
        public void AddUser(int id,string fname,string lname,string loginId,string password)
        {
            User users = new User(id,fname,lname,loginId,password);
            credentials.Add("k"+users.Id.ToString(),users);
        }

        public void Login(string id, string password)
        {
            foreach (var item in credentials)
            {
                User user = item.Value;
                if (credentials.ContainsKey(id) && user.Password == password)              
                {                  
                    PrintDetails(id,item.Value);
                    return;
                }               
            }
            throw new InvalidUserException(id);
        }

        public void PrintDetails(string id, User value)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Login Successful...");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("User Key\t:\t {0}\nFirst Name\t:\t {1}\nLast Name\t:\t" +
                " {2}\nEmail\t\t:\t {3}\nPassword\t:\t {4}", 
                id, value.FName, value.LName,
                value.Email, value.Password);
            Console.WriteLine("-----------------------------------------------------");
        }     
    }
}
