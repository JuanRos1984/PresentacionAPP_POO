using System;
namespace Pilares
{
    public class Usuario
    {
        private string nombre;
        private int edad;

        //Mostrar que no a todos los atributos hay que hacerles getter y setter
        //Mostrar uso de this


        public string Getnombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            if(nombre == null || nombre == "")
                nombre = "John Doe";
            this.nombre = nombre;
        }

        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }
}