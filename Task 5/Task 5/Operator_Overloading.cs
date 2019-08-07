using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Operator
    {
        private double maths;   
        private double science;  

        public double Gettotalmarks()
        {
            return maths + science;
        }
        public void Setmaths(double mat)
        {
            maths = mat;
        }
        public void Setscience(double sci)
        {
            science = sci;
        }

        // Overload + operator to add two Box objects.
        public static Operator operator +(Operator b, Operator c)
        {
            Operator op = new Operator();
            op.maths = b.maths + c.maths;
            op.science = b.science + c.science;
            return op;
        }
    }
}
