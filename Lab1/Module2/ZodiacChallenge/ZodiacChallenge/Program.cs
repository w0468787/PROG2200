using System;

namespace ZodiacChallenge
{
    class Data
    {
        public int Date;
        public int Age;
        public string month;
        public string name;
    }
    class ZodiacChallenge
    {
        static void Main(string[] args)
        {
            var user = new Data();
            Console.WriteLine("What is your name?");
            user.name = TryAnswer();

            Console.WriteLine("What is your age?");
            user.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born in?");
            user.month = TryAnswer();

            Console.WriteLine("Whats the date of your birth");
            user.Date = int.Parse(TryAnswer());

            Console.WriteLine("Your name is: {0}", user.name);
            Console.WriteLine("Your age is: {0}", user.Age);
            Console.WriteLine("Your birth month is: {0}", user.month);
            Console.WriteLine("Your birth date is: {0}", user.Date);

            switch (user.month)
            {
                case "january":
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

                case "february":
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
                case "may":
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
                case "june":
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
                case "july":
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
                case "august":
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
                case "october":
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
                case "september":
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
                case "november":
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
                case "december":
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
                case "march":
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
                case "april":
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
            }
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("You didn't type anything, please try again:");
                return Console.ReadLine();
            }
            return question;
        }
    }
}
