using System;
using System.Text;

namespace Practica7 {
    // Ejercicio 2
    public class GeneradorDeDatosAleatorios : Manejador {
        Random random = new Random();

        public GeneradorDeDatosAleatorios(Manejador m) : base(m)
        {
        }

        public int numeroAleatorio(int max) {
            return this.random.Next(0, max);
        }
        public string stringAleatorio(int cant = 5) {
            const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder token = new StringBuilder();
            for(int i = 0; i < cant; i++) {
                int indice = random.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }
            return token.ToString();
        }
    }     
}