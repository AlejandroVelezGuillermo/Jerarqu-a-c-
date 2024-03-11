namespace CSV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aGREGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUARDARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARToolStripMenuItem,
            this.gUARDARToolStripMenuItem,
            this.aBRIRToolStripMenuItem,
            this.eDITARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1579, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aGREGARToolStripMenuItem
            // 
            this.aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            this.aGREGARToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.aGREGARToolStripMenuItem.Text = "AGREGAR";
            this.aGREGARToolStripMenuItem.Click += new System.EventHandler(this.aGREGARToolStripMenuItem_Click);
            // 
            // gUARDARToolStripMenuItem
            // 
            this.gUARDARToolStripMenuItem.Name = "gUARDARToolStripMenuItem";
            this.gUARDARToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.gUARDARToolStripMenuItem.Text = "GUARDAR";
            this.gUARDARToolStripMenuItem.Click += new System.EventHandler(this.gUARDARToolStripMenuItem_Click);
            // 
            // aBRIRToolStripMenuItem
            // 
            this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
            this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aBRIRToolStripMenuItem.Text = "ABRIR";
            this.aBRIRToolStripMenuItem.Click += new System.EventHandler(this.aBRIRToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(13, 164);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(775, 294);
            this.dgvDatos.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(77, 66);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(272, 22);
            this.txtTelefono.TabIndex = 3;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(77, 94);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(272, 22);
            this.txtCorreo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correo:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre Del Archivo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "csv",
            "txt",
            "xml",
            "json"});
            this.comboBox1.Location = new System.Drawing.Point(631, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(56, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ruta Del Archivo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Asistencia:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Asistio",
            "No Asistio"});
            this.comboBox2.Location = new System.Drawing.Point(88, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 24);
            this.comboBox2.TabIndex = 15;
            // 
            // chart1
            // 
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(812, 22);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(755, 416);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Random";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(355, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Random";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(812, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(767, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "ACTUALIZAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 470);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aGREGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUARDARToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

