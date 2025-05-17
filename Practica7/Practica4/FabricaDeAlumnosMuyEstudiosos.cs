using System;
using MetodologíasDeProgramaciónI;

namespace Practica7 {
    // Creado para Ejercicio 4 Practica 4
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables {
        public FabricaDeAlumnosMuyEstudiosos()
        {
            this.generarCadenaDeResponsables();
        }

        public override Comparable crearAleatorio() {
            return new AlumnoMuyEstudioso(this.responsable.stringAleatorio(), this.responsable.numeroAleatorio(10000000), this.responsable.numeroAleatorio(10000),this.responsable.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado() {
            return new AlumnoMuyEstudioso(this.responsable.stringPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado());
        }
        
    }
}