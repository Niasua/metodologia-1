using System;
using Practica1;

// Ejercicio 1
namespace Practica2 {
    public class EstrategiaPorLegajo : EstrategiaDeComparacion {
        // metodos implementados desde EstrategiaDeComparacion
        public bool sosIgual(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getLegajo() == ((Alumno)c2).getLegajo();
        }
        public bool sosMayor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getLegajo() > ((Alumno)c2).getLegajo();
        }
        public bool sosMenor(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getLegajo() < ((Alumno)c2).getLegajo();        
        }   
    }
}

