﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Inheritance
    {

         protected int length;
         public void setside(int a)
         {
            length = a;
         }    
    }
    class Square : Inheritance
    {
        public int getArea()
        {
            return (length * length);
        }
    }

}