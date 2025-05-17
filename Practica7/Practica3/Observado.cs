using System;

namespace Practica6 {
    public interface Observado {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}