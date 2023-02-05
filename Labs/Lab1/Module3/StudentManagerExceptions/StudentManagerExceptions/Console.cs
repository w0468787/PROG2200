using System;
using System.Collections.Generic;
using System.Text;

namespace Util
{
    class MyCustomException : FormatException {
        public MyCustomException() { }

        public MyCustomException(string message){
            System.Console.WriteLine("You didnt enter a number ("+message+")");
        }
    }
    class Console
    {
        static public string Ask(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                throw new MyCustomException(question);
            }
        }
    }
}