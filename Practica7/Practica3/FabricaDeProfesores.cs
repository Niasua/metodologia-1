using System;

namespace Practica7 {
    // Ejercicio 9 Practica 3
    public class FabricaDeProfesores : FabricaDeComparables {
        public FabricaDeProfesores()
        {
            this.generarCadenaDeResponsables();
        }

        public override Comparable crearAleatorio() {
            return new Profesor(this.responsable.stringAleatorio(), this.responsable.numeroAleatorio(10000000), this.responsable.numeroAleatorio(35));
        }

        public override Comparable crearDesdeArchivo(int cant = 1, int max = 1)
        {
            return new Profesor(this.responsable.stringDesdeArchivo(cant), this.responsable.numeroDesdeArchivo(max), this.responsable.numeroDesdeArchivo(max));
        }

        public override Comparable crearPorTeclado() {
            return new Profesor(this.responsable.stringPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado());
        }
    }
}