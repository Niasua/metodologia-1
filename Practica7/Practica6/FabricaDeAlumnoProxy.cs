using System;

namespace Practica7 {
    public class FabricaDeAlumnoProxy : FabricaDeComparables {
        public FabricaDeAlumnoProxy()
        {
            this.generarCadenaDeResponsables();
        }

        public override Comparable crearAleatorio() {
            return new AlumnoProxy(this.responsable.stringAleatorio());
        }

        public override Comparable crearDesdeArchivo(int cant = 1, int max = 1)
        {
            return new AlumnoProxy(this.responsable.stringDesdeArchivo(cant));
        }

        public override Comparable crearPorTeclado() {
            return new AlumnoProxy(this.responsable.stringPorTeclado());
        }
    }
}