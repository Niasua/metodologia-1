using System;

namespace Practica3 {
    public class Alumno : Persona, Observador {
        // atributos
        private int legajo, promedio;
        // Ejercicio 2 Practica 2
        private EstrategiaDeComparacion estrategia;


        // constructor
        // en base se llama al constructor de la superclase, pasando los valores que se necesitan
        public Alumno(string n, int d, int legajo, int promedio) : base(n, d) { 
            this.legajo = legajo;
            this.promedio = promedio;
            this.estrategia = new EstrategiaPorLegajo();
        }
        

        // Se reimplementan para que se pueda comparar con el legajo usando la nueva estrategia
        // por legajo (ejercicio 2 practica 2) 
        public override bool sosIgual(Comparable c) {
            return this.estrategia.sosIgual(this, (Alumno)c);
        }
        public override bool sosMayor(Comparable c) {
            return this.estrategia.sosMayor(this, (Alumno)c);
        }
        public override bool sosMenor(Comparable c) {
            return this.estrategia.sosMenor(this, (Alumno)c);
        }

        // metodo implementado desde Observador (Ejercicio 12 Practica 3)
        public void actualizar(Observado o) {
            if(((Profesor)o).isHablando()) {
                this.prestarAtencion();
            } else {
                this.distraerse();
            }
        }       


        // metodos propios
        public int getLegajo() {
            return this.legajo;
        }

        public int getPromedio() {
            return this.promedio;
        }

        // ejercicio 2 (setter de estrategia para modificacion en tiempo de ejecucion)
        public void setEstrategia(EstrategiaDeComparacion estrategia) {
            this.estrategia = estrategia;
        }

        // Sobreescritura del método ToString()
        public override string ToString() {
            return this.legajo.ToString();
        }

        // Ejercicio 11 Practica 3
        public void prestarAtencion() {
            Console.WriteLine("Prestando atención");
            
        }
        public void distraerse() {
            Random rdn = new Random();
            string[] frases = new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
            Console.WriteLine(frases[rdn.Next(0,2)]);
        }
    }
}