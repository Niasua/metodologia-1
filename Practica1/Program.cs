using System;

namespace Practica1
{
    public class Program {
        static void Main(string[] args) {
            
            Pila pila1 = new Pila();
            Cola cola1 = new Cola();

            // se instancia ColeccionMultiple en main (Ejercicio 9)
            ColeccionMultiple colMul1 = new ColeccionMultiple(pila1, cola1);

            llenar(pila1);
            llenar(cola1);
            informar(pila1);
            informar(cola1);
            informar(colMul1);
        }

        // Ejercicio 6
        public static void informar(Coleccionable coleccion) {
            Console.WriteLine(coleccion.cuantos());
            Console.WriteLine(coleccion.minimo());
            Console.WriteLine(coleccion.maximo());
            Console.WriteLine("Ingrese un número:");
            Comparable c = new Numero(int.Parse(Console.ReadLine()));
            if (coleccion.contiene(c))
                Console.WriteLine("El elemento leído está en la colección");
            else
                Console.WriteLine("El elemento leído no está en la colección");
        }

        // Ejercicio 5
        public static void llenar(Coleccionable c) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = new Numero(i);
                c.agregar(nuevoComparable);
            }
        }
    }
}
