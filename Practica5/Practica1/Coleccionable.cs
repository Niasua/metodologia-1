using System;

namespace Practica5
{
    public interface Coleccionable : Iterable {
        int cuantos();
        Comparable minimo();
        Comparable maximo();
        void agregar(Comparable c);
        bool contiene (Comparable c);
    }
}