using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectonodo
{
    internal class adyacente
    {
        int nodoOrigen, nodoDestino;
        double Peso;
        public adyacente(int nodoOrigen, int nodoDestino , double Peso)
        {
            this.nodoOrigen = nodoOrigen;
            this.nodoDestino = nodoDestino;
            this.Peso += Peso;
        }
        override
        public String ToString()
        {
            return nodoOrigen.ToString() + "->" + nodoDestino.ToString() + " " + Peso.ToString();
        }
    }
}
