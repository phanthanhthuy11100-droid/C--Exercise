using System;
namespace findthesizeofdatatypes {
    class SizeOfProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
            Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
            Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
            Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
            Console.WriteLine("Size of bool: " + sizeof(bool) + " bytes");
        }
    }
}