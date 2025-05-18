using System;

namespace Practica7 {
    // Ejercicio 5
    public class FabricaDeAlumnos : FabricaDeComparables {
        public FabricaDeAlumnos()
        {
            this.generarCadenaDeResponsables();
        }

        public override Comparable crearAleatorio() {
            return new Alumno(this.responsable.stringAleatorio(), this.responsable.numeroAleatorio(10000000), this.responsable.numeroAleatorio(10000),this.responsable.numeroAleatorio(10));
        }

        public override Comparable crearDesdeArchivo(int cant = 1, int max = 1)
        {
            return new Alumno(this.responsable.stringDesdeArchivo(cant), this.responsable.numeroDesdeArchivo(max), this.responsable.numeroDesdeArchivo(max), this.responsable.numeroDesdeArchivo(max));
        }

        public override Comparable crearPorTeclado()
        {
            throw new NotImplementedException();
        }
    }
}