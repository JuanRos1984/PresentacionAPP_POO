using System;

public class EjemploMetodoVirtual
{
    public void MetodoConcreto()
    {
        System.Console.WriteLine("Este es un metodo concreto");
    }
    public virtual void MetodoVirtual()
    {
        System.Console.WriteLine("Este es un metodo virtual");
    }
}