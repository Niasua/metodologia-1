using System;
using MetodologíasDeProgramaciónI;
using Practica4;

namespace Practica3 {
    public class Program {
        static void Main(string[] args) {
            // Ejercicio 4 Practica 4
            Teacher teacher = new Teacher();
            for(int i = 0; i < 20; i++) {
                if(i < 10){
                    Alumno alumno = (Alumno) new FabricaDeAlumnos().crearAleatorio();
                    // Ejercicio 5 Practica 4 (Estableciendo estrategia de comparacion)
                    alumno.setEstrategia(new EstrategiaPorCalificacion());
                    // Se agrega el alumno decorado
                    IAlumno alumnoDecorado = new StudentsFactory().aplicarDecorador(alumno);
                    Student student = new AlumnoAdapter(alumnoDecorado);
                    teacher.goToClass(student);
                } else {
                    AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso) new FabricaDeAlumnosMuyEstudiosos().crearAleatorio();
                    // Ejercicio 5 Practica 4 (Estableciendo estrategia de comparacion)
                    alumno.setEstrategia(new EstrategiaPorCalificacion());
                    IAlumno alumnoDecorado = new StudentsFactory().aplicarDecorador(alumno);
                    Student student = new AlumnoAdapter(alumnoDecorado);
                    teacher.goToClass(student);
                }
            }

            
            teacher.teachingAClass();
            
        }


        
    }
}