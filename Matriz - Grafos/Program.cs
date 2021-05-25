using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz___Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

        

        }


        public static void logicaGrafo(int x, int y)
        {


            //Vertice nuevo = new Vertice(x);

            //foreach (var item in nuevo.ToString())
            //{

            //}

            //Vertice oVertice1 = new Vertice(1);
            //Vertice oVertice2 = new Vertice(2);
            //Vertice oVertice3 = new Vertice(3);
            //Vertice oVertice4 = new Vertice(4);
            //Vertice oVertice5 = new Vertice(5);
            //Vertice oVertice6 = new Vertice(6);

            //oVertice6.Aristas.Add(oVertice4);
            //oVertice4.Aristas.Add(oVertice5);
            //oVertice4.Aristas.Add(oVertice3);
            //oVertice3.Aristas.Add(oVertice2);
            //oVertice5.Aristas.Add(oVertice2);
            //oVertice5.Aristas.Add(oVertice1);
            //oVertice2.Aristas.Add(oVertice1);

            //GenerarGrafo(oVertice6);

        }


        public static void GenerarGrafo(Vertice oVertice, string sangria="")
        {
            if (oVertice != null)
            {
                Console.WriteLine(sangria+oVertice.Valor);
                foreach (var ov in oVertice.Aristas)
                {
                    GenerarGrafo(ov,sangria+"\t");
                }
            }
=======
            BreinerPruebas logica = new BreinerPruebas();
            var respuesta = logica.Calcular(2, 4);
            Console.WriteLine(respuesta);
            Console.ReadKey();
            //la mala daniel
>>>>>>> f9d3b3d967f31eb6dff7bf2c178f64eff29697ab
        }
    }
}
