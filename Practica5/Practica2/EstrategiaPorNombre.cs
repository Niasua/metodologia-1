using System;

namespace Practica5 {
    // Ejercicio 1
    public class EstrategiaPorNombre : EstrategiaDeComparacion {
        public bool sosIgual(Comparable c1, Comparable c2) {
            return ((Alumno)c1).getNombre() == ((Alumno)c2).getNombre();
        }

        public bool sosMayor(Comparable c1, Comparable c2) {
            // .Compare() devuelve positivo si el primer string es mayor. 
            return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) > 0; 
        }

        public bool sosMenor(Comparable c1, Comparable c2) {
            // .Compare() devuelve negativo si el primer string es menor
            return string.Compare(((Alumno)c1).getNombre(), ((Alumno)c2).getNombre()) < 0;
        }
    }   
}
