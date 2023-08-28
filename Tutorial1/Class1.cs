using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
   class Person
    {
        public string FirstName;
        public string LastName;
        public byte Age;
        public static string teststatic = "Test1";
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
} 