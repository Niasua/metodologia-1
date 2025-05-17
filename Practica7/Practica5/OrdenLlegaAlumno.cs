using System;

namespace Practica7 {
    public class OrdenLlegaAlumno : OrdenEnAula2 {
        private Aula aula;
        public OrdenLlegaAlumno(Aula aula) {
            this.aula = aula;
        }
        public void ejecutar(Comparable comparable) {
            this.aula.nuevoAlumno((Alumno)comparable);
        }
    }
}