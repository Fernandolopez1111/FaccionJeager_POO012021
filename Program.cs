using System;

namespace gitlab
{
   internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0,b =0 ; 
            Console.WriteLine("enter a value for a");
            a = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("enter a value for b");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"adding {a} + {b} equals  {addNumbers(a,b)}");

        }
        public static int addNumbers(int a,int b)
        {
            return a + b;
        }
    }
}
