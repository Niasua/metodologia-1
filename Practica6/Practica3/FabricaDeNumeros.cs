using System;

namespace Practica6 {
    // Ejercicio 5
    public class FabricaDeNumeros : FabricaDeComparables {
        public override Comparable crearAleatorio() {
            return new Numero(gen.numeroAleatorio(1000));
        }

        public override Comparable crearPorTeclado() {
            return new Numero(lec.numeroPorTeclado());
        }
    }
}