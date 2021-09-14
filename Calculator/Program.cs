using System;
using MathsLib;

namespace Calculator
{
    class Program
    {
        /// <summary>
        /// This method is the entry point of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Variables declaration
            int result;
            int op1;
            int op2;
            char oper;
            #endregion Variables declaration

            oper = AskUserForCharInput("Enter operator");

            while (oper != '#')
            {
                #region User inputs and variables initialization
                op1 = AskUserForIntegerInput("Enter first operand");
                op2 = AskUserForIntegerInput("Enter second operand");

                #endregion User input and variable initialization

                #region Perform calculations
                result = PerformCalculation(op1, oper, op2);
                #endregion Perform calculations

                #region Display result
                DisplayResult(op1, oper, op2, result);
                #endregion Display result

                oper = AskUserForCharInput("Enter operator");
            }
            End:
            DisplayMessage("You choose to leave...");
        }

        static private int PerformCalculation(int op1, char oper, int op2) {

            MathsBasicOperation mathsOperation = new MathsBasicOperation();

            switch (oper)
            {
                case ('+'):
                    return mathsOperation.Add(op1, op2);
                case ('-'):
                    return mathsOperation.Substract(op1, op2);
                case ('*'):
                    return mathsOperation.Multiply(op1, op2);
                case ('/'):
                    return mathsOperation.Divide(op1, op2);

                    //TODO manage exeption
                /*default:
                    DisplayMessage("Operator not supported");
                    goto End;
                */
            }
            // TODO
            return 0;
        }

        #region GUI
        static private char AskUserForCharInput(string question)
        {
            char userAnser;
            Console.WriteLine(question);
            userAnser = char.Parse(Console.ReadLine());
            return userAnser;
        }

        static private int AskUserForIntegerInput(string question)
        {
            int userAnser;
            Console.WriteLine(question);
            userAnser = int.Parse(Console.ReadLine());
            return userAnser;
        }

        static private void DisplayResult(int op1, char oper, int op2, int result)
        {
            Console.Clear();
            Console.WriteLine("The result of " + op1 + " " + oper + " " + op2 + " is : " + result);
        }

        static private void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        #endregion GUI
    }
}
