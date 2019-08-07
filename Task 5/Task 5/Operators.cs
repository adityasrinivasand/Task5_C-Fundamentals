using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Operators
    {
        int a = 5;
        int b = 7;

        public void arithmetic()
        {
            Console.WriteLine($"Addition of A & B is : {a + b}");
            Console.WriteLine($"Subtraction of A & B is : {a - b}");
            Console.WriteLine($"Multiplication of A & B is : {a * b}");
            Console.WriteLine($"Division of A & B is : {a / b}");
            Console.WriteLine($"Modulo Operator: {a % b}");
        }

        public void relational()
        {

            if (a > b)
            {
                Console.WriteLine("A is greater than B  " );
            }
            if (a < b)
            {
                Console.WriteLine("B is greater than A  ");
            }
            if (a == b)
            {
                Console.WriteLine("A is Equal to B   ");
            }
        }

        public void logical()
        {
            bool a = true, b = false;
            Console.WriteLine($"AND Operator: { a && b} " );
            Console.WriteLine($"OR Operator: { a || b} ");
            Console.WriteLine($"NOT Operator for a: {!a} ");
        }
    }
}
