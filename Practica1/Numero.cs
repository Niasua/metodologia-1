using System;

namespace Practica1
{
    // Se implementa la clase número (Ejercicio 2)
    public class Numero : Comparable {
        // atributos
        private int valor;

        // constructor
        public Numero (int v) {
            this.valor = v;
        }

        // métodos implementados desde la interface Comparable
        public bool sosIgual(Comparable c){
            return this.valor == ((Numero)c).valor; 
        }
        public bool sosMayor(Comparable c){
            return this.valor > ((Numero)c).valor;
        }
        public bool sosMenor(Comparable c){
            return this.valor < ((Numero)c).valor;
        }

        // métodos propios
        public int getValor() {
            return this.valor;
        }
    }
}