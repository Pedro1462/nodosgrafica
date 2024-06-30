using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectonodo
{
    internal class documentos
    {
        public void crear(string texto)
        {
            StreamWriter esc = new StreamWriter(texto);

            esc.Close();
        }

        public void escribir(string texto, string linea)
        {
            StreamWriter esc = File.AppendText(texto);
            esc.WriteLine(linea);
            esc.Close();
        }
    }
}
