using System;

namespace PasscodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var secret = "secret";
            Console.WriteLine("Enter the secret code");
            var code = Console.ReadLine();
            if (code.Equals(secret))
            {
                Console.WriteLine("user authenticated do you want to change the password Y/N?");
                var choice = Console.ReadLine();
                if (choice.Equals("Y"))
                {
                    secret = Console.ReadLine();
                    Console.WriteLine("Password Changed to " + secret);
                }
                else { Console.WriteLine("OK"); }
            }
            else {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
