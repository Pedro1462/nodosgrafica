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
            this.dibAdya = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // dibuja
            // 
            this.dibuja.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibuja.Location = new System.Drawing.Point(25, 82);
            this.dibuja.Name = "dibuja";
            this.dibuja.Size = new System.Drawing.Size(176, 62);
            this.dibuja.TabIndex = 0;
            this.dibuja.Text = "Dibuja";
            this.dibuja.UseVisualStyleBackColor = true;
            this.dibuja.Click += new System.EventHandler(this.dibuja_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(516, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(587, 492);
            this.panel.TabIndex = 1;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero de Nodos";
            // 
            // numNodos
            // 
            this.numNodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodos.Location = new System.Drawing.Point(267, 40);
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
            this.numNodos.Size = new System.Drawing.Size(125, 34);
            this.numNodos.TabIndex = 3;
            this.numNodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodos.ValueChanged += new System.EventHandler(this.numNodos_ValueChanged);
            this.numNodos.Leave += new System.EventHandler(this.numNodos_Leave);
            // 
            // Adyac
            // 
            this.Adyac.AutoSize = true;
            this.Adyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adyac.Location = new System.Drawing.Point(20, 416);
            this.Adyac.Name = "Adyac";
            this.Adyac.Size = new System.Drawing.Size(136, 29);
            this.Adyac.TabIndex = 4;
            this.Adyac.Text = "Adyacencia";
            // 
            // nodoOrigen
            // 
            this.nodoOrigen.AutoSize = true;
            this.nodoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoOrigen.Location = new System.Drawing.Point(20, 178);
            this.nodoOrigen.Name = "nodoOrigen";
            this.nodoOrigen.Size = new System.Drawing.Size(153, 29);
            this.nodoOrigen.TabIndex = 5;
            this.nodoOrigen.Text = "Nodo Origen";
            // 
            // nodoDestino
            // 
            this.nodoDestino.AutoSize = true;
            this.nodoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodoDestino.Location = new System.Drawing.Point(20, 237);
            this.nodoDestino.Name = "nodoDestino";
            this.nodoDestino.Size = new System.Drawing.Size(161, 29);
            this.nodoDestino.TabIndex = 6;
            this.nodoDestino.Text = "Nodo Destino";
            // 
            // listAdyac
            // 
            this.listAdyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAdyac.FormattingEnabled = true;
            this.listAdyac.Location = new System.Drawing.Point(267, 413);
            this.listAdyac.Name = "listAdyac";
            this.listAdyac.Size = new System.Drawing.Size(179, 37);
            this.listAdyac.TabIndex = 7;
            this.listAdyac.SelectedIndexChanged += new System.EventHandler(this.listAdyac_SelectedIndexChanged);
            // 
            // numNodoOrigen
            // 
            this.numNodoOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodoOrigen.Location = new System.Drawing.Point(267, 173);
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
            this.numNodoOrigen.Size = new System.Drawing.Size(125, 34);
            this.numNodoOrigen.TabIndex = 8;
            this.numNodoOrigen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodoOrigen.ValueChanged += new System.EventHandler(this.numNodoOrigen_ValueChanged);
            this.numNodoOrigen.Leave += new System.EventHandler(this.numNodoOrigen_Leave);
            // 
            // numNodoDestino
            // 
            this.numNodoDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNodoDestino.Location = new System.Drawing.Point(267, 237);
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
            this.numNodoDestino.Size = new System.Drawing.Size(125, 34);
            this.numNodoDestino.TabIndex = 9;
            this.numNodoDestino.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNodoDestino.ValueChanged += new System.EventHandler(this.numNodoDestino_ValueChanged);
            this.numNodoDestino.Leave += new System.EventHandler(this.numNodoDestino_Leave);
            // 
            // agreAdyac
            // 
            this.agreAdyac.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agreAdyac.Location = new System.Drawing.Point(25, 302);
            this.agreAdyac.Name = "agreAdyac";
            this.agreAdyac.Size = new System.Drawing.Size(176, 80);
            this.agreAdyac.TabIndex = 10;
            this.agreAdyac.Text = "Agregar Adyacencia";
            this.agreAdyac.UseVisualStyleBackColor = true;
            this.agreAdyac.Click += new System.EventHandler(this.agreAdyac_Click);
            // 
            // dibAdya
            // 
            this.dibAdya.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dibAdya.Location = new System.Drawing.Point(23, 466);
            this.dibAdya.Name = "dibAdya";
            this.dibAdya.Size = new System.Drawing.Size(176, 80);
            this.dibAdya.TabIndex = 11;
            this.dibAdya.Text = "Dibujar Adyacencia";
            this.dibAdya.UseVisualStyleBackColor = true;
            this.dibAdya.Click += new System.EventHandler(this.dibAdya_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 80);
            this.button1.TabIndex = 12;
            this.button1.Text = "Generar Documento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 701);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dibAdya);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numNodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNodoDestino)).EndInit();
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
        private System.Windows.Forms.Button dibAdya;
        private System.Windows.Forms.Button button1;
    }
}

