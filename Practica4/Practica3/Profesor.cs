using System;

namespace Practica3 {
    // Ejercicio 8 Practica 3
    public class Profesor : Persona, Observado {
        private int antiguedad;
        private List<Observador> observadores;
        private bool hablando;

        public Profesor(string n, int d, int a) : base(n, d){            
            this.antiguedad = a;
            this.observadores = new List<Observador>();
        }

        // metodos implementados desde Comparable
        public override bool sosIgual(Comparable c) {
            return this.antiguedad == ((Profesor)c).antiguedad;
        }
        public override bool sosMayor(Comparable c) {
            return this.antiguedad > ((Profesor)c).antiguedad;

        }
        public override bool sosMenor(Comparable c) {
            return this.antiguedad < ((Profesor)c).antiguedad;

        }

        // metodos implementados desde Observado (Ejercicio 12 Practica 3)
        public void agregarObservador(Observador o) {
            this.observadores.Add(o);
        }
        public void quitarObservador(Observador o) {
            this.observadores.Remove(o);
        }
        public void notificar() {
            foreach(Observador observador in observadores) {
                observador.actualizar(this);
            }
        }

        //metodos propios
        public void hablarALaClase() {
            Console.WriteLine("\nHablando de algún tema\n");
            this.hablando = true;
            this.notificar();
        }

        public void escribirEnElPizarron() {
            Console.WriteLine("\nEscribiendo en el pizarrón\n");   
            this.hablando = false;
            this.notificar();
        }

        public bool isHablando() {
            return this.hablando;
        }
    }
}