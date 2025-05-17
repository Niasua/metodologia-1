using System;
using System.Security.Cryptography;

namespace Practica7 {
    public class Truco : JuegoDeCarta {
        public static int turno;

        public Truco() {
            turno = 1;
        }

        public string getJugador() {
            if (turno % 2 == 0) {
                return "Jugador 2";
            } else {
                return "Jugador 1";
            }
        }

        protected override void descartar() {
            Console.WriteLine(getJugador() + " jugando una de las cartas");
            turno++;
        }

        protected override bool hayGanador() {
            if (turno == 1) {
                Console.WriteLine("Empieza la partida!");
            }

            Console.WriteLine(getJugador() + ": ");
            int n = int.Parse(Console.ReadLine());

            if(n == 3) {
                Console.WriteLine("\nEl ganador es " + getJugador() + "\n\n\n");
                if(getJugador() == "Jugador 1") {
                    p1.setEsGanador(true);
                } else {
                    p2.setEsGanador(true);
                }                
                return true;
            }
            return false;
        }

        protected override void repartir() {
            Console.WriteLine("Repartiendo cartas de Truco");
        }

        protected override void tomarCarta() {}
    }
}
