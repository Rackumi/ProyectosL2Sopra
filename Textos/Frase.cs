using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textos
{
    internal class Frase
    {
        private String frase;

        public Frase(String frase)
        {
            this.frase = frase;
        }

        public String AlRevesV1()
        {
            String nuevo = "";

            for (int i = this.frase.Length - 1; i >= 0; i--)
            {
                char letra = this.frase[i];
                //nuevo += letra;
                nuevo = nuevo + letra;
            }
            return nuevo;

        }

        public String AlRevesV2()
        {
            String nuevo = "";
            for (int i = 0; i < this.frase.Length; i++)
            {
                nuevo = this.frase[i] + nuevo;
            }

            return nuevo;

        }

        public String SinEspaciosV1()
        {
            String nuevo = "";
            int i = 0;
            char letra;
            while (i < this.frase.Length)
            {
                letra = this.frase[i];
                if (letra != ' ') nuevo += letra;
                i++;
            }

            return nuevo;
        }

        public String SinEspacios()
        {
            //Append(), Insert(posición, qué quieres insertar), ToString()
            StringBuilder sb = new StringBuilder();
            int i = 0;
            char letra;
            while (i < this.frase.Length)
            {
                letra = this.frase[i];
                if (letra != ' ') sb.Append(letra);
                i++;
            }

            return sb.ToString();

        }

        public String SinVocales()
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            char letra;
            while (i < this.frase.Length)
            {
                letra = this.frase[i];

                if (EsVocal(letra) == false) sb.Append(letra);
                i++;
            }

            return sb.ToString();
        }

        private bool EsVocal(char letra)
        {
            //letra = (char)(letra | 0x20);

            if (letra >= 'A' && letra <= 'Z') letra += (char)32;

            if (letra == 97) return true;
            if (letra == 'e') return true;
            if (letra == 'i') return true;
            if (letra == 'o') return true;
            if (letra == 'u') return true;
            return false;
        }

        public String Cuadrado(ushort veces, char letra)
        {
            /*short valor = 45;
            valor += 443;
            valor++;
            valor = (short)(valor + 1);
            valor = (short)(valor + 443);*/

            /*float numero = (float)45.6;
            numero = 43.44f;*/
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < veces; i++)
            {
                for (int j = 0; j < veces; j++)
                {
                    sb.Append(letra);
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public String Cuadrado(ushort veces)
        {
            StringBuilder sb = new StringBuilder();
            int contador = 0;
            String fraseSinEspacios = this.SinEspacios();

            for (int i = 0; i < veces; i++)
            {
                for (int j = 0; j < veces; j++)
                {
                    sb.Append(fraseSinEspacios[contador]);
                    contador++;
                    if (contador == fraseSinEspacios.Length) contador = 0;
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }

        public String Triangulo(int veces, char letra)
        {
            StringBuilder sb = new StringBuilder();

            int espacios = veces / 2;
            //int filas = espacios + 1;
            int letras = 1;

            //for (int i=0; i < filas; i++)
            while (espacios >= 0)
            {
                sb.Append(' ', espacios);
                sb.Append(letra, letras);
                sb.Append('\n');

                letras += 2;
                espacios--;
            }

            return sb.ToString();
        }

    }
}