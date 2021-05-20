using System;

namespace Z_Ejercicio_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesarTexto procesadorTexto = new ProcesarTexto();
            Console.WriteLine("Ingrese el texto: ");
            string texto = Console.ReadLine();
            string resultado = procesadorTexto.teclas(texto);
            Console.WriteLine("La secuencia resultantes es: "+resultado);
        }
    }
}
