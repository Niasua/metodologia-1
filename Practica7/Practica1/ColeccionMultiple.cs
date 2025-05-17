using System;

namespace Practica7 {
    public class ColeccionMultiple : Coleccionable {
        // atributos
        private Pila pila;
        private Cola cola;

        // constructor
        public ColeccionMultiple(Pila pila, Cola cola) {
            this.pila = pila;
            this.cola = cola;
        }

        // implementado desde interface Iterable
        // no lo pide la consigna. Completado para que no de problemas 
        // al compilar
        public Iterador crearIterador() {
            return new IteradorDeCola(this.cola);
        }

        // Implementaciones de Coleccionable
        public int cuantos() {
            return pila.cuantos() + cola.cuantos();
        }
        public Comparable minimo() {
            // crea un auxiliar con el minimo de la pila
            Comparable aux = pila.minimo();
            // compara el minimo de la cola con el auxiliar para reemplazar o no
            if (cola.minimo().sosMenor(aux)) {
                aux = cola.minimo();
            }
            return aux;
        }
        public Comparable maximo() {
            Comparable aux = pila.maximo();
            if (cola.maximo().sosMayor(aux)) {
                aux = cola.maximo();
            }
            return aux;
        }

        // agregar no hace nada
        public void agregar(Comparable c) {}


        public bool contiene (Comparable c) {
            return pila.contiene(c) || cola.contiene(c);
        }
    }
}