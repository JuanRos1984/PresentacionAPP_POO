using System;
namespace Pilares
{
    public class Usuario
    {
        private string nombre;
        private DateTime fechaNacimiento;


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

        public string GetFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void SetFechaNacimiento(DateTime fecha)
        {
            fechaNacimiento = fecha;
        }

        public int MostrarEdad()
        {
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Year - fechaNacimiento.Year;
        }   
    }
}