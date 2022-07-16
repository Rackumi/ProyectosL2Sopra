using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Controls;

namespace Objetos{

    internal class UnaClase{ //: Object
    
        public String Texto { get; set; }

        public UnaClase(string texto)   //:base()
        {
            Texto = texto;
        }

        public override String ToString()
        {
            return this.GetType().FullName + ": " + Texto;
        }

        public override bool Equals(Object estoEsUnObject)
        {
            //if (estoEsUnObject is UnaClase)
            //{
            //    UnaClase elOtro = (UnaClase)estoEsUnObject;
            //    return this.Texto.Equals(elOtro.Texto);
            //}
            //else return false;

            UnaClase elOtro = estoEsUnObject as UnaClase;
            if (elOtro == null) return false;
            return this.Texto.Equals(elOtro.Texto);
        }
    }



    internal class Program{
        static void Main(string[] args){

            UnaClase uc = new UnaClase("Un texto de ejemplo");
            UnaClase otro = new UnaClase("Un texto de ejemplo");

            Console.WriteLine(uc.ToString());

            Console.WriteLine("Hola".ToString());


            if (uc.Equals(otro)) Console.WriteLine("El contenido es el mismo");
            else Console.WriteLine("El contenido es diferente");


            if (uc.Equals(new StringBuilder())) Console.WriteLine("El contenido es el mismo");
            else Console.WriteLine("El contenido es diferente");

            Console.ReadLine();

        }
    }

}