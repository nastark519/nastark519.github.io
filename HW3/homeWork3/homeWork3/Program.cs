using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork3
{
    class Calculator
    {
        private IStackADT stack = new LinkedStack();

        /*Here note that we do not us a scanner C# has another
        way to go about this*/

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


            /*this is old code for testing purposes.
             * int i;
             * bool isVal = int.TryParse(Console.ReadLine(),out i);
             * if (isVal)
             * {
             * Console.WriteLine(">>" + i + "\n");
             * }
             */
        }

        private bool DoCalculation()
        {
            Console.WriteLine("Please enter q to quit\n");
            //sInput stands for string input.
            string sInput = "2 2 +";
            Console.WriteLine(">");

            sInput = Console.ReadLine();

            //check to see if user wants to quit.
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
            stack.Clear();

            string s;
            //you can do this in java see I am seeing if I can do it C#.
            double a, b, c;

            /* split the input into more workable peaces.
             * such as the set {"22","33","+"} 
             * but insted of a set its an array, which is even 
             * better! yay!
             */
            string[] st = input.Split(' ');

            foreach(string element in st)
            {
                if (double.TryParse(element, out a))
                {
                    stack.Push(Convert.ToDouble(element));
                }
                else
                {//must be an operator or some other char or word.
                    s = element;
                    if (s.Length > 1)
                    {
                        throw new ArgumentException("Input Error: " + s + " is not an allowed number or operator.");
                    }
                    if (stack.IsEmpty())
                    {
                        throw new ArgumentException("Improper input format. Stack be came empty when expecting second operand.");
                    }
                    b = (Convert.ToDouble(stack.Pop()));
                    if (stack.IsEmpty())
                    {
                        throw new ArgumentException("Improper input format. Stack became empty when expecting first operand.");
                    }
                    a = (Convert.ToDouble(stack.Pop()));
                    //c = DoOperation(a, b, s);
                }
            }


            return "";
        }

        public double DoOperation(double a, double b, string s)
        {

            return 0.0;
        }
    }

    //Note that C# VS asked me to prefix an I for my interface.
    //The stack inerface is done here.
    interface IStackADT
    {
        /*I see here that the comment style is differant than
         * Java.(i.e. I don't have /** comment.)*/

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

        /* Remove and return the top item on the stack. This operation should 
	     * result in an error if the stack is empty. Returns a reference of the 
	     * item removed.
         * @return THe reference that was popped from the stack or null
         *     if the stack was empty.
         */
        object Pop();

        /*
         * Return thetop item from the stack but does not remove it
         * If the stack is empty an error should be thrown or 
         * an acceptable alternative is returned which the user can
         * use to check is the stack is empty.
         * @return A reference to the item at the top of the stack
         *      or null if the stack is empty.
         */
        object Peek();

        /*Ask if the stack is empty. No error produced.
         * @return true if the stack is empty, false otherwise.
         */
        bool IsEmpty();

        /*Reset the stack by emptying it. The exact technique used to clear
         * the stack is up to the implementor. The user should pay attention to 
         * this behavior is.
         */
        void Clear();
    }
    // Now that the interface is done I need to move on to the 
    //LinkedStack that implements the IStackADT.

    class LinkedStack : IStackADT
    {
        private Node top;

        public LinkedStack()
        {
            top = null;
        }

        public void Clear()
        {
            top = null;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public object Peek()
        {
            if (IsEmpty())
            {
                return null;
            }
            return top.Data;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                return null;
            }
            object topItem = top.Data;
            top = top.Next;
            return topItem;
        }

        public object Push(object newItem)
        {
            if(newItem == null)
            {
                return null;
            }
            Node newNode = new Node(newItem, top);
            top = newNode;
            return newItem;
        }
    }

    /*This is the Node class.
     */
    class Node
    {
        public object data;
        public Node next;

        /*Defult constructor.
         * Sets up a empty Node. 
         */
        public Node()
        {
            data = null;
            next = null;
        }

        /*non-defult constructor.
         * Sets up a Node with data
         * and a next for the sake of pointing. 
         */
        public Node(object data, Node next)
        {//look up get; set; for C# (see next comment)
            this.data = data;
            this.next = next;
        }

        /* Here we are to setup a the accessors
         * for the fields.
         * For futher understanding I have found
         * this page for greater understanding.
         * stackoverflow.com/questions/6554210/what-is-the-purpose-of-accessors
         */

        /* Accessor for the data in the Node.
         * I need further explation here.
         */
        public object Data
        {
            get;//so this is a gamble banking on the v. of C# that we are using is 3.0 and up.
            set;//v. of C# that we are using is 3.0 and up. No errors are seen so I guess we are.
        }

        /* Accessor for the next Node.
         */
        public Node Next
        {
            get;
        }
    }

}
