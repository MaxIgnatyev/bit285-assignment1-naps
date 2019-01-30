using System;
using System.Collections.Generic;

namespace bit285assignment1naps.Models
{
    public class Repository
    {
        List<User> users = new List<User>();

        public IEnumerable<User> Users
        {
            get
            {
                return users;
            }
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}
