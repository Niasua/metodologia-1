using System;

namespace Practica4
{
    public interface Coleccionable : Iterable {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene (Comparable c);
    }
}