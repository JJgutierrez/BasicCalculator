using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicCalculator
{
    class LinearEquation
    {
        public void EquationSolver()
        {
            Console.WriteLine("Enter number number and simbols to operate");
            string numberSymbol = Console.ReadLine();
            

            MSScriptControl.ScriptControl sc = new MSScriptControl.ScriptControl();
            sc.Language = "VBScript";
            string expression = numberSymbol;
            object result = sc.Eval(expression);
        
            Console.WriteLine(result);




        }
    }
}
