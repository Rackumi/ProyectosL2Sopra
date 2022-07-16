//using Graficos.Figuras;
//using Graficos.Graficos;
//using Graficos.Transformaciones;
//using Graficos.Ventanas;
//using System;
//using System.Drawing;
//using System.Windows.Forms;

namespace Graficos{
    internal class Program{

        //[STAThread]
        static void Main(){
            //        Punto p1 = new Punto(10, 20);
            //        Punto p2 = new Punto(10, 20);

            //        Console.WriteLine("La coordenada X de p1 es " + p1.X);

            //        Triángulo t1 = new Triángulo(p1, p1, p1);

            //        Console.WriteLine(p1.ToString());
            //        Console.WriteLine(p2.ToString());
            //        Console.WriteLine(t1.ToString());

            //        if (p1 == p2) Console.WriteLine("Esas dos variables de referencia guardan la misma dirección de memoria");
            //        else Console.WriteLine("Esas dos variables de referencia apuntan a objetos distintos");

            //        if (p1.Equals(p2)) Console.WriteLine("Esas dos variables de referencia guardan direcciones de memoria a objetos distintos (o no) pero con el mismo contenido");


            //        //POLIMORFISMO
            //        PuntoGráfico pg1 = new PuntoGráfico(100, 200, new Font("Arial", 45));
            //        Punto punto = pg1;
            //        Object objeto = pg1;
            //        IGráfico gráfico = pg1;
            //        IFigura figura = pg1;



            //        Console.WriteLine("Punto Gráfico: " + pg1.ToString());
            //        Console.WriteLine("Punto: " + punto.ToString());
            //        Console.WriteLine("Object: " + objeto.ToString());
            //        Console.WriteLine("IGráfico: " + gráfico.ToString());
            //        Console.WriteLine("IFigura: " + figura.ToString());





            //        //Punto[] lista = {new Punto(10, 20), new Punto(20, 30), new Punto(45, 56), new Punto(34, 56), new Punto(-45, -68)};
            //        //Polígono pol1 = new Polígono(lista);

            //        //Polígono pol1 = new Polígono(new Punto[] { new Punto(10, 20), new Punto(20, 30), new Punto(45, 56), new Punto(34, 56), new Punto(-45, -68) });

            //        //Polígono pol1 = new Polígono(new Punto(10, 20), new Punto(20, 30), new Punto(45, 56), new Punto(34, 56), new Punto(45, 68));
            //        //Console.WriteLine("POL1 es " + pol1.Dibujar()); //"(10, 20) --- (20, 30) --- (45, 56) --- (34, 56) --- (-45, -68)"
            //        //Console.WriteLine("POL1 mide " + pol1.Longitud());


            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);

            //        Font f = new Font("Arial", 9);
            //        Application.Run(new Ventana("Gráficos", new Transformación(),
            //                                    new PuntoGráfico(-40, -300, Color.Red, f),
            //                                    new PuntoGráfico(-341, 112, f),
            //                                    new PuntoGráfico(400, 500, Color.Blue, f),
            //                                    new PuntoGráfico(0, 0, f),
            //                                    new SegmentoLíneaGráfico(new PuntoGráfico(60, 418, f),
            //                                                             new PuntoGráfico(-347, 47, f),
            //                                                             Color.DeepPink),
            //                                    new TriánguloGráfico(new PuntoGráfico(200, 99, Color.Chocolate, f),
            //                                                         new PuntoGráfico(409, 212, Color.Chocolate, f),
            //                                                         new PuntoGráfico(-307, 376, Color.Chocolate, f),
            //                                                         Color.Red),
            //                                    new CircunferenciaGráfico(new PuntoGráfico(600, -200, f), 207.6, Color.Blue),
            //                                    new PolígonoGráfico(Color.Orange, new PuntoGráfico(200, 345, f),
            //                                                                      new PuntoGráfico(400, 360, f),
            //                                                                      new PuntoGráfico(500, 545, f),
            //                                                                      new PuntoGráfico(300, 603, f),
            //                                                                      new PuntoGráfico(190, 407, f))
            //         )); ;
            //    }


            //    [STAThread]
            //    static void MainFormularioCutre()
            //    {
            //        Application.EnableVisualStyles();
            //        Application.SetCompatibleTextRenderingDefault(false);

            //        Form f = new Form();
            //        f.Text = "Qué ventana tan molona";
            //        f.Size = new Size(1000, 600);
            //        f.Location = new Point(100, 100);

            //        Button botón = new Button();
            //        botón.Text = "Pulsar";
            //        botón.Location = new Point(20, 40);
            //        botón.Size = new Size(150, 40);


            //        TextBox cuadro = new TextBox();
            //        cuadro.Text = "Un texto";
            //        cuadro.Location = new Point(20, 90);
            //        cuadro.Size = new Size(150, 40);

            //        f.Controls.Add(botón);
            //        f.Controls.Add(cuadro);

            //        Application.Run(f);

            //    }
            //    static void MainUno(string[] args)
            //    {

            //        String texto;
            //        //texto = new String(new char[] {'h','o','l','a'});
            //        texto = "hola";

            //        Console.WriteLine("Puntos creados: " + Punto.LeerVeces());
            //        Punto p1, p2;
            //        Console.WriteLine("Puntos creados: " + Punto.LeerVeces());


            //        texto = "hola";

            //        p1 = new Punto(0, 0);
            //        p2 = new Punto(300, 400);

            //        Console.WriteLine("Puntos creados: " + Punto.LeerVeces());

            //        //p1.ponerX(-10);
            //        //p1.ponerY(20);
            //        ////p1.x = -1000;
            //        //p1.ponerY(2);
            //        p1.X = -10;
            //        p1.Y = 3000;
            //        Console.WriteLine("El valor de X es " + p1.X);

            //        Console.WriteLine("P1 es " + p1.Dibujar());
            //        Console.WriteLine("P2 es " + p2.Dibujar());


            //        SegmentoLínea sl1 = new SegmentoLínea(p2, new Punto(230, 45));
            //        Console.WriteLine("SL1 es " + sl1.Dibujar());
            //        Console.WriteLine("La longitud de SL1 es " + sl1.Longitud());
            //        Console.WriteLine("El punto medio de SL1 es " + sl1.PuntoMedio().Dibujar());


            //        Console.WriteLine("Puntos creados: " + Punto.LeerVeces());

            //        Triángulo t1;
            //        t1 = new Triángulo(p1, p2, new Punto(10, 343));
            //        Console.WriteLine("T1 es " + t1.Dibujar());
            //        Console.WriteLine("El perímetro de T1 es " + t1.Longitud());

            //        Circunferencia c1 = new Circunferencia(new Punto(10, 232), -78.9);
            //        Console.WriteLine("C1 es " + c1.Dibujar());
            //        Console.WriteLine("El perímetro de C1 es " + c1.Longitud());


            //        Console.WriteLine("-----------------------------------------------");
            //        Console.WriteLine("-----------------------------------------------");
            //        EscribirEnLaConsola("El punto P1", p1);
            //        EscribirEnLaConsola("El punto P2", p2);
            //        EscribirEnLaConsola("La circunferencia C1", c1);
            //        EscribirEnLaConsola("El triángulo T1", t1);

            //        Punto p3 = new Punto(10, 20);
            //        Punto p4 = new Punto(10, 20);
            //        Punto p5;
            //        p5 = p3;
            //        if (p3 == p4) Console.WriteLine("P3 y P4 son iguales");
            //        else Console.WriteLine("La variables de tipo referencia P3 y P4 contienen diferentes direcciones de memoria");

            //        if (p3 == p5) Console.WriteLine("Las variables de tipo referencia P3 y P5 contienen el mismo " +
            //            "número, la misma dirección de memoria, hacen referencia al mismo trozo de memoria, " +
            //            "al mismo objeto");
            //        else Console.WriteLine("P3 y P4 son distintos");

            //        if (p3.X == p4.X && p3.Y == p4.Y) Console.WriteLine("Los objetos referenciados por P3 y P4 contienen los mismos valores. Se dice que son iguales.");

            //        int uno, dos;
            //        uno = 100;
            //        dos = 42;
            //        if (uno == dos) Console.WriteLine("uno y dos son iguales");
            //        else Console.WriteLine("uno y dos son distintos");

            //        p4 = null;
            //        // ERROR!!!  p4.X = 100;
            //        Console.WriteLine("Puntos creados: " + Punto.LeerVeces());
            //        Console.ReadLine();
            //    }
            //    public static void EscribirEnLaConsola(String texto, IFigura eso)
            //    {
            //        Console.WriteLine(texto + " ES " + eso.Dibujar());
            //        Console.WriteLine(texto + " MIDE " + eso.Longitud());
            //        Console.WriteLine("-------");
            //    }
        }
    }
}