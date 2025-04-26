using System;

namespace Practica5 {
    public class OrdenAulaLlena : OrdenEnAula1 {
        Aula aula;
        public OrdenAulaLlena(Aula aula) {
            this.aula = aula;
        }
        public void ejecutar() {
            this.aula.claseLista();
        }

    }
}