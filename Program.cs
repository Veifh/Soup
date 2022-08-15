using System;

namespace Progect
{
     class Program
    {
        public static void Main(string[] args)
        {
            int a = 1;
            int b = 3;
            int c = 4;  
            Console.WriteLine(Convert.ToString(Math(a,b,c)));
        }

        public static int Math(int a, int b, int c) 
        {
            return a + b - c;
        }
    }
}
