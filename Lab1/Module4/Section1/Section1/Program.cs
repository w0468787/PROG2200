using System;

namespace Section1
{
    // ---------------- Modification # 1 -----------------------------------
    enum monthCategory
    {
        // Using = 0 then 1 then 2
        
        January = 1,
        February = 2,
        March   = 3,
        April = 4,
        May = 5,
        June=6,
        July=7,
        August=8,
        September=9,
        October=10,
        November=11,
        December=12

        
        // Without Using = 0 then =1 then =2
       /* January,
        February,
        March,
        April,
        May
       */
        // Continue the remaining months

    }
    class Data
    {
        public int Date;
        public int Age;
        public string month;
        public string name;
    }
    // ---------------- Modification # 1 -----------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Data();
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born in?");

            /* ---------------- Modification # 3 ----------------------------------- */
            //var month = TryAnswer();
            Console.WriteLine("January : 0\nFebruary : 1\nMarch : 2\nApril : 3\nMay : 4");
            var month = int.Parse(TryAnswer()); // Integer casting (Parsing)
            monthCategory monthName = (monthCategory)month;


            /* ---------------- Modification # 3 ----------------------------------- */



            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your birth month is: {0}", month);

            /* ---------------- Modification # 4 ----------------------------------- */
            switch (month)
            {
                case 1:
                    if (user.Date > 0 && user.Date <= 20)
                    {
                        Console.WriteLine("You are an Capricorn");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 20 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Aquarius");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }

                case 2:
                    if (user.Date > 0 && user.Date <= 18)
                    {
                        Console.WriteLine("You are an Aquarius");
                        break;
                    }
                    else if (user.Date > 0 && user.Date >= 19 && user.Date <= 28)
                    {
                        Console.WriteLine("You are an Pisces");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 5:
                    if (user.Date > 0 && user.Date <= 20)
                    {
                        Console.WriteLine("You are an Taurus");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 20 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Gemini");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 6:
                    if (user.Date > 0 && user.Date <= 20)
                    {
                        Console.WriteLine("You are an Gemini");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 20 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Cancer");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 7:
                    if (user.Date > 0 && user.Date <= 22)
                    {
                        Console.WriteLine("You are an Cancer");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 22 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Leo");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 8:
                    if (user.Date > 0 && user.Date <= 22)
                    {
                        Console.WriteLine("You are an Leo");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 22 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Virgo");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 10:
                    if (user.Date > 0 && user.Date <= 22)
                    {
                        Console.WriteLine("You are an Libra");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 22 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Scorpio");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 9:
                    if (user.Date > 0 && user.Date <= 22)
                    {
                        Console.WriteLine("You are an Virgo");
                        break;
                    }
                    else if (user.Date > 0 && user.Date >= 23 && user.Date <= 30)
                    {
                        Console.WriteLine("You are an Libra");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 11:
                    if (user.Date > 0 && user.Date <= 21)
                    {
                        Console.WriteLine("You are an Scorpio");
                        break;
                    }
                    else if (user.Date > 0 && user.Date >= 22 && user.Date <= 30)
                    {
                        Console.WriteLine("You are an Sagittarius");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 12:
                    if (user.Date > 0 && user.Date <= 20)
                    {
                        Console.WriteLine("You are an Sagittarius");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 20 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Capricorn");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 3:
                    if (user.Date > 0 && user.Date <= 20)
                    {
                        Console.WriteLine("You are an Pices");
                        break;
                    }
                    else if (user.Date > 0 && user.Date > 20 && user.Date <= 31)
                    {
                        Console.WriteLine("You are an Aries");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                case 4:
                    if (user.Date > 0 && user.Date <= 19)
                    {
                        Console.WriteLine("You are an Aries");
                        break;
                    }
                    else if (user.Date > 0 && user.Date >= 20 && user.Date <= 30)
                    {
                        Console.WriteLine("You are an Taurus");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Date out of range ");
                        break;
                    }
                default:
                    Console.WriteLine("");
                    break;
            
        } // end of switch statement

            /* ---------------- Modification # 4 ----------------------------------- */


            // ---------------- Modification # 2 -----------------------------------
            //if (month == "march")
            //{
            //    Console.WriteLine("you are an Aries.");
            //}
            //else if (month == "april")
            //{
            //    Console.WriteLine("you are a Taurus.");
            //}
            //else if (month == "may")
            //{
            //    Console.WriteLine("you are a Gemini.");
            //}
            // ---------------- Modification # 2 -----------------------------------
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question; // It is a string datatype value
        }
    }
}
