using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
    class Calculator
    {

        static void Main(string[] args)
        {
            Calculator app = new Calculator();
            bool playAgain = true;
            Console.WriteLine("\nPostfix Calculator. Recognizes these operators: + - * /");

            while (playAgain)
            {
                playAgain = app.DoCalculation();
            }
            Console.WriteLine("SEE YA.");
            /*int i;
            bool isVal = int.TryParse(Console.ReadLine(),out i);
            if (isVal)
            {
                Console.WriteLine(">>" + i + "\n");
            }*/
        }

        private bool DoCalculation()
        {
            Console.WriteLine("Please enter q to quit\n");
            string sInput = "2 2 +";
            Console.WriteLine(">");

            sInput = Console.ReadLine();

            if (sInput[0] == 'q' || sInput[0] == 'Q')
            {
                return false;
            }
            string sOutput = "4";
            /*since the next step involes a try catch block
             * envolving evaluatePostFixInput() method 
             * I am going to move on to making that methon
             * in my C# code*/

            /*
            bool isVal1 = int.TryParse(Console.ReadLine(), out input1);
            if (!isVal1)
            {
                return false;
            }
            */
            return true;
        }

        public string EvaluatePostFixInput(string input)
        {
            if (input == null || input == "")
            {

            }
            return "";
        }
    }
}
