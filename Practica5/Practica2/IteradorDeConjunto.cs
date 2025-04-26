using System;

namespace Practica4 {
    public class IteradorDeConjunto : Iterador {
        private Conjunto conjunto;
        private int indice;

        public IteradorDeConjunto(Conjunto conjunto) {
            this.conjunto = conjunto;
            this.primero();
        }

        public void primero() {
            this.indice = 0;
        }
        public void siguiente() {
            this.indice++;
        }
        public bool fin() {
            return this.indice >= this.conjunto.cuantos();
        }
        public Comparable actual() {
            return this.conjunto.getElemento(this.indice);
        }
    }
}