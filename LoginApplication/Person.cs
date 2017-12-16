using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    public class Person
    {
        public string username;
        public string password;

        public Person(string name, string pass)
        {
            username = name;
            password = pass;
        }
    }
}
