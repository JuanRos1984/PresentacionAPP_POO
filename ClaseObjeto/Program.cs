﻿using System;

namespace ClaseObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Clase objeto1 = new Clase();
            Clase objeto2 = new Clase();
            Clase objeto3 = new Clase();

            Persona persona1 = new Persona();
            persona1.nombre = "Maria";
            persona1.edad = 28;

            Persona persona2 = new Persona
            {
                nombre = "Ramon",
                edad = 13
            };
            
            persona1.Saludar();
            persona2.Saludar();

        }
    }
}
