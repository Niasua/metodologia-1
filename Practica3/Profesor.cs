using System;

namespace Practica3 {
    // Ejercicio 8
    public class Profesor : Persona {
        private int antiguedad;

        public Profesor(string n, int d, int a) : base(n, d){
            this.nombre = n;
            this. dni = d;
            this.antiguedad = a;
        }

        // metodos implementados desde Comparable
        public bool sosIgual(Comparable c) {
            return this.antiguedad == ((Profesor)c).antiguedad;
        }
        public bool sosMayor(Comparable c) {
            return this.antiguedad > ((Profesor)c).antiguedad;

        }
        public bool sosMenor(Comparable c) {
            return this.antiguedad < ((Profesor)c).antiguedad;

        }

        //metodos propios
        public void hablarALaClase() {
            Console.WriteLine("Hablando de algún tema");
        }

        public void escribirEnElPizarron() {
            Console.WriteLine("Escribiendo en el pizarrón");
            
        }
    }
}