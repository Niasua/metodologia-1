using System;

namespace Practica7
{
    public interface Coleccionable : Iterable {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene (Comparable c);
    }
}