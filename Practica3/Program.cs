using System;

namespace Practica3 {
    public class Program {
        static void Main(string[] args) {
            
            Pila pila1 = new Pila();
            Pila pila2 = new Pila();

            Profesor profe = (Profesor) FabricaDeComparables.crearAleatorio(3);

            llenar(pila1, 2); // alumnos 
            llenar(pila2, 3); // profesores            

            Iterador ite = pila1.crearIterador();
            for(ite.primero(); !ite.fin(); ite.siguiente()) {
                profe.agregarObservador((Alumno)ite.actual());
            }

            dictadoDeClase(profe);
        }


        // Ejercicio 6 Practica 1 
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



        // Ejercicio 6 Practica 3
        public static void informar(Coleccionable coleccionable, int opcion) {
            Console.WriteLine(coleccionable.cuantos());
            Console.WriteLine(coleccionable.minimo());
            Console.WriteLine(coleccionable.maximo());

            Comparable elemento = FabricaDeComparables.crearPorTeclado(opcion);

            if (coleccionable.contiene(elemento))
                Console.WriteLine("El alumno está en la colección.");
            else
                Console.WriteLine("El alumno no está en la colección.");
        }
        

        // Ejercicio 6 Practica 3
        public static void llenar(Coleccionable coleccionable, int opcion) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = FabricaDeComparables.crearAleatorio(opcion);
                coleccionable.agregar(nuevoComparable);
            }
        }

        // Ejercicio 13 Practica 1
        public static void llenarAlumnos(Coleccionable coleccionable) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = FabricaDeComparables.crearAleatorio(2);
                coleccionable.agregar(nuevoComparable);
            }
        }

        // Ejercicio 13 Practica 3

        public static void dictadoDeClase(Profesor profe) {
            for(int i = 0; i < 2; i++) {
                profe.hablarALaClase();
                profe.escribirEnElPizarron();
            }
        }
    }
}