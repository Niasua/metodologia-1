using System;
using MetodologíasDeProgramaciónI;

namespace Practica6 {
    // Ejercicio 3 Practica 4
    public class AlumnoAdapter : Student {
        private IAlumno alumno;

        public AlumnoAdapter(IAlumno alumno) {
            this.alumno = alumno;
        }

        public string getName() {
            return this.alumno.getNombre();
        }
		public int yourAnswerIs(int question) {
            return this.alumno.responderPregunta(question);
        }
		public void setScore(int score) {
            this.alumno.setCalificacion(score);
        }
		public string showResult() {
            return this.alumno.mostrarCalificacion();
        }
		public bool equals(Student student) {
            return this.alumno.sosIgual(((AlumnoAdapter)student).alumno);
        }
		public bool lessThan(Student student) {
            return this.alumno.sosMenor(((AlumnoAdapter)student).alumno);
        }
		public bool greaterThan(Student student) {
            return this.alumno.sosMayor(((AlumnoAdapter)student).alumno);
        }
    }
}