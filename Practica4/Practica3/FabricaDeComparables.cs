using System;

namespace Practica4 {
    // Ejercicio 4
    public abstract class FabricaDeComparables {
        // generador y lector heredables
        protected GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos lec = new LectorDeDatos();

        // metodos de clase
        public static Comparable crearAleatorio(int opcion) {
            FabricaDeComparables fabrica = null;
            switch (opcion) {
                case 1: 
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2: 
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
                default:
                    break;
            }
            return fabrica.crearAleatorio();
        }

        public static Comparable crearPorTeclado(int opcion) {
            FabricaDeComparables fabrica = null;
            switch (opcion) {
                case 1: 
                    fabrica = new FabricaDeNumeros();
                    break;
                case 2: 
                    fabrica = new FabricaDeAlumnos();
                    break;
                case 3:
                    fabrica = new FabricaDeProfesores();
                    break;
                case 4:
                    fabrica = new FabricaDeAlumnosMuyEstudiosos();
                    break;
                default:
                    break;
            }
            return fabrica.crearPorTeclado();
        }

        // metodos de instancia
        public abstract Comparable crearAleatorio();

        public abstract Comparable crearPorTeclado();
        
    }
}