using System;

namespace Practica7 {
    public interface Observado {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}