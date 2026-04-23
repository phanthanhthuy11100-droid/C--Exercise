using System;
namespace convertcelsiustofahrenheitandviceversa
{
    class ConvertcProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuyen doi do C sang do F va nguoc lai");
            Console.Write("Nhap do C: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do F tuong ung la: " + (c * 9 / 5 + 32));
            Console.Write("Nhap do F: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Do C tuong ung la: " + ((f - 32) * 5 / 9));
        }
    }
}