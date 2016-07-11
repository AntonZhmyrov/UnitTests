using System;
using System.Collections.Generic;
using UnitTests.Models;

namespace UnitTests.Controllers
{
    public class UserEvaluator
    {
        public List<User> Users;

        public UserEvaluator()
        {
            Users = new List<User>();

            Users.Add(new User { Name = "Anton", Password = "12345" } );
            Users.Add(new User { Name = "Danyl", Password = "54321" } );
            Users.Add(new User { Name = "Lilya", Password = "myPassword" } );
            Users.Add(new User { Name = "Andrey", Password = "$ZAAd7" } );
        }

        public bool Exists(string userName, string userPassword)
        {
            var exists = false;

            foreach (var user in Users)
            {
                if (user.Name == userName && user.Password == userPassword)
                {
                    exists = true;
                }
            }

            return exists;
        }
    }
}
