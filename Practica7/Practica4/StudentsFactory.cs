using System;
using MetodologíasDeProgramaciónI;

namespace Practica7 {
    // Ejercicio 7 Practica 4
    public class StudentsFactory : FabricaDeAlumnos {

        public AlumnoDecorator aplicarDecorador(IAlumno alumno) {
            AlumnoDecorator decorator = new DecoradorLegajo(alumno);
            AlumnoDecorator decorator2 = new DecoradorNotaLetras(decorator);
            AlumnoDecorator decorator3 = new DecoradorEstado(decorator2);
            AlumnoDecorator decorator4 = new DecoradorOrdenSecuencial(decorator3);
            AlumnoDecorator decorator5 = new DecoradorRecuadro(decorator4);
            return decorator5;
        } 

        public override Comparable crearAleatorio() {
            Alumno alumno = new Alumno(this.responsable.stringAleatorio(), this.responsable.numeroAleatorio(10000000), this.responsable.numeroAleatorio(10000),this.responsable.numeroAleatorio(10));
            return aplicarDecorador(alumno);
        }

        public override Comparable crearPorTeclado() {
            Alumno alumno = new Alumno(this.responsable.stringPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado(), this.responsable.numeroPorTeclado());
            return aplicarDecorador(alumno);
        }
    }
}