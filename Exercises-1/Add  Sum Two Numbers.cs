using System;
namespace Sumtwonumber
{
    class SumProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So thu nhat:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("So thu hai:");
            int b = int.Parse(Console.ReadLine());
            int result = a + b;
            Console.WriteLine("Tong cua " + a + " va " + b + " la: " + result);
        }
    }
}