using System;
namespace PrintASCIIvalue {
    class ASCIIProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot ky tu: ");
            char c = Console.ReadKey().KeyChar;
            int asciiValue = (int)c;
            Console.WriteLine("Ma ASCII cua ky tu la: " + asciiValue);
        }
    }
}
