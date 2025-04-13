using System;

namespace Practica3 {
    public interface Observado {
        void agregarObservador(Observador o);
        void quitarObservador(Observador o);
        void notificar();
    }
}