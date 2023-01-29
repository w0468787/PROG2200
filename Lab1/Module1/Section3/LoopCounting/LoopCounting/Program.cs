using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int m = 10;
            while (x <= 5)
            {

                for (int i = 1; i <= 10; i++)
                {
                    if (x % 2 == 0)
                    {
                        m -= y;
                        Console.WriteLine(m);
                    }
                    else { 
                    Console.WriteLine(i);
                    }
                   
                }
                x++;
                m = 10;
            }
        }
    }
}
