using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    public interface IAlumno : Comparable {

        void actualizar(Observado o);       
        int getLegajo();
        int getPromedio();
        string getNombre();
        void setEstrategia(EstrategiaDeComparacion estrategia);
        int getCalificacion();
        void setCalificacion(int nvaCalificacion);
        string ToString();
        void prestarAtencion();
        void distraerse();
        int responderPregunta(int pregunta);
        string mostrarCalificacion();
    }
}