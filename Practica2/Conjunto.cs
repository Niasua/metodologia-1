using System;

// Ejercicio 3 Practica 2
namespace Practica2 {
    public class Conjunto : Coleccionable {
        private List<Comparable> conjunto;

        // constructor
        public Conjunto() {
            this.conjunto = new List<Comparable>();
        }

        // implementado desde interface Iterable
        public Iterador crearIterador() {
            return new IteradorDeConjunto(this);
        }

        // metodos implementados desde Coleccionable
        public int cuantos() {
            return this.conjunto.Count;
        }

        public Comparable minimo() {
            Comparable minimo = this.conjunto[0];
            for(int i = 1; i < this.conjunto.Count; i++) {
                if(this.conjunto[i].sosMenor(minimo)) {
                    minimo = this.conjunto[i];
                }
            }
            return minimo;
        }

        public Comparable maximo() {
            Comparable maximo = this.conjunto[0];
            for(int i = 1; i < this.conjunto.Count; i++) {
                if(this.conjunto[i].sosMayor(maximo)) {
                    maximo = this.conjunto[i];
                }
            }
            return maximo;
        }

        public void agregar(Comparable c) {
            if (!pertenece(c)) {
                conjunto.Add(c); 
            }        
        }

        public bool contiene (Comparable c) {
            return pertenece(c);
        }

        // metodos propios
        // agregar esta en los implementados

        public bool pertenece(Comparable elemento) {
            for (int i = 0; i < conjunto.Count ; i++) {
                if(elemento.sosIgual(conjunto[i])){ 
                    return true;
                }
            }
            return false;        
        }

        // getter
        public Comparable getElemento(int indice) {
            return this.conjunto[indice];
        }

        public override string ToString() {
            string resultado = "{";
            for (int i = 0; i < conjunto.Count; i++) {
                resultado += conjunto[i].ToString();
                if (i < conjunto.Count - 1) {
                    resultado += ", ";
                }
            }
            resultado += "}";
            return resultado;
        }

    }
}