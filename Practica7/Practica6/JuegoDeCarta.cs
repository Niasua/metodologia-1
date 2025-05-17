using System;

namespace Practica7 {
    public abstract class JuegoDeCarta {
        protected Persona p1;
        protected Persona p2;

        public Persona jugar(Persona p1, Persona p2) {
            this.p1 = p1;
            this.p2 = p2;
            mezclar();
            repartir();
            while(!hayGanador()) {
                tomarCarta();
                descartar();
            }
            if(p1.getEsGanador()) {
                return p1;
            } else {
                return p2;
            }

        }

        // private porque ningun hijo lo modificara
        private void mezclar() {
            Console.WriteLine("Estoy mezclando cartas");
        }

        protected abstract void repartir();
        protected abstract bool hayGanador();
        protected abstract void tomarCarta();
        protected abstract void descartar();
    }
}