using System;
using System.Collections.Generic;
using System.Text;

namespace JDI.Light.Core.Tests.Tests.Entities
{
    public class Client
    {
        public static Client DefaultClient = new Client("epam", "1234");
        public string Login, Password;

        public Client(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
