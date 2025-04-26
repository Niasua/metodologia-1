using System;
using MetodologíasDeProgramaciónI;

namespace Practica5 {
    public class Program {

        // MAIN VIEJO
        // static void Main(string[] args) {
        //     // Ejercicio 4 Practica 4
        //     Teacher teacher = new Teacher();
        //     for(int i = 0; i < 20; i++) {
        //         if(i < 10){
        //             Alumno alumno = (Alumno) new FabricaDeAlumnos().crearAleatorio();
        //             // Ejercicio 5 Practica 4 (Estableciendo estrategia de comparacion)
        //             alumno.setEstrategia(new EstrategiaPorCalificacion());
        //             // Se agrega el alumno decorado
        //             IAlumno alumnoDecorado = new StudentsFactory().aplicarDecorador(alumno);
        //             Student student = new AlumnoAdapter(alumnoDecorado);
        //             teacher.goToClass(student);
        //         } else {
        //             AlumnoMuyEstudioso alumno = (AlumnoMuyEstudioso) new FabricaDeAlumnosMuyEstudiosos().crearAleatorio();
        //             // Ejercicio 5 Practica 4 (Estableciendo estrategia de comparacion)
        //             alumno.setEstrategia(new EstrategiaPorCalificacion());
        //             IAlumno alumnoDecorado = new StudentsFactory().aplicarDecorador(alumno);
        //             Student student = new AlumnoAdapter(alumnoDecorado);
        //             teacher.goToClass(student);
        //         }
        //     }
        //     teacher.teachingAClass();
        // }
        static void Main(string[] args) {
            Teacher teacher = new Teacher();
            for(int i = 0; i < 10; i++) {
                if(i < 10){
                    string nombre = "AlumnoProxy" + i;
                    AlumnoProxy proxy = new AlumnoProxy(nombre);
                    IAlumno alumno = new DecoradorLegajo(proxy);
                    
                    AlumnoDecorator decorator2 = new DecoradorNotaLetras(alumno);
                    AlumnoDecorator decorator3 = new DecoradorEstado(decorator2);
                    AlumnoDecorator decorator4 = new DecoradorOrdenSecuencial(decorator3);
                    AlumnoDecorator decorator5 = new DecoradorRecuadro(decorator4);

                    Student student = new AlumnoAdapter(decorator5);

                    teacher.goToClass(student);
                }
            }
            teacher.teachingAClass();
        }


        
    }
}