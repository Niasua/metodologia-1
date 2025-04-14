using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    public class StudentsFactory : FabricaDeAlumnos {

        public AlumnoDecorator aplicarDecorador(Alumno alumno) {
            AlumnoDecorator decorator = new DecoradorLegajo(alumno);
            AlumnoDecorator decorator2 = new DecoradorNotaLetras(decorator);
            AlumnoDecorator decorator3 = new DecoradorEstado(decorator2);
            AlumnoDecorator decorator4 = new DecoradorOrdenSecuencial(decorator3);
            AlumnoDecorator decorator5 = new DecoradorRecuadro(decorator4);
            return decorator5;
        } 

        public override Comparable crearAleatorio() {
            Alumno alumno = new Alumno(gen.stringAleatorio(), gen.numeroAleatorio(10000000), gen.numeroAleatorio(10000),gen.numeroAleatorio(10));
            return aplicarDecorador(alumno);
        }

        public override Comparable crearPorTeclado() {
            Alumno alumno = new Alumno(lec.stringPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado(), lec.numeroPorTeclado());
            return aplicarDecorador(alumno);
        }
    }
}