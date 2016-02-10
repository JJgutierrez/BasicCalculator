using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class OptionsScreen
    {
        public void Options()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*************************************"
                           +"\n*************************************"
                           +"\n******** 1 - Addition        ********"
                           +"\n******** 2 - subtraction     ********"
                           +"\n******** 3 - Multiplication  ********"
                           +"\n******** 4 - Divison         ********"
                           +"\n******** 5 - Exponential     ********"
                           +"\n******** 6 - Matrix          ********"
                           +"\n******** 7 - Linear Equation ********"
                           +"\n*************************************"
                           +"\n*************************************\n");
        }

        public void  Calculating()
        {
            Console.WriteLine("Calculatin ...............");
        }

        


    }
}
