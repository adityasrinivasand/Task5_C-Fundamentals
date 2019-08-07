using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Properties
    {
        private string name = "not known";
        private int age = 0;

        // Declare a Name property of type string:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Declare a Age property of type int:
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public override string ToString()
        {
            return " Name = " + Name + ", Age = " + Age;
        }
    }
}
