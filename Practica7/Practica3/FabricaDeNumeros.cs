using System;

namespace Practica7 {
    // Ejercicio 5
    public class FabricaDeNumeros : FabricaDeComparables {
        public FabricaDeNumeros()
        {
            this.generarCadenaDeResponsables();
        }

        public override Comparable crearAleatorio() {
            return new Numero(this.responsable.numeroAleatorio(1000));
        }

        public override Comparable crearPorTeclado() {
            return new Numero(this.responsable.numeroPorTeclado());
        }
    }
}