using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class ImplicitConversion
    {
        int i = 12;
        double d = 765.12;
        float f = 56.123F;

        // Using Built- In Type Conversion 
        // Methods & Displaying Result 
        public void displayic()
        {
            Console.WriteLine(Convert.ToString(f));
            Console.WriteLine(Convert.ToInt32(d));
            Console.WriteLine(Convert.ToUInt32(f));
            Console.WriteLine(Convert.ToDouble(i));
        }          
    }
    public class ExplicitConversion
    {
        int x = 21;
        int y = 5;

        
        public void display()
        {
            double b = (double)x / y;
            Console.WriteLine(b);
        }
    }
}
