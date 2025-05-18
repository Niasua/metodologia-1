using System;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Comparable alumno = new FabricaDeAlumnos().crearAleatorio();
                Console.WriteLine(alumno.ToString());
            }
            for(int i = 0; i < 2; i++)
            {
                Comparable alumnoEstudioso = new FabricaDeAlumnosMuyEstudiosos().crearPorTeclado();
                Console.WriteLine(alumnoEstudioso.ToString());
            }
            for(int i = 0; i < 5; i++)
            {
                Comparable alumnoCompuesto = new FabricaDeAlumnoCompuesto().crearDesdeArchivo();
                Console.WriteLine(alumnoCompuesto.ToString());
            }

        }
    }
}