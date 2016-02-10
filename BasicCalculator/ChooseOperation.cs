using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class ChooseOperation
    {
        public void Operators(int option, ref int val1,ref int val2 )
        {
            MathOperations mt = new MathOperations();
            switch(option)
            {

                case 1:
                    {
                        Console.WriteLine("The {0} is ... {1}",Operations.Addition,  mt.Addition(ref val1, ref val2));
                    }
                break;
                case 2:
                    {
                        Console.WriteLine("The {0} is ... {1}",Operations.Subtraction, mt.Subtraction(ref val1, ref val2));
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("The {0} is ... {1}",Operations.Multiplication, mt.Multiplication(ref val1, ref val2));
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("The {0} is ... {1}",Operations.Division, mt.Division(ref val1, ref val2));
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("the {0}  is ...{1}", Operations.Exponentation, mt.Exponentation(ref val1, ref val2));
                    }
                    break;
                case 6:
                    {
                        Console.Clear();
                        Console.WriteLine(".....");
                        Matrix mx = new Matrix();
                        mx.MainMatrix();
                    }
                    break;
                case 7:
                    {
                        LinearEquation le = new LinearEquation();
                        le.EquationSolver();
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }

        }

    }
}
