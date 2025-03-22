using System;

namespace Practica1
{
    // Se implementó interface Coleccionable (Ejercicio 3)
    public interface Coleccionable {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene (Comparable c);
    }
}