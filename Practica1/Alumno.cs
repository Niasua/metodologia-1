using System;

namespace Practica1 {
    //(Ejercicio 12)
    public class Alumno : Persona {
        // atributos
        private int legajo, promedio;

        // constructor
        // en base se llama al constructor de la superclase, pasando los valores que se necesitan
        public Alumno(string n, int d, int legajo, int promedio) : base(n, d) { 
            this.legajo = legajo;
            this.promedio = promedio;
        }

        // metodos propios
        public int getLegajo() {
            return this.legajo;
        }

        public int getPromedio() {
            return this.promedio;
        }

        // no es necesario volver a implementar los metodos de la superclase
    }
}