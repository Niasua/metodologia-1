using System;

namespace Practica3 {
    // Ejercicio 1
    public interface EstrategiaDeComparacion {
        bool sosIgual(Comparable c1, Comparable c2);
        bool sosMayor(Comparable c1, Comparable c2);
        bool sosMenor(Comparable c1, Comparable c2);
    }
}