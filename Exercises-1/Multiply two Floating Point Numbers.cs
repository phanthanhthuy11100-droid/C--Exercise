using System;
namespace Multiplytwofloatingpointnumbers
{
    class MultiplyProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thuc a:");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so thuc b:");
            float num2 = float.Parse(Console.ReadLine());
            float result = num1 * num2;
            Console.WriteLine("Tich cua " + num1 + " va " + num2 + " la: " + result);
        }
    }
}