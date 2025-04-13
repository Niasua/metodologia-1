using System;

namespace Practica4 {
    public class IteradorDeCola : Iterador {
        private Cola cola;
        private int indice;

        public IteradorDeCola(Cola cola) {
            this.cola = cola;
            this.primero();
        }

        public void primero() {
            this.indice = 0;
        }
        public void siguiente() {
            this.indice++;
        }
        public bool fin() {
            return this.indice >= this.cola.cuantos();
        }
        public Comparable actual() {
            return this.cola.getElemento(this.indice);
        }
        
    }
}