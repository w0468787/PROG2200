using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            Console.WriteLine("What month were you born in?");
            var bMonth = Console.ReadLine();
            Console.WriteLine("What is your favorite colour");
            var colour = Console.ReadLine();
            Console.WriteLine("whats the weather like?");
            var weather = Console.ReadLine();
           

            Console.WriteLine("Your name is: "+name);
            Console.WriteLine("You are "+age+" years old");
            Console.WriteLine("You were born in: " + bMonth);
            Console.WriteLine("Your favorite colour is: " + colour);
            Console.WriteLine("The weather is "+weather);
            
            Console.ReadLine();

        }
    }
}
