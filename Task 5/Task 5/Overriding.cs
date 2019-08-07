using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Overridingbase
    {
        public void show()
        {
            Console.WriteLine("Base class");
        }
    }
    class Overridingderived : Overridingbase
    {
        new public void show()
        {
            Console.WriteLine("Derived class");
        }
    }
}
