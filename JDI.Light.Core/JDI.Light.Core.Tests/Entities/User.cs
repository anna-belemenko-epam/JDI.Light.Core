using System;
using System.Collections.Generic;
using System.Text;
using JDI.Light.Core.Attributes;

namespace JDI.Light.Core.Tests.Entities
{
    public class User
    {
        public static User DefaultUser = new User("epam", "1234");

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        [Name("Login")]
        public string Login;

        [Name("Password")]
        public string Password { get; set; }
    }
}
