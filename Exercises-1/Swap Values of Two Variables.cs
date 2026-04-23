using System;
namespace Swapvaluesoftwovariables
{
    class SwapProgram
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before swapping: a = " + a + ", b = " + b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping: a = " + a + ", b = " + b);
        }
    }
}