using System;
using System.ComponentModel;

namespace Practica5 {
    // Ejercicio 1 Practica 5
    public class AlumnoProxy : IAlumno {
        private Alumno alumnoReal;
        private string nombreProxy;

        public AlumnoProxy(string nombreProxy) {
            this.nombreProxy = nombreProxy;
        }

        // lo que el proxy puede resolver
        public string getNombre() {
            return this.nombreProxy;
        }

        // lo que el proxy no puede resolver
        public void actualizar(Observado o) {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            this.alumnoReal.actualizar(o);
        }       

        public int getLegajo() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.getLegajo();
        }
        public int getPromedio() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.getPromedio();
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia) {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            this.alumnoReal.setEstrategia(estrategia);
        }
        public int getCalificacion() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.getCalificacion();
        }
        public void setCalificacion(int nvaCalificacion) {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            this.alumnoReal.setCalificacion(nvaCalificacion);
        }
        public override string ToString() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.ToString();
        }
        public void prestarAtencion() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            this.alumnoReal.prestarAtencion();
        }
        public void distraerse() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            this.alumnoReal.distraerse();
        }
        public int responderPregunta(int pregunta) {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
                Console.WriteLine("Se creó un alumnoReal");
            }
            return this.alumnoReal.responderPregunta(pregunta);
        }
        public string mostrarCalificacion() {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.mostrarCalificacion();
        }

        // De comparable
        public bool sosIgual(Comparable c) {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.sosIgual(c);
        }
        public bool sosMayor(Comparable c) {
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.sosMayor(c);
        }
        

        public bool sosMenor(Comparable c){
            if(this.alumnoReal == null) {
                alumnoReal = (Alumno)FabricaDeComparables.crearAleatorio(2);
            }
            return this.alumnoReal.sosMenor(c);
        }
    }
}