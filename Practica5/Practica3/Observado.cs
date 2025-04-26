using System;

namespace Practica5 {
    public interface Observado {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}