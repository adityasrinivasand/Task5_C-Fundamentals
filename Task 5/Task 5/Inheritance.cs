using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Inheritance
    {
         public int length;
         public void setside(int a)
         {
            length = a;
         }    
    }
    class Square : Inheritance
    {
        public int result = 0;
        public int getArea()
        {
            result = length * length;
            return (result);
        }
    }
    class Cube : Square
    {
        int volume;   
        public int getVolume()
        {
            volume = result * length;
            return volume;
        }
    }

}
