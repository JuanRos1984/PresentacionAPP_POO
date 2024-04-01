using System;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
                Usuario user = new Usuario
                {
                    nombre = "Ana",
                    fechaNacimiento = DateTime.Parse("2010-01-31")
                };

            System.Console.WriteLine(user.MostrarEdad());

        }
    }
}
