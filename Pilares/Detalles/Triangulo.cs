using System;

    public class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public override double CalcularArea()
        {
            return Base * Altura / 2;
        }
    }
    