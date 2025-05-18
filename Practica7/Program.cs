using System;

namespace Practica7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            { 
                Comparable alumno = FabricaDeAlumnos.crearAleatorio(2);
                Console.WriteLine(alumno.ToString());
            }
            for(int i = 0; i < 2; i++)
            {
                Comparable alumnoEstudioso = FabricaDeAlumnosMuyEstudiosos.crearPorTeclado(4);
                Console.WriteLine(alumnoEstudioso.ToString());
            }
            for(int i = 0; i < 5; i++)
            {
                Comparable alumnoCompuesto = FabricaDeAlumnoCompuesto.crearDesdeArchivo(6);
                Console.WriteLine(alumnoCompuesto.ToString());
            }

        }
    }
}