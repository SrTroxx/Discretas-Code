using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz___Grafos
{
    public class Vertice
    {
        #region "PROPIEDADES"

        public int Valor { get; set; }
        public List<Vertice> Aristas { get; set; }


        #region "CONSTRUCTOR"
        public Vertice(int valor)
        {

            this.Valor = valor;
            Aristas = new List<Vertice>();

        }
        #endregion

        #endregion
    }

}
