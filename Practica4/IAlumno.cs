using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    public interface IAlumno : Comparable {

        public void actualizar(Observado o);       
        public int getLegajo();
        public int getPromedio();
        public string getNombre();
        public void setEstrategia(EstrategiaDeComparacion estrategia);
        public int getCalificacion();
        public void setCalificacion(int nvaCalificacion);
        public string ToString();
        public void prestarAtencion();
        public void distraerse();
        public int responderPregunta(int pregunta);
        public string mostrarCalificacion();
    }
}