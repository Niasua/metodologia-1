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

        public override Comparable crearPorTeclado() {
            return new Alumno(this.responsable.stringPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado());
        }
        
    }
}