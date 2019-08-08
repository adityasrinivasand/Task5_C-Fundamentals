using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class ExceptionalHandling
    {
        public void division()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("This linein not executed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            Console.WriteLine($"Result is {div}");
        }
    }
}
