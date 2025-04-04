using System;

namespace Practica2 {
    // Ejercicio 1
    public class EstrategiaPorDni : EstrategiaDeComparacion {
        // metodos implementados desde EstrategiaDeComparacion
        public bool sosIgual(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getDni() == ((Alumno)c2).getDni();
        }
        public bool sosMayor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getDni() > ((Alumno)c2).getDni();
        }
        public bool sosMenor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getDni() < ((Alumno)c2).getDni();
        }

    }   
}
