using System;

namespace Practica6 {
    public class FabricaDeAlumnoProxy : FabricaDeComparables {
        public override Comparable crearAleatorio() {
            return new AlumnoProxy(gen.stringAleatorio());
        }

        public override Comparable crearPorTeclado() {
            return new AlumnoProxy(lec.stringPorTeclado());
        }
    }
}