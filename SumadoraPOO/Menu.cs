using System;

namespace SumadoraPOO
{
    public class Menu
    {
        public static void Desplegar()
        {
            int num1 = 0; 
            int num2 = 0;
            Console.Write("Inserte el 1er valor: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserte el 2do valor: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Operaciones objetoOPeraciones = new Operaciones();
            Console.WriteLine(objetoOPeraciones.Calcular(num1,num2));
        }
    }
}
