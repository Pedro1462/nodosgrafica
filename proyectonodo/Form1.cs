using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Drawing.Charts;
using Aspose.Words.Drawing;


namespace proyectonodo
{
    public partial class Form1 : Form
    {
        private Point[] nodePositions;
        private List<Tuple<int, int>> adyacencias;

        public Form1()
        {
            InitializeComponent();
            adyacencias = new List<Tuple<int, int>>();
            dibuja.Visible = false;
            nodoOrigen.Visible = false;
            nodoDestino.Visible = false;
            Adyac.Visible = false;
            numNodoDestino.Visible = false;
            numNodoOrigen.Visible = false;
            listAdyac.Visible = false;
            dibAdya.Visible = false;
            button1.Visible = false;
            agreAdyac.Visible = false;
        }

        private void dibuja_Click(object sender, EventArgs e)
        {
           
            int numeroNodos = (int)numNodos.Value;
            if (numeroNodos >= 1 && numeroNodos <= 15)
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

            nodoOrigen.Visible = true;
            nodoDestino.Visible = true;
            numNodoDestino.Visible = true;
            numNodoOrigen.Visible = true;
        }

        private void agreAdyac_Click(object sender, EventArgs e)
        {

            String adyacente = $"{numNodoOrigen.Value}-{numNodoDestino.Value}";
            if (!listAdyac.Items.Contains(adyacente))
            {
                listAdyac.Items.Add(adyacente);
            }
            else
            {
                MessageBox.Show("La adyacencia ya existe en la lista.");
            }


            Adyac.Visible=true;
            listAdyac.Visible=true;
            dibAdya.Visible=true;
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
            dibuja.Visible = true;

        }

        private void numNodoOrigen_ValueChanged(object sender, EventArgs e)
        {
            numNodoOrigen.Maximum = numNodos.Value;
            agreAdyac.Visible = true;
            

        }

        private void numNodoDestino_ValueChanged(object sender, EventArgs e)
        {
            numNodoDestino.Maximum = numNodos.Value;
            agreAdyac.Visible=true;
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
            Graphics h = e.Graphics;
            Pen pluma = new Pen(Color.Red);
            foreach (var adyacencia in adyacencias)
            {
                int nodoOrigen = adyacencia.Item1;
                int nodoDestino = adyacencia.Item2;

                if (nodoOrigen >= 0 && nodoOrigen < nodePositions.Length && nodoDestino >= 0 && nodoDestino < nodePositions.Length)
                {
                    Point origen = nodePositions[nodoOrigen];
                    Point destino = nodePositions[nodoDestino];
                    h.DrawLine(pluma, origen, destino);
                }
            }
        }

        private void dibAdya_Click(object sender, EventArgs e)
        {
            if (listAdyac.SelectedItem != null)
            {
                if (listAdyac.SelectedItem != null)
                {
                    string selectedAdyacencia = listAdyac.SelectedItem.ToString();
                    string[] parts = selectedAdyacencia.Split('-');
                    if (parts.Length == 2)
                    {
                        int nodoOrigen = int.Parse(parts[0]) - 1;
                        int nodoDestino = int.Parse(parts[1]) - 1;

                        // Agregar la adyacencia a la lista y repintar el panel
                        adyacencias.Add(new Tuple<int, int>(nodoOrigen, nodoDestino));
                        panel.Invalidate();
                    }
                }
            }

            button1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guardarpanel(panel, @"C:\Users\pedro\Documents\Pedro\Universidad\Cuatrimestre 3\Estructura de Datos Avanzadas\proyectonodos\proyectonodo\bin\Debug\grafica.docx");
            MessageBox.Show("Se ha generado con éxito");

        }

        private Bitmap capturaPanel(Panel panel)
        {
            Bitmap captura= new Bitmap(panel.Width,panel.Height);
            panel.DrawToBitmap(captura,new Rectangle(0,0,panel.Width,panel.Height));
            return captura;
        }

        private void guardadotemp(Panel panel, string textoArchivo)
        {
            Bitmap captura = (capturaPanel(panel));
            captura.Save(textoArchivo,System.Drawing.Imaging.ImageFormat.Png);
        }

        public void insertarImagen(string imagen, string textArchivo)
        {
            Document doc = new Document();
            DocumentBuilder builder = new DocumentBuilder(doc);
            builder.InsertImage(imagen);
            doc.Save(textArchivo);
        }

        public void guardarpanel(Panel panel, string texArchivo)
        {
            string tempImagen = Path.GetTempFileName()+".png";
            guardadotemp(panel, tempImagen);
            insertarImagen(tempImagen, texArchivo);

            if (File.Exists(tempImagen))
            {
                File.Delete(tempImagen);
            }

        }
    }
}
