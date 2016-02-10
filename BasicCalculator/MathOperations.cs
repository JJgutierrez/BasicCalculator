using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
   
    enum Operations { Addition, Subtraction, Multiplication, Division, Exponentation}

    class MathOperations

    {
        
        public double Addition(ref int value1, ref int value2)
        {

            double add = value1 + value2;
            return add;

        }
        public double Subtraction(ref int value1, ref int value2)
        {
            double sub = value1 - value2;
            return sub;

        }
        public double Multiplication(ref int value1, ref int value2)
        {
            double mult = value1 * value2;
            return mult;
        }
        public double Division(ref int value1, ref int value2)
        {
            double div = value1 / value2;
            if (value1 == 0 || value2 == 0)
            {
                Console.WriteLine("Cannot divide by zero");
                Console.Read();

            }
            return div;
        }
        public double Exponentation(ref int value1, ref int value2)
        {
            double exp = Math.Pow(value1, value2);
            return exp;
        }
    
    }
}
