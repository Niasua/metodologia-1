using System;
namespace Practica7 {
    // Ejercicio 3
    public class LectorDeDatos : Manejador {
        public LectorDeDatos(Manejador m) : base(m)
        {
        }

        public int numeroPorTeclado() {
        Console.Write("Ingrese un número: ");
        return int.Parse(Console.ReadLine());
        }

        public string stringPorTeclado() {
            Console.Write("Ingrese un texto: ");
            return Console.ReadLine();
        }
    }

}