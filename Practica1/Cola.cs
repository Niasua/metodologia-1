using System;

namespace Practica1
{
    // Se implementó Cola (Ejercicio 4)
    public class Cola : Coleccionable {

        private List<Comparable> elementos;

        public Cola () {
            this.elementos = new List<Comparable>();
        }

        // implementados desde interface Coleccionable
        public int cuantos() {
            return elementos.Count;
        }
        public Comparable minimo() {
            Comparable minimo = elementos[0];
            for (int i = 0; i < elementos.Count; i++) {
                if (minimo.sosMenor(elementos[i]))
                    minimo = elementos[i];
            }
            return minimo;
        }
        public Comparable maximo() {
            Comparable maximo = elementos[0];
            for (int i = 0; i < elementos.Count; i++) {
                if (maximo.sosMayor(elementos[i]))
                    maximo = elementos[i];
            }
            return maximo;
        }
        public void agregar(Comparable c) {
            elementos.Add(c);
        }
        public bool contiene (Comparable c) {
            for (int i = 0; i < elementos.Count ; i++) {
                if(c.sosIgual(elementos[i])){ 
                    return true;
                }
            }
            return false;
            
        } // se podría hacer ---> return elementos.Contains(c); ???
        
        // métodos propios

        public void encolar(Comparable c) {
            agregar(c);
        }

        public Comparable desencolar () {
            Comparable aux = elementos[0];
            elementos.RemoveAt(0);
            return aux;
        }
    }
}