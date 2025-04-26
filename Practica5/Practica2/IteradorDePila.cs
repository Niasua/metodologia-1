using System;

namespace Practica5 {
    public class IteradorDePila : Iterador {
        private Pila p;
        private int indice;

        public IteradorDePila(Pila p) {
            this.p = p;
            this.primero();
        }

        public void primero() {
            this.indice = 0;
        }
        public void siguiente() {
            this.indice++;
        }
        public bool fin() {
            return this.indice >= this.p.cuantos();
        }
        public Comparable actual() {
            return this.p.getElemento(this.indice);
        }

        
    }
}