using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Static
    {
        static public int eng = 50;
        public int maths = 100;

        // Creating static method 
        // Using static keyword 
        public static void total()
        {
            Console.WriteLine($"Marks in English is: {eng}");
        }
        public void mathsmarks()
        {
            Console.WriteLine($"Marks in Maths is: {maths}");
        }
    }
}
