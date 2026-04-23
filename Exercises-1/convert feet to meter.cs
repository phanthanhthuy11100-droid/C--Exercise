using System;
namespace Convertfeettometer {
    class ConvertProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chuyen doi feet sang meter");
            Console.Write("Nhap so feet: ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * 0.3048;
            Console.WriteLine("So met la: " + meter);
        }
    }
}