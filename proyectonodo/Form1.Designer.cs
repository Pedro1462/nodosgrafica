namespace proyectonodo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dibuja = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numNodos = new System.Windows.Forms.NumericUpDown();
            this.Adyac = new System.Windows.Forms.Label();
            this.nodoOrigen = new System.Windows.Forms.Label();
            this.nodoDestino = new System.Windows.Forms.Label();
            this.listAdyac = new System.Windows.Forms.ComboBox();
            this.numNodoOrigen = new System.Windows.Forms.NumericUpDown();
            this.numNodoDestino = new System.Windows.Forms.NumericUpDown();
            this.agreAdyac = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numNodoPeso = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numNodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoPeso)).BeginInit();
            this.SuspendLayout();
            // 
            // dibuja
            // 
            this.dibuja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibuja.Location = new System.Drawing.Point(19, 23);
            this.dibuja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dibuja.Name = "dibuja";
            this.dibuja.Size = new System.Drawing.Size(92, 39);
            this.dibuja.TabIndex = 0;
            this.dibuja.Text = "Dibuja";
            this.dibuja.UseVisualStyleBackColor = true;
            this.dibuja.Click += new System.EventHandler(this.dibuja_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(387, 23);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(441, 400);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Nodos";
            // 
            // numNodos
            // 
            this.numNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodos.Location = new System.Drawing.Point(200, 84);
            this.numNodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numNodos.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numNodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodos.Name = "numNodos";
            this.numNodos.Size = new System.Drawing.Size(94, 28);
            this.numNodos.TabIndex = 3;
            this.numNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodos.Leave += new System.EventHandler(this.numNodos_Leave);
            // 
            // Adyac
            // 
            this.Adyac.AutoSize = true;
            this.Adyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adyac.Location = new System.Drawing.Point(15, 138);
            this.Adyac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Adyac.Name = "Adyac";
            this.Adyac.Size = new System.Drawing.Size(109, 24);
            this.Adyac.TabIndex = 4;
            this.Adyac.Text = "Adyacencia";
            // 
            // nodoOrigen
            // 
            this.nodoOrigen.AutoSize = true;
            this.nodoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoOrigen.Location = new System.Drawing.Point(15, 182);
            this.nodoOrigen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nodoOrigen.Name = "nodoOrigen";
            this.nodoOrigen.Size = new System.Drawing.Size(120, 24);
            this.nodoOrigen.TabIndex = 5;
            this.nodoOrigen.Text = "Nodo Origen";
            // 
            // nodoDestino
            // 
            this.nodoDestino.AutoSize = true;
            this.nodoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoDestino.Location = new System.Drawing.Point(15, 232);
            this.nodoDestino.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nodoDestino.Name = "nodoDestino";
            this.nodoDestino.Size = new System.Drawing.Size(125, 24);
            this.nodoDestino.TabIndex = 6;
            this.nodoDestino.Text = "Nodo Destino";
            // 
            // listAdyac
            // 
            this.listAdyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAdyac.FormattingEnabled = true;
            this.listAdyac.Location = new System.Drawing.Point(200, 132);
            this.listAdyac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listAdyac.Name = "listAdyac";
            this.listAdyac.Size = new System.Drawing.Size(135, 30);
            this.listAdyac.TabIndex = 7;
            this.listAdyac.SelectedIndexChanged += new System.EventHandler(this.listAdyac_SelectedIndexChanged);
            // 
            // numNodoOrigen
            // 
            this.numNodoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodoOrigen.Location = new System.Drawing.Point(200, 178);
            this.numNodoOrigen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numNodoOrigen.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numNodoOrigen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodoOrigen.Name = "numNodoOrigen";
            this.numNodoOrigen.Size = new System.Drawing.Size(94, 28);
            this.numNodoOrigen.TabIndex = 8;
            this.numNodoOrigen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numNodoDestino
            // 
            this.numNodoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodoDestino.Location = new System.Drawing.Point(200, 228);
            this.numNodoDestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numNodoDestino.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numNodoDestino.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodoDestino.Name = "numNodoDestino";
            this.numNodoDestino.Size = new System.Drawing.Size(94, 28);
            this.numNodoDestino.TabIndex = 9;
            this.numNodoDestino.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // agreAdyac
            // 
            this.agreAdyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreAdyac.Location = new System.Drawing.Point(19, 344);
            this.agreAdyac.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.agreAdyac.Name = "agreAdyac";
            this.agreAdyac.Size = new System.Drawing.Size(132, 65);
            this.agreAdyac.TabIndex = 10;
            this.agreAdyac.Text = "Agregar Adyacencia";
            this.agreAdyac.UseVisualStyleBackColor = true;
            this.agreAdyac.Click += new System.EventHandler(this.agreAdyac_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(168, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mostrar Nodos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(286, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 61);
            this.button2.TabIndex = 12;
            this.button2.Text = "Pintar Adyacencias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nodo Peso";
            // 
            // numNodoPeso
            // 
            this.numNodoPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodoPeso.Location = new System.Drawing.Point(200, 280);
            this.numNodoPeso.Margin = new System.Windows.Forms.Padding(2);
            this.numNodoPeso.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numNodoPeso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodoPeso.Name = "numNodoPeso";
            this.numNodoPeso.Size = new System.Drawing.Size(94, 28);
            this.numNodoPeso.TabIndex = 14;
            this.numNodoPeso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 445);
            this.Controls.Add(this.numNodoPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.agreAdyac);
            this.Controls.Add(this.numNodoDestino);
            this.Controls.Add(this.numNodoOrigen);
            this.Controls.Add(this.listAdyac);
            this.Controls.Add(this.nodoDestino);
            this.Controls.Add(this.nodoOrigen);
            this.Controls.Add(this.Adyac);
            this.Controls.Add(this.numNodos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dibuja);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoPeso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dibuja;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numNodos;
        private System.Windows.Forms.Label Adyac;
        private System.Windows.Forms.Label nodoOrigen;
        private System.Windows.Forms.Label nodoDestino;
        private System.Windows.Forms.ComboBox listAdyac;
        private System.Windows.Forms.NumericUpDown numNodoOrigen;
        private System.Windows.Forms.NumericUpDown numNodoDestino;
        private System.Windows.Forms.Button agreAdyac;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numNodoPeso;
    }
}

