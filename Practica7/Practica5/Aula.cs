using System;
using MetodologíasDeProgramaciónI;

namespace Practica7 {
    public class Aula {
        private Teacher teacher;

        public void comenzar() {
            Console.WriteLine("Comienza la clase...");
            teacher = new Teacher();
        }

        public void nuevoAlumno(Alumno alumno) {
            this.teacher.goToClass(new AlumnoAdapter(alumno));
        }

        public void claseLista() {
            this.teacher.teachingAClass();
        }

    }
}