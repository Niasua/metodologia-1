using System;

namespace Practica2
{
    public class Program {
        static void Main(string[] args) {
            // ejercicio 7 practica 2
            Pila pila1 = new Pila();
            Cola cola1 = new Cola();
            Conjunto conjunto1 = new Conjunto();

            llenarAlumnos(pila1, new EstrategiaPorLegajo()); 
            llenarAlumnos(cola1, new EstrategiaPorDni());
            llenarAlumnos(conjunto1, new EstrategiaPorLegajo());

            imprimirElementos(conjunto1);
        }

        public static void informar(Coleccionable coleccionable) {
            Console.WriteLine(coleccionable.cuantos());
            Console.WriteLine(coleccionable.minimo());
            Console.WriteLine(coleccionable.maximo());
            Console.WriteLine("Ingrese el legajo del alumno:");
            int legajo = int.Parse(Console.ReadLine());
            // Se crea un alumno genérico, con legajo pasado por teclado (luego se compara con legajo)
            Alumno c = new Alumno("NombreAlumno", 101010, legajo, 10);  
            if (coleccionable.contiene(c))
                Console.WriteLine("El alumno está en la colección.");
            else
                Console.WriteLine("El alumno no está en la colección.");
        }
        
        public static void llenar(Coleccionable coleccionable) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = new Numero(i);
                coleccionable.agregar(nuevoComparable);
            }
        }

        // ejercicio 2
        public static void llenarAlumnos(Coleccionable coleccionable, EstrategiaDeComparacion estrategia) {
            for (int i = 0; i < 20; i++) {
                Alumno nuevoComparable = new Alumno("Jorge", i, i, i);
                nuevoComparable.setEstrategia(estrategia);
                coleccionable.agregar(nuevoComparable);
            }
        }

        public static void imprimirElementos(Coleccionable col) {
            Iterador ite = col.crearIterador();
            ite.primero();
            while(!ite.fin()) {
                Console.WriteLine(ite.actual());
                ite.siguiente();
            }
        }
    }
}