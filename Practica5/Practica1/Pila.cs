using System;
using System.Collections.Generic;

namespace Practica5
{
    public class Pila : Coleccionable, Ordenable {
        private List<Comparable> elementos;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenAulaLlena;

        public Pila() {
            this.elementos = new List<Comparable>();
        }

        // implementado desde interface Iterable
        public Iterador crearIterador() {
            return new IteradorDePila(this);
        }


        // implementados desde interface Coleccionable
        public int cuantos(){
            return this.elementos.Count;
        }
        public Comparable minimo(){
            // se crea un auxiliar para guardar el primer elemento de la lista
            Comparable minimo = elementos[0];
            // se itera desde el 2do elemento
            for (int i = 1; i < elementos.Count; i++) {
                // se usa el sosMenor() de Comparable
                if (elementos[i].sosMenor(minimo))
                    //se reemplaza el aux
                    minimo = elementos[i];
            }
            return minimo;
        }
        public Comparable maximo(){
            Comparable maximo = elementos[0];
            for (int i = 1; i < elementos.Count; i++) {
                if (elementos[i].sosMayor(maximo))
                    maximo = elementos[i];
            }
            return maximo;
        }


        public void agregar(Comparable c){
            elementos.Add(c);
    
            if (this.cuantos() == 1 && ordenInicio != null) {
                ordenInicio.ejecutar();
            }

            if (ordenLlegaAlumno != null) {
                ordenLlegaAlumno.ejecutar(c);
            }

            if (this.cuantos() == 40 && ordenAulaLlena != null) {
                ordenAulaLlena.ejecutar();
            }

        }
        public bool contiene (Comparable c){
            // itero sobre elementos
            for (int i = 0; i < elementos.Count ; i++) {
                // Se usa sosIgual() para comparar
                if(c.sosIgual(elementos[i])){ 
                    return true;
                }
            }
            return false;
        }

        // Implementados desde Ordenable (Practica 5)
        public void setOrdenInicio(OrdenEnAula1 orden) {
            this.ordenInicio = orden;
        }
        public void setOrdenLlegaAlumno(OrdenEnAula2 orden) {
            this.ordenLlegaAlumno = orden;

        }
        public void setOrdenAulaLlena(OrdenEnAula1 orden) {
            this.ordenAulaLlena = orden;

        }

        // métodos propios
        // apilo usando el método de agregar
        public void apilar(Comparable c) {
            agregar(c);
        }

        public Comparable desapilar() {
            // se guarda el ultimo elemento para que luego sea retornado
            Comparable ultimoElemento = elementos[elementos.Count - 1];
            // se elimina de la pila
            elementos.RemoveAt(elementos.Count - 1);
            return ultimoElemento;
        }

        // getter
        public Comparable getElemento(int indice) {
            return this.elementos[indice];
        }

        // Sobreescritura del método ToString()
        public override string ToString() {
            string resultado = "[";
            for (int i = 0; i < elementos.Count; i++) {
                resultado += elementos[i].ToString();
                if (i < elementos.Count - 1) {
                    resultado += ", ";
                }
            }
            resultado += "]";
            return resultado;
        }

    }
}