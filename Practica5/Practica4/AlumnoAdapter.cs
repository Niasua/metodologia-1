using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
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
            return this.alumno.sosIgual((Comparable)((AlumnoAdapter)student).alumno);
        }
		public bool lessThan(Student student) {
            return this.alumno.sosMenor((Comparable)((AlumnoAdapter)student).alumno);
        }
		public bool greaterThan(Student student) {
            return this.alumno.sosMayor((Comparable)((AlumnoAdapter)student).alumno);
        }
    }
}