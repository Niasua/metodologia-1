using System;
namespace Practica6 {
    // Ejercicio 3
    public class LectorDeDatos {
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