using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LinqPractice
{
    class Program
    {
        public static void GenericCollections()
        {
            string[] user1 = new string[] { "Gaurav", "22", "gj@email.com", "2424" };
            string[] user2 = new string[] { "xyz", "22", "xyz@email.com", "2424" };
            string[] user3 = new string[] { "abc", "22", "abc@email.com", "2424" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]>();
            dict.Add(1, user1);
            dict.Add(2, user2);
            dict.Add(3, user3);
            foreach (var value in dict)
            {
                string[] userInfo = value.Value;
                foreach (var user in userInfo)
                {
                    Console.WriteLine(user);
                }

            }
        }
        public static void CustomUsers()
        {
            //List<User> users = new List<User>();
            //users.Add(new User {UserId= 1 , Name = "Gaurav" , Age = 22 , Email = "xyz@email.com" , Phone = 9898989898});
            //users.Add(new User { UserId = 1, Name = "sam", Age = 30, Email = "sam@email.com", Phone = 9898989898 });
            //users.Add(new User { UserId = 1, Name = "jacob", Age = 40, Email = "jacob@email.com", Phone = 9898989898 });

            List<User> users = new List<User>()
            {
            //    new User
            //    {
            //        UserId = 1,
            //        Name = "Gaurav",
            //        Age = 22,
            //        Email = "xyz@email.com",
            //        Phone = 9898989898,
            //        Addresses = new User.Address
            //        {
            //            Street = "123"  , Country = "Germany" , FlatName = "27/703" 
            //        }
            //    },
            //    new User
            //    {
            //        UserId = 2,
            //        Name = "Sam",
            //        Age = 40,
            //        Email = "sam@email.com",
            //        Phone = 9898989898,
            //        Addresses = new User.Address
            //        {
            //            Street = "456"  , Country = "India" , FlatName = "28/703"
            //        }
            //    },
                new User
                {
                    UserId = 3,
                    Name = "jacob",
                    Age = 42,
                    Email = "jacbob@email.com",
                    Phone = 9898989898,
                    Addresses = new List<User.Address>(){ 
                        new User.Address 
                    {
                        Street = "567"  , Country = "India" , FlatName = "29/703"
                    }
                    }
                }
            };

            foreach(var user in users)
            {
                Console.WriteLine(String.Format("The user {0} with age {1} has email {2} and Phone {3} " , user.Name , user.Age , user.Email, user.Phone));
            }

            //var userList = from user in users 
            //               where user.Age == 40
            //               select  user;

            //var userList = users.Where(x=> x.Age >= 40).Select(x => x.Name);

            var userList = from user in users
                           where user.Age >= 40
                           select new {FirstName = user.Name , PhoneNumber = user.Phone ,
                           Address = user.Addresses};
            var ad = users.Where(x => x.Age == 40).SelectMany(x => x.Addresses);
            //Projection of and Object from one type to other using Projection
            // helpfull in transforming an object or column name of specflow in one type to another type
            foreach(var user in userList)
            {
                Console.WriteLine("User has name as {0} and Phone no as {1} and Flatname is {2} ", user.FirstName , user.PhoneNumber);
                //Console.WriteLine(user.Name);
                //Console.WriteLine(user.Age);
                //Console.WriteLine(user.Email);


            }

        }
        /// <summary>
        /// Custom Type Users
        /// </summary>
        public class User
        {
            public int UserId { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public string Email { get; set; }

            public Int64 Phone { get; set; }

            public List<Address> Addresses { get; set; }

            //public Address Addresses { get; set; }
            public class Address
            {
                public string FlatName { get; set; }
                public string Street { get; set; }

                public string Country { get; set; }
            }
            static void Main(string[] args)
            {
                CustomUsers();
                Console.ReadLine();
            }
        }
        
    }
}
