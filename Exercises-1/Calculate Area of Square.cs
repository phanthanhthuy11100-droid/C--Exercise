using System;
namespace caculateareaofsquare {
    class AreaOfSquareProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dien tich hinh vuong");
            Console.Write("Nhap do dai canh: ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine("Dien tich hinh vuong la: " + area);
        }
    }
}