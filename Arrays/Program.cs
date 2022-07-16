using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    internal class Punto
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public String Dibujar()
        {
            return "(" + X + ", " + Y + ")";
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            Punto[] lista;
            lista = new Punto[4];

            Punto p0, p1, p2, p3;

            p0 = lista[0] = new Punto(10, 20);
            lista[2] = new Punto(130, 520);
            lista[3] = new Punto(150, 8);

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write("El punto " + i + " es ");
                if (lista[i] != null) Console.WriteLine(lista[i].Dibujar());
                else Console.WriteLine("NULL");
            }

            Punto[] listaDos = { new Punto(10, 20), new Punto(3, 24), new Punto(224, 32) };

            String[] direcciones = { "Norte", "Sur", "Este", "Oeste", new String(new char[] { 'S', 'u', 'r' }) };
            for (int i = 0; i < direcciones.Length; i++)
                Console.WriteLine("La dirección " + i + " es " + direcciones[i]);

            foreach (String elemento in direcciones)
                Console.WriteLine("la dirección es" + elemento);


            StringBuilder sb = new StringBuilder(100);
            for (int i = 0; i < 256; i++)
                sb.Append((char)i);

            Console.WriteLine(sb.ToString());




            Console.ReadLine();
        }

        static void MainUno(string[] args)
        {
            int[] lista;
            lista = new int[5];

            lista[0] = 10;
            lista[2] = 334;
            lista[3] = 373;
            lista[4] = 322234;

            for (int i = 0; i < lista.Length; i++)
                Console.WriteLine("El elemento " + i + " vale " + lista[i]);

            PonerEnPantalla(lista);

            int[] otraLista = { 10, 20, 30, 40, 50, 60, 70 };
            PonerEnPantalla(otraLista);

            //Array instantáneo, "en ese mismo instante"
            PonerEnPantalla(new int[] { 10, 20, 30, 40, 50, 60, 70, 80 });

            //Otro array instantáneo, pero no lo parece; params
            PonerEnPantalla(100, 200, 3200, 400, 500);



            char[] letras = { 'A', 'E', 'I', 'O', 'U' };
            letras[3] = (char)66;

            //letras[5] = 'X';

            for (int i = 0; i < letras.Length; i++)
                Console.WriteLine("El elemento " + i + " vale " + letras[i]);

            char[] letrasLargo;
            letrasLargo = new char[5];
            letrasLargo[0] = 'A';
            letrasLargo[1] = 'E';
            letrasLargo[2] = 'I';
            letrasLargo[3] = 'O';
            letrasLargo[4] = 'U';


            Console.ReadLine();
        }

        public static void PonerEnPantalla(params int[] lista)
        {
            Console.WriteLine("------------------------------");
            for (int i = 0; i < lista.Length; i++)
                Console.WriteLine("El elemento " + i + " vale " + lista[i]);
        }
    }
}

