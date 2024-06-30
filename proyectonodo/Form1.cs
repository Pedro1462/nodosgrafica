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
        private Point[] nodePositions;

        public Form1()
        {
            InitializeComponent();
        }

        private void dibuja_Click(object sender, EventArgs e)
        {
           
            int numeroNodos = (int)numNodos.Value;
            if (numeroNodos >= 1 && numeroNodos <= 50)
            {

                nodePositions = new Point[numeroNodos];
                float angleStep = 360f / numeroNodos;
                int centerX = panel.Width / 2;
                int centerY = panel.Height / 2;
                int radiusX = (int)(panel.Width * 0.4);
                int radiusY = (int)(panel.Height * 0.3);

                for (int i = 0; i < numeroNodos; i++)
                {
                    float angle = i * angleStep;
                    double angleRad = Math.PI * angle / 180.0;
                    int x = centerX + (int)(radiusX * Math.Cos(angleRad));
                    int y = centerY + (int)(radiusY * Math.Sin(angleRad));
                    nodePositions[i] = new Point(x, y);
                }

                panel.Invalidate();
            }
        }

        private void agreAdyac_Click(object sender, EventArgs e)
        {

            String adyacente = $"{numNodoOrigen.Value}-{numNodoDestino.Value}";
            listAdyac.Items.Add(adyacente);
        }

        private void listAdyac_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numNodos_Leave(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
            numNodoDestino.Maximum = numNodos.Value;
        }

        private void numNodoOrigen_Leave(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
        }

        private void numNodoDestino_Leave(object sender, EventArgs e)
        {
            numNodoDestino.Maximum = numNodos.Value;
        }

        private void numNodos_ValueChanged(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
            numNodoDestino.Maximum = numNodos.Value;

        }

        private void numNodoOrigen_ValueChanged(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
            

        }

        private void numNodoDestino_ValueChanged(object sender, EventArgs e)
        {
            numNodoDestino.Maximum = numNodos.Value;
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

        private void dibAdya_Click(object sender, EventArgs e)
        {
            if (listAdyac.SelectedItem != null)
            {
                string selectedAdyacencia = listAdyac.SelectedItem.ToString();
                string[] parts = selectedAdyacencia.Split('-');
                if (parts.Length == 2)
                {
                    int nodoOrigen = int.Parse(parts[0]) - 1;
                    int nodoDestino = int.Parse(parts[1]) - 1;

                    Graphics dib = panel.CreateGraphics();
                    Pen pluma = new Pen(Color.Red);

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
