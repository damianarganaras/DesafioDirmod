using System;

namespace Z_Ejercicio_Celular
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesarTexto hola = new ProcesarTexto();
            Console.WriteLine("Ingrese el texto: ");
            string texto = Console.ReadLine();
            string resultado = hola.teclas(texto);
            Console.WriteLine("La secuencia resultantes es: "+resultado);
        }
    }
}
