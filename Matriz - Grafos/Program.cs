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
            BreinerPruebas logica = new BreinerPruebas();
            var respuesta = logica.Calcular(2, 4);
            Console.WriteLine(respuesta);
            Console.ReadKey();
            //la mala daniel
        }
    }
}
