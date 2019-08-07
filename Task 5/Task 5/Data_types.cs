using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Data
    {      
            string stringvar = "Hello World!!";
            int intvar = 100;
            float floatvar = 10.2f;
            char charvar = 'A';
            bool boolvar = true;        

        public void disdata()
        {
            Console.WriteLine($"String Data Type:-  {stringvar}");
            Console.WriteLine($"Integer Data Type:-  {intvar}");
            Console.WriteLine($"Float Data Type:-  {floatvar}");
            Console.WriteLine($"Character Data Type:-  {charvar}");
            Console.WriteLine($"Boolen:-  {boolvar}");
        }

    }

}
