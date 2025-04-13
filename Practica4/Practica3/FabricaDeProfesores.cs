using System;

namespace Practica3 {
    // Ejercicio 9 Practica 3
    public class FabricaDeProfesores : FabricaDeComparables {
        public override Comparable crearAleatorio() {
            return new Profesor(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(35));
        }

        public override Comparable crearPorTeclado() {
            return new Profesor(lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado());
        }
    }
}