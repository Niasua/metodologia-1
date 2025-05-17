using System;

namespace Practica7 {
    // Ejercicio 1
    public class EstrategiaPorPromedio : EstrategiaDeComparacion {
        // metodos implementados desde EstrategiaDeComparacion
        public bool sosIgual(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getPromedio() == ((Alumno)c2).getPromedio();
        }
        public bool sosMayor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getPromedio() > ((Alumno)c2).getPromedio();
        }
        public bool sosMenor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getPromedio() < ((Alumno)c2).getPromedio();
        }

    }   
}
