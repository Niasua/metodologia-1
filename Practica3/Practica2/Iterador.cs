using System;

namespace Practica3 {
    public interface Iterador {
        void primero();
        void siguiente();
        bool fin();
        Comparable actual();
    }
}