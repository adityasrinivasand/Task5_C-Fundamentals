using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    
        public class CustomClass
        {
            public int Number { get; set; }

            public int Multiply(int num)
            {
                return num * Number;
            }

            public CustomClass()
            {
                Number = 0;
            }
        }
}
