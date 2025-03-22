using System;

namespace Practica1
{
    public class Program {
        static void Main(string[] args) {

        }

        public void llenar(Coleccionable c) {
            for (int i = 0; i < 20; i++) {
                Comparable nuevoComparable = new Numero(i);
                c.agregar(nuevoComparable);
            }
        }
        
    }


}
