using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo
{
    class Person
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }
        ~Person()
        {
            name = String.Empty;
        }

        public string Name { get { return name; } }

        public override string ToString()
        {
            if(name == String.Empty)
                throw new ArgumentNullException(); 
            return name;
        }
    }
}
