using System;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodoVirtualTester tester = new MetodoVirtualTester();
            tester.MetodoVirtual();
            tester.MetodoConcreto();

        }
    }
}
