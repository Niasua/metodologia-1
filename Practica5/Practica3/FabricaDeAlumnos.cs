using System;

namespace Practica4 {
    // Ejercicio 5
    public class FabricaDeAlumnos : FabricaDeComparables {
        public override Comparable crearAleatorio() {
            return new Alumno(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(10000),gen.numeroAleatorio(10));
        }

        public override Comparable crearPorTeclado() {
            return new Alumno(lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado());
        }
        
    }
}