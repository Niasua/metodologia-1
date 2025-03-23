using System;

namespace Practica1 {
    public abstract class Persona : Comparable {
        // atributos
        protected string nombre;
        protected int dni;


        // constructor
        public Persona(string nombre, int dni) {
            this.nombre = nombre;
            this.dni = dni;
        }


        // metodos implementados desde Comparable
        public bool sosIgual(Comparable c) {
            return this.dni == ((Persona)c).dni; 
        }
        public bool sosMayor(Comparable c) {
            return this.dni > ((Persona)c).dni; 
        }
        public bool sosMenor(Comparable c) {
            return this.dni < ((Persona)c).dni; 
        }


        // metodos propios
        public string getNombre() {
            return this.nombre;
        }

        public int getDni() {
            return this.dni;
        }
    }
}