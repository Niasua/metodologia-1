using System;
using MetodologíasDeProgramaciónI;

namespace Practica6 {
    public class Program {
        static void Main(string[] args) {
            // Chequeo de responderPregunta()
            // AlumnoCompuesto alumno = new AlumnoCompuesto();
            // Comparable alumno1 = new FabricaDeAlumnos().crearAleatorio();
            // Comparable alumno2 = new FabricaDeAlumnos().crearAleatorio();
            // Comparable alumno3 = new FabricaDeAlumnos().crearAleatorio();
            // Comparable alumno4 = new FabricaDeAlumnos().crearAleatorio();
            // Comparable alumno5 = new FabricaDeAlumnos().crearAleatorio();

            // alumno.agregarHijos((Alumno)alumno1);
            // alumno.agregarHijos((Alumno)alumno2);
            // alumno.agregarHijos((Alumno)alumno3);
            // alumno.agregarHijos((Alumno)alumno4);
            // alumno.agregarHijos((Alumno)alumno5);


            // alumno.responderPregunta(2);
            Teacher teacher = new Teacher();

            for(int i = 0; i < 20; i++) {
                IAlumno compuesto = (IAlumno)new FabricaDeAlumnoCompuesto().crearAleatorio();
                Student alumnoAdaptado = new AlumnoAdapter(compuesto);
                teacher.goToClass(alumnoAdaptado);
            }
            teacher.teachingAClass();
        }

        public Comparable crearAleatorio() {
            AlumnoCompuesto compuesto = (AlumnoCompuesto)new FabricaDeAlumnoCompuesto().crearAleatorio();
            for(int i = 0; i < 5; i++) {
                IAlumno proxy = (IAlumno)new FabricaDeAlumnoProxy().crearAleatorio();
                compuesto.agregarHijos(proxy);
            }
            return compuesto;
        }
    }
}