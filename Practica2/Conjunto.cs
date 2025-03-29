using System;

// Ejercicio 3 Practica 2
namespace Practica2 {
    public class Conjunto {
        // tipo object para que sea mas flexible
        private List<object> conjunto;

        // constructor
        public Conjunto() {
            this.conjunto = new List<object>();
        }

        // metodos propios
        public void agregar(object elemento) {
            if (!pertenece(elemento)) {
                conjunto.Add(elemento); 
            }
        }
        public bool pertenece(object elemento) {
            return conjunto.Contains(elemento);
        }
    }
}