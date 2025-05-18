using System;
using System.Text;

namespace Practica7 {
    // Ejercicio 2
    public class GeneradorDeDatosAleatorios : Manejador 
    {
        private static GeneradorDeDatosAleatorios unicaInstancia = null;
        
        Random random = new Random();

        public GeneradorDeDatosAleatorios(Manejador m) : base(m)
        {
        }

        public override int numeroAleatorio(int max) {
            return this.random.Next(0, max);
        }
        public override string stringAleatorio(int cant = 5) {
            const string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            StringBuilder token = new StringBuilder();
            for(int i = 0; i < cant; i++) {
                int indice = random.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }
            return token.ToString();
        }

        // punto de acceso Singleton
        public static GeneradorDeDatosAleatorios getInstance(Manejador m)
        {
            if(unicaInstancia == null) 
            {
                unicaInstancia = new GeneradorDeDatosAleatorios(m);
            }
            return unicaInstancia;
        }
    }     
}