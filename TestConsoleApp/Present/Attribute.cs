using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Attributes
    {
        public class AuthorAttribute : Attribute
        {
            private string Name;
            public double Version;

            public AuthorAttribute(string name)
            {
                Name = name;
                Version = 1.0;
            }
        }

        [Author("Quynh")]
        public string UserName;
    }
}
