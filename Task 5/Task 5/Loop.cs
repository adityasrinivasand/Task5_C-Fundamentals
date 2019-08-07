using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Loop
    {
        public void forloop()
        {
            for (int x = 1; x <= 4; x++)
            {
                Console.WriteLine($"For loop : {x}");
            }
            
        }
        public void whileloop()
        {
            int x = 1;
            while ( x <= 4)
            {
                Console.WriteLine($"While loop : {x}");
                x++;
            }

        }
        public void dowhileloop()
        {
            int x = 1;
            do
            {
                Console.WriteLine($"Do While loop : {x}");
                x++;
            } while (x <= 4);
        }


    }
}
