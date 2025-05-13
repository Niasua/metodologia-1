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

            // Composite
            
            // Teacher teacher = new Teacher();

            // for(int i = 0; i < 20; i++) {
            //     IAlumno compuesto = (IAlumno)new FabricaDeAlumnoCompuesto().crearAleatorio();
            //     Student alumnoAdaptado = new AlumnoAdapter(compuesto);
            //     teacher.goToClass(alumnoAdaptado);
            // }
            // teacher.teachingAClass();

            // Template Method
            JuegoDeCarta juego1 = new Truco();
            JuegoDeCarta juego2 = new Chinchon();
            Persona p1 = (Persona)new FabricaDeAlumnos().crearAleatorio();
            Persona p2 = (Persona)new FabricaDeAlumnos().crearAleatorio();

            int puntosP1 = 0;
            int puntosP2 = 0;
            for(int i = 0; i < 3; i++) {
                if(jugarPartida(p1, p2, juego1) == p1) {
                    puntosP1++;
                } else {
                    puntosP2++;
                }
            }
            if(puntosP1 == 2) {
                Console.WriteLine("El ganador es el Jugador 1 !!!");
            } else {
                Console.WriteLine("El ganador es el Jugador 2 !!!");
            }
        }

        public static Comparable crearAleatorio() {
            AlumnoCompuesto compuesto = (AlumnoCompuesto)new FabricaDeAlumnoCompuesto().crearAleatorio();
            for(int i = 0; i < 5; i++) {
                IAlumno proxy = (IAlumno)new FabricaDeAlumnoProxy().crearAleatorio();
                compuesto.agregarHijos(proxy);
            }
            return compuesto;
        }

        public static Persona jugarPartida(Persona p1, Persona p2, JuegoDeCarta juego) {
            return juego.jugar(p1, p2);
        }
    }
}