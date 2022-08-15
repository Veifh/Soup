using System;

namespace Progect
{
     class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            Console.WriteLine(Convert.ToString(Math(a,b)));
        }

        public static int Math(int a, int b) 
        {
            return a + b;
        }
    }
}
