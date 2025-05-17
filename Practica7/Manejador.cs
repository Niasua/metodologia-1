using System;

namespace Practica7
{
    public abstract class Manejador 
    {
        protected Manejador sucesor;

        public Manejador(Manejador m)
        {
            this.sucesor = m;
        }

        // implementar la interfaz publica de cada objeto que compone la jerarquia
        // de lector de datos
        public int numeroPorTeclado() 
        {
            if(sucesor != null)
            {
                return sucesor.numeroPorTeclado();
            } 
            return 0;
        }

        public string stringPorTeclado() 
        {
            if(sucesor != null)
            {
                return sucesor.stringPorTeclado();
            }
            return "";
        }

        // de generador de datos aleatorios
        public int numeroAleatorio(int max) 
        {
            if(sucesor != null) 
            {
                return sucesor.numeroAleatorio(max);
            }
            return 0;
        }
        public string stringAleatorio(int cant = 5) 
        {
            if(sucesor != null)
            {
                return sucesor.stringAleatorio(cant);
            }
            return "";
        }

    }
}