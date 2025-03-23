using System;

namespace Practica1
{
    public class Program {
        static void Main(string[] args) {
        
        }

        // Ejercicio 6
        public void informar(Coleccionable coleccion) {
            Console.WriteLine(coleccion.cuantos());
            Console.WriteLine(coleccion.minimo());
            Console.WriteLine(coleccion.maximo());
            Comparable c = new Numero(int.Parse(Console.ReadLine()));
            if (coleccion.contiene(c))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }

        // Ejercicio 5
        public void llenar(Coleccionable c) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = new Numero(i);
                c.agregar(nuevoComparable);
            }
        }
    }
}
