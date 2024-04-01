using System;
using System.Runtime.InteropServices;

namespace SumadoraEstructurada
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2= 0;

            Console.Write("Inserte el 1er valor: ");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inserte el 2do valor: ");

            num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine(num1+num2);
        }
    }
}
