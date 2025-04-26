using System;

// Ejercicio 3 Practica 2
namespace Practica5 {
    public class Conjunto : Coleccionable, Ordenable {
        private List<Comparable> conjunto;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenAulaLlena;

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
            this.ordenInicio.ejecutar();
            if(this.ordenLlegaAlumno != null) {
                this.ordenLlegaAlumno.ejecutar(c);
            }
            if(this.cuantos() == 40 && ordenAulaLlena != null) {
                ordenAulaLlena.ejecutar();
            }
        }

        public bool contiene (Comparable c) {
            return pertenece(c);
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