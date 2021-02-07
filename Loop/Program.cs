using System;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int i = 0;

            //while (i < x)
            //{
            //    int a = 0;
            //    while (a < x)
            //    {
            //        Console.Write("*");
            //        a++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}

            for (int i = 0; i < 3; i++);
            {
                for (int j = 0; j < i; j++);
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
