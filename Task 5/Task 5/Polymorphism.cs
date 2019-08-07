using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Polymorphism
    {
        public void print(int i)
        {
            Console.WriteLine($"Printing Int: {i}");
        }
        public void print(double f)
        {
            Console.WriteLine($"Printing Float: {f}");
        }
        public void print(string s)
        {
            Console.WriteLine($"Printing String: {s}");
        }
    }
}
