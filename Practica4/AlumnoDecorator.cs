using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    // Ejercicio 6 Practica 4
    public abstract class AlumnoDecorator : IAlumno {
        protected IAlumno adicional;

        public AlumnoDecorator(IAlumno adicional) {
            this.adicional = adicional;
        }

        // Se implementa la interfaz IAlumno
        public void actualizar(Observado o) {
            this.adicional.actualizar(o);
        }      
        public int getLegajo() {
            return this.adicional.getLegajo();
        }
        public int getPromedio() {
            return this.adicional.getPromedio();
        }
        public string getNombre() {
            return this.adicional.getNombre();
        }
        public void setEstrategia(EstrategiaDeComparacion estrategia) {
            this.adicional.setEstrategia(estrategia);
        }
        public int getCalificacion() {
            return this.adicional.getCalificacion();
        }
        public void setCalificacion(int nvaCalificacion) {
            this.adicional.setCalificacion(nvaCalificacion);
        }
        public string ToString() {
            return this.adicional.ToString();
        }
        public void prestarAtencion() {
            this.adicional.prestarAtencion();
        }
        public void distraerse() {
            this.adicional.prestarAtencion();
        }
        public int responderPregunta(int pregunta) {
            return this.adicional.responderPregunta(pregunta);
        }
        public string mostrarCalificacion() {
            return this.adicional.mostrarCalificacion();
        }

        // Heredado desde Comparable
        public bool sosIgual(Comparable c) {
            return this.adicional.sosIgual(c);
        }
        public bool sosMayor(Comparable c) {
            return this.adicional.sosMayor(c);

        }
        public bool sosMenor(Comparable c) {
            return this.adicional.sosMenor(c);
        }
    }
}