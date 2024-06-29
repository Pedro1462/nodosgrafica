using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectonodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dibuja_Click(object sender, EventArgs e)
        {
            Graphics dib;
            Pen pluma = new Pen(Color.Aqua);
            Font letra = new Font("Arial",12);
            Brush pincel = new SolidBrush(Color.Red);
            dib = panel.CreateGraphics();

            if (numNodos.Value>=1 && numNodos.Value<=15)
            {


                int valorx = 20;
                int valorxletra = 45;
                int valornuevo = 80;

                int x = valorx;
                int y = 20;
                int width =70;
                int height =70;
                int xletra = valorxletra;
                int yletra = 45;
                panel.Refresh();

                for (int numero = 1; numero-1 < numNodos.Value ; numero++)
                {
                    dib.DrawEllipse(pluma, x, y, width, height);
                    dib.DrawString(numero.ToString(), letra, pincel, xletra, yletra);
                    x = x + valornuevo;
                    xletra = xletra + valornuevo;

                    if (numero%4==0)
                    {
                        y = y + valornuevo;
                        yletra = yletra + valornuevo;
                        x = valorx;
                        xletra = valorxletra;

                    }
                }
            }



        }

        private void agreAdyac_Click(object sender, EventArgs e)
        {
            adyacente adya = new adyacente((int)numNodoOrigen.Value,(int)numNodoDestino.Value);
            listAdyac.Items.Add(adya);
        }

        private void listAdyac_SelectedIndexChanged(object sender, EventArgs e)
        {
            adyacente adya;
            adya = (adyacente)listAdyac.Items[listAdyac.SelectedIndex];
        }

        private void numNodos_Leave(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
            numNodoDestino.Maximum = numNodos.Value;
        }
    }
}
