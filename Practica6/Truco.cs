using System;

namespace Practica6 {
    public class Truco : JuegoDeCarta {
        public static int contador;

        public Truco() {
            contador = 1;
        }
        protected override void descartar()
        {
            if(contador % 2 == 0) {
                Console.WriteLine("Jugador 1 jugando una de las cartas");
            } else {
                Console.WriteLine("Jugador 2 jugando una de las cartas");
            }
        }

        protected override bool hayGanador()
        {
            if(contador == 1) {
                Console.WriteLine("Empieza la partida!");
            }
            if(contador % 2 == 0) {
                Console.WriteLine("Jugador 2: ");
            } else {
                Console.WriteLine("Jugador 1: ");
            }
            
            int n = int.Parse(Console.ReadLine());
            if(n != 3) {
                contador++;
            }
            if(n == 3) {
                if(contador % 2 == 0) {
                    Console.WriteLine("El ganador es el Jugador 2");
                } else {
                    Console.WriteLine("El ganador es el Jugador 1");
                }
            }
            return n == 3;
        }

        protected override void repartir()
        {
            Console.WriteLine("Repartiendo cartas de Truco");
        }

        protected override void tomarCarta() {}
    }
}