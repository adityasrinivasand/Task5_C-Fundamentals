using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class ErrorHandling
    {
        public void display()
        {
            Console.WriteLine("Input your name");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name can't be empty! Input your name once more");
                Console.WriteLine("Input your name");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
