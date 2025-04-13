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
                    Student student = new AlumnoAdapter(alumno);
                    teacher.goToClass(student);
                } else {
                    AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso) new FabricaDeAlumnosMuyEstudiosos().crearAleatorio();
                    Student student = new AlumnoAdapter(alumno);
                    teacher.goToClass(student);
                }
            }
            teacher.teachingAClass();
        }


        
    }
}