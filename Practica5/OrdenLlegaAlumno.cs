using System;

namespace Practica5 {
    public class OrdenLlegaAlumno : OrdenEnAula2 {
        Aula aula;
        public OrdenLlegaAlumno(Aula aula) {
            this.aula = aula;
        }
        public void ejecutar(Comparable comparable) {
            this.aula.nuevoAlumno((Alumno)comparable);
        }
    }
}