using System;

namespace Practica7 {
    public class FabricaDeAlumnoCompuesto : FabricaDeComparables {
        public override Comparable crearAleatorio() {
            return new AlumnoCompuesto();
        }

        public override Comparable crearPorTeclado() {
            return new AlumnoCompuesto();
        }
    }
}