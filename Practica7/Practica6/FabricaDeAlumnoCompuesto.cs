using System;

namespace Practica7 {
    public class FabricaDeAlumnoCompuesto : FabricaDeComparables {
        public FabricaDeAlumnoCompuesto()
        {
            this.generarCadenaDeResponsables();
        }

        public override Comparable crearAleatorio() {
            return new AlumnoCompuesto();
        }

        public override Comparable crearDesdeArchivo(int cant = 1, int max = 1)
        {
            return new AlumnoCompuesto();
        }

        public override Comparable crearPorTeclado() {
            return new AlumnoCompuesto();
        }
    }
}