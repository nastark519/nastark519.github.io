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
            {/*found answer here:
              * social.msdn.microsoft.com/Forums/vstudio/en-US/8e04e18f-398b-4000-bc4e-6a15c67db653/equivalent-of-illegalargumentexception-in-c?forum=csharpgeneral */

                throw new ArgumentException("Null or the empty string are not valid postfix expressions.");
            }
            //here I need to go back and see what we can use for the stack.

            return "";
        }
    }

    //Note that C# VS asked me to prefix an I for my interface.
    interface IStackADT
    {
        /*I see here that the comment style is differant than
         * Java.*/
        /* Push an Obj onto the top of the stack. Pushing an Obj
         * that does not exist throws an error and should not succeed.
         * Pushing an obj that is not an item should be an error
         * This operation should return a reference to the item
         * pushed so as that item should be able to be used.
         * @param newItem the obj to push onto the top of the
         * stack.
         * @return A reference to the obj that was pushed.
        */
        object Push(object newItem);

        /*
         */

    }

}
