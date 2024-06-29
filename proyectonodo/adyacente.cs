using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectonodo
{
    internal class adyacente
    {
        public int nodoOrigen, nodoDestino;
        public adyacente(int nodoOrigen, int nodoDestino)
        {
            this.nodoOrigen = nodoOrigen;
            this.nodoDestino = nodoDestino;
        }
        override
        public string ToString()
        { 
            return nodoOrigen.ToString()+"->"+nodoDestino.ToString();
        }
    }
}
