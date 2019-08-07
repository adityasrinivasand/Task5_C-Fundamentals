using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Conditional
    {
        int a = 5;
        int b = 7;
        int c = 9;

        int max = 0, min = 0; 
        
        public void ifandnested()
        {
            if( a > b)
            {
                max = a;
                min = b;
                if(a > c)
                {
                    max = a;
                    if(b > c)
                    {
                        min = c;
                    }else if(c > b)
                    {
                        min = b;
                    }
                }else if( c > a)
                {
                    max = c;
                }
            } 
            else if( b > a)
            {
                max = b;
                min = a;
                if (b > c)
                {
                    max = b;
                    if (a > c)
                    {
                        min = c;
                    }
                    else if (c > a)
                    {
                        min = a;
                    }
                }else if( c > b)
                {
                    max = c;
                }
            }
            Console.WriteLine($"The maximum of three numbers is {max}");
            Console.WriteLine($"The minimum of three numbers is {min}");
        }

        public void switchcase()
        {
            int number = 3;
            switch (number)
            {
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                default:
                    Console.WriteLine("None matches");
                    break;
            }
        }

    }
}
