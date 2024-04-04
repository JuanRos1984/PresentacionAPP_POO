using System;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();
            user.SetEdad(15);
            System.Console.WriteLine(user.GetEdad());   
        }
    }
}
