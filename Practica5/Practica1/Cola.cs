using System;

namespace Practica5
{
    
    public class Cola : Coleccionable {

        private List<Comparable> elementos;
        private OrdenEnAula1 ordenInicio;
        private OrdenEnAula2 ordenLlegaAlumno;
        private OrdenEnAula1 ordenAulaLlena;

        public Cola () {
            this.elementos = new List<Comparable>();
        }

        // implementado desde interface Iterable
        public Iterador crearIterador() {
            return new IteradorDeCola(this);
        }

        // implementados desde interface Coleccionable
        public int cuantos() {
            return elementos.Count;
        }
        public Comparable minimo() {
            Comparable minimo = elementos[0];
            for (int i = 0; i < elementos.Count; i++) {
                if (minimo.sosMayor(elementos[i]))
                    minimo = elementos[i];
            }
            return minimo;
        }
        public Comparable maximo() {
            Comparable maximo = elementos[0];
            for (int i = 0; i < elementos.Count; i++) {
                if (maximo.sosMenor(elementos[i]))
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
        public bool contiene (Comparable c) {
            for (int i = 0; i < elementos.Count ; i++) {
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

        public void encolar(Comparable c) {
            agregar(c);
        }

        public Comparable desencolar () {
            Comparable aux = elementos[0];
            elementos.RemoveAt(0);
            return aux;
        }

        // getter
        public Comparable getElemento(int indice) {
            return this.elementos[indice];
        }

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