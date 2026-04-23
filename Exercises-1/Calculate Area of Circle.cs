using System;
namespace caculateareaofcircle
{
    class AreaOfCircleProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dien tich hinh tron");
            Console.Write("Nhap ban kinh: ");
            double r = double.Parse(Console.ReadLine());
            double PI = Math.PI;
            double area = PI * r * r;
            Console.WriteLine("Dien tich hinh tron la: " + area);
        }
    }
}
