using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace proyectonodo
{
    public partial class Form1 : Form
    {
        private Point[] nodePositions;
        public Form1()
        {
            InitializeComponent();
            // Deshabilitar controles inicialmente
            numNodoOrigen.Enabled = false; // Nodo de origen
            numNodoDestino.Enabled = false; // Nodo de destino
            numNodoPeso.Enabled = false; // Peso
            listAdyac.Enabled = false; // Combo
            button2.Enabled = false; // Botón agregar
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
            String adyacente = $"{numNodoOrigen.Value}-{numNodoDestino.Value}-{numNodoPeso.Value:F2}";
            listAdyac.Items.Add(adyacente);

        }

        private void listAdyac_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*adyacente adya;
            adya = (adyacente)listAdyac.Items[listAdyac.SelectedIndex];*/
        }

        private void numNodos_Leave(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
            numNodoDestino.Maximum = numNodos.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroNodos = (int)numNodos.Value;
            if (numeroNodos >= 1 && numeroNodos <= 50)
            {
                // Habilitar controles
                numNodoOrigen.Enabled = true; // Nodo de origen
                numNodoDestino.Enabled = true; // Nodo de destino
                numNodoPeso.Enabled = true; // Peso
                listAdyac.Enabled = true; // Combo
                button2.Enabled = true; // Botón agregar

                // Deshabilitar el campo de número de nodos
                numNodos.Enabled = false;

                // Calcular posiciones de nodos en un óvalo
                nodePositions = new Point[numeroNodos];
                float angleStep = 360f / numeroNodos;
                int centerX = panel.Width / 2;
                int centerY = panel.Height / 2;
                int radiusX = (int)(panel.Width * 0.4);  // Radio en el eje X (ajustable)
                int radiusY = (int)(panel.Height * 0.3); // Radio en el eje Y (ajustable)

                for (int i = 0; i < numeroNodos; i++)
                {
                    float angle = i * angleStep;
                    double angleRad = Math.PI * angle / 180.0;
                    int x = centerX + (int)(radiusX * Math.Cos(angleRad));
                    int y = centerY + (int)(radiusY * Math.Sin(angleRad));
                    nodePositions[i] = new Point(x, y);
                }

                panel.Invalidate(); // Forzar repintado del panel
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (nodePositions != null)
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.Black);

                for (int i = 0; i < nodePositions.Length; i++)
                {
                    g.FillEllipse(Brushes.Green, nodePositions[i].X - 5, nodePositions[i].Y - 5, 10, 10);
                    g.DrawString((i + 1).ToString(), this.Font, Brushes.Black, nodePositions[i]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listAdyac.SelectedItem != null)
            {
                string selectedAdyacencia = listAdyac.SelectedItem.ToString();
                string[] parts = selectedAdyacencia.Split('-');
                if (parts.Length == 3)
                {
                    int nodoOrigen = int.Parse(parts[0]) - 1;
                    int nodoDestino = int.Parse(parts[1]) - 1;
                    float peso = float.Parse(parts[2]);

                    Graphics dib = panel.CreateGraphics();
                    Pen pluma = new Pen(Color.Red, peso);

                    // Asegúrate de que los nodos están dentro del rango
                    if (nodoOrigen >= 0 && nodoOrigen < nodePositions.Length && nodoDestino >= 0 && nodoDestino < nodePositions.Length)
                    {
                        Point origen = nodePositions[nodoOrigen];
                        Point destino = nodePositions[nodoDestino];
                        dib.DrawLine(pluma, origen, destino);
                    }
                }
            }
    }
    }
}
