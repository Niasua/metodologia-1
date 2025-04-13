using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    // Creado para Ejercicio 4 Practica 4
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables {
        public override Comparable crearAleatorio() {
            return new AlumnoMuyEstudioso(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(10000),gen.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado() {
            return new AlumnoMuyEstudioso(lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado());
        }
        
    }
}