using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Base
    {
        public string name;
        public string subject;
        public void readers(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
            Console.WriteLine("Myself: " + name);
            Console.WriteLine("My Favorite Subject is: " + subject);
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
