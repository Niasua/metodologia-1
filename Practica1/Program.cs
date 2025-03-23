using System;

namespace Practica1
{
    public class Program {
        static void Main(string[] args) {
            
            Pila pila1 = new Pila();
            Cola cola1 = new Cola();

            // se instancia ColeccionMultiple en main (Ejercicio 9)
            ColeccionMultiple colMul1 = new ColeccionMultiple(pila1, cola1);

            // ejercicio 7
            // llenar(pila1);
            // llenar(cola1);

            llenarAlumnos(pila1); 
            llenarAlumnos(cola1);

            informar(pila1);
            informar(cola1);
            informar(colMul1);
        }


        // Ejercicio 6
        // public static void informar(Coleccionable coleccionable) {
        //     Console.WriteLine(coleccionable.cuantos());
        //     Console.WriteLine(coleccionable.minimo());
        //     Console.WriteLine(coleccionable.maximo());
        //     Console.WriteLine("Ingrese un número:");
        //     Comparable c = new Numero(int.Parse(Console.ReadLine()));
        //     
        //     if (coleccionable.contiene(c))
        //          Console.WriteLine("El elemento leído está en la colección");
        //     else
        //          Console.WriteLine("El elemento leído no está en la colección");
        //     }
        // }



        // Cambios en informar para adaptarlo a la clase Alumno (Ejercicio 15)
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
        

        // Ejercicio 5
        public static void llenar(Coleccionable coleccionable) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = new Numero(i);
                coleccionable.agregar(nuevoComparable);
            }
        }

        // Ejercicio 13
        public static void llenarAlumnos(Coleccionable coleccionable) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = new Alumno("Jorge", i, i, i);
                coleccionable.agregar(nuevoComparable);
            }
        }
    }
}
