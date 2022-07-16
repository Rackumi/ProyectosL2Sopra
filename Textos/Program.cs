using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textos {
    internal class Program {
        static void Main(string[] args) {
            Frase frase = new Frase("Esto es un texto de prueba");
            Console.WriteLine("Texto al revés" + frase.AlRevesV1());
            Console.WriteLine("Texto al revés" + frase.AlRevesV2());
            Console.WriteLine("Sin espacios: " + frase.SinEspacios());
            Console.WriteLine("Sin vocales: " + frase.SinVocales());
            /* Este método devuelve el siguiente texto;
             * XXXXX
             * XXXXX
             * XXXXX
             * XXXXX
             * XXXXX
             * 
             * es decir, un "cuadrado" de cinco letras de "largo" por cinco de "ancho"
             * Por cierto, el "intro", el "cambio de línea" se representa con "\n"
             */
            Console.WriteLine("Un cuadrado:\n" + frase.Cuadrado(5, 'X'));

            /*Similar al anterior, pero en retorcido:
             * Estoe
             * sunte
             * xtode
             * prueb
             * aEsto
             * 
             * En este caso, un cuadrado de cinco por cinco PERO con las letras de la frase.
             * Repitiendo desde el principio si es necesario.
             * Y sin espacios.
             */
            Console.WriteLine("Un cuadrado más guay:\n" + frase.Cuadrado(5));

            /* Dibuja un triángulo de 5 letras de base:
             *   X
             *  XXX
             * XXXXX
             * 
             * Sólo vale con números impares:
             * 3:
             *  X
             * XXX
             * 
             * 7:
             *    X
             *   XXX
             *  XXXXX
             * XXXXXXX
             * */
            Console.WriteLine("Un triángulo:\n" + frase.Triangulo(17, 'X'));

            //Si alguno se aburre
            //Console.WriteLine("Un triángulo Guay:\n" + frase.Triángulo(5));

            Console.ReadLine();
        }
    }
}

