using System;

namespace Practica4 {
    public interface Observado {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}