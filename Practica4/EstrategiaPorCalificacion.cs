using System;
using MetodologíasDeProgramaciónI;

// Ejercicio 5 Practica 4
namespace Practica4 {
    public class EstrategiaPorCalificacion : EstrategiaDeComparacion {
        // metodos implementados desde EstrategiaDeComparacion
        public bool sosIgual(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getCalificacion() == ((Alumno)c2).getCalificacion();
        }
        public bool sosMayor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getCalificacion() > ((Alumno)c2).getCalificacion();
        }
        public bool sosMenor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getCalificacion() < ((Alumno)c2).getCalificacion();
        }   
    }
}

