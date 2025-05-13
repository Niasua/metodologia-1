using System;

namespace Practica6 {
    public class Chinchon : JuegoDeCarta {
        public static int turno = 1;

        public Chinchon() {
            turno = 1;
        }

        public string getJugador() {
            if(turno % 2 == 0) {
                return "Jugador 2";
            } else {
                return "Jugador 1";
            }
        }

        protected override void repartir() {
            Console.WriteLine("Repartiendo 7 cartas a cada jugador...");
        }

        protected override void tomarCarta() {
            Console.WriteLine("\n" + "Turno del " + getJugador());
            
            Console.WriteLine(getJugador() + " toma una carta del mazo.");
        }

        protected override void descartar() {
            Console.WriteLine(getJugador() + " descarta una carta");
        }

        protected override bool hayGanador() {
            Console.Write("Ingresa 1 para seguir jugando o 9 para declarar que hiciste chinchón: ");
            int opcion = int.Parse(Console.ReadLine());

            if (opcion == 9) {
                Console.WriteLine("\n" + getJugador() + " hizo chinchón y ganó la partida!");
                if(getJugador() == "Jugador 1") {
                    p1.setEsGanador(true);
                } else {
                    p2.setEsGanador(true);
                }
                return true;
            }

            turno++;
            return false;
        }
    }
}
