using System;

namespace Practica7 {
    public class AlumnoCompuesto : IAlumno
    {

        private List<IAlumno> hijos;

        public AlumnoCompuesto() {
            this.hijos = new List<IAlumno>();
        }

        // Implementa desde IAlumno
        public void actualizar(Observado o)
        {

            throw new NotImplementedException();
        }

        public void distraerse()
        {
            throw new NotImplementedException();
        }

        public int getCalificacion()
        {
            throw new NotImplementedException();
        }

        public int getLegajo()
        {
            throw new NotImplementedException();
        }

        public string getNombre() {
            string nombres = "";
            foreach(IAlumno hijo in hijos) {
                nombres += hijo.getNombre() + "\n";
            }
            return nombres;
        }

        public int getPromedio()
        {
            throw new NotImplementedException();
        }

        public string mostrarCalificacion()
        {
            foreach(IAlumno hijo in hijos) {
                hijo.mostrarCalificacion();
            }
            return "Muestra de Calificaciones finalizada";
        }

        public void prestarAtencion()
        {
            throw new NotImplementedException();
        }

        public int responderPregunta(int pregunta)
        {
            int respuestaMasRepetida = 0;
            int maxRepetiones = 0;

            foreach(IAlumno hijo in this.hijos) {
                int actual = hijo.responderPregunta(pregunta);
                int repeticiones = 0;

                foreach(IAlumno hijo2 in this.hijos) {
                    if(hijo2.responderPregunta(pregunta) == actual) {
                        repeticiones++;
                    }
                }

                if(repeticiones > maxRepetiones) {
                    maxRepetiones = repeticiones;
                    respuestaMasRepetida = actual;
                }

                Console.WriteLine(actual);
                
            }
            Console.WriteLine("Respuesta Mas repetida: ");
            Console.WriteLine(respuestaMasRepetida);
            
            return respuestaMasRepetida;
        }

        public void setCalificacion(int nvaCalificacion)
        {
            foreach(IAlumno hijo in hijos) {
                hijo.setCalificacion(nvaCalificacion);
            }
        }

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            throw new NotImplementedException();
        }

        public bool sosIgual(Comparable c)
        {
            foreach(IAlumno hijo in hijos) {
                if(hijo.sosIgual(c)) {
                    return true;
                }
            }
            return false;
        }

        public bool sosMayor(Comparable c)
        {
            foreach(IAlumno hijo in hijos) {
                if(!hijo.sosMayor(c)) {
                    return false;
                }
            }
            return true;
        }

        public bool sosMenor(Comparable c)
        {
            foreach(IAlumno hijo in hijos) {
                if(!hijo.sosMenor(c)) {
                    return false;
                }
            }
            return true;
        }

        // Metodos propios
        public void agregarHijos(IAlumno a) {
            this.hijos.Add(a);
        }

        
    }
}