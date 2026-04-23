using System;
namespace convertdaystoyearsweeksanddays
{
    class ConvertdayProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so ngay: ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int remainingDays = days % 365;
            int weeks = remainingDays / 7;
            remainingDays = remainingDays % 7;
            Console.WriteLine(days + " ngay bang " + years + " nam, " + weeks + " tuan va " + remainingDays + " ngay.");
        }
    }
}