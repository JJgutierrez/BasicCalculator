using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class UserInput
    {
        public void UserNumbersChoices()
        {
            try
            {
                Console.Clear();
                OptionsScreen options = new OptionsScreen();
                options.Options();

                Console.WriteLine("Please enter your first number  ");
                int number1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please Enter the second number  ");
                int number2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Choose a number for the operation  ");
                int operation = Int32.Parse(Console.ReadLine());

                ChooseOperation operations = new ChooseOperation();
                operations.Operators(operation, ref number1, ref number2);

                Console.WriteLine("Would you like to try it again....");
                string yesOrNo = Console.ReadLine();

                while (yesOrNo == "yes" || yesOrNo == "y")
                {
                    UserNumbersChoices();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred:");
                Console.WriteLine("Lets try it again");
                Console.ReadLine();
                UserNumbersChoices();
            }

        } 
    }
}
