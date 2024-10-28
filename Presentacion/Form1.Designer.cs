namespace Presentacion
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
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtDescripcion = new TextBox();
            txtDuracion = new NumericUpDown();
            txtEdadRecomendada = new NumericUpDown();
            txtTitulo = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvPeliculas = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEdadRecomendada).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnInsertar);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtDuracion);
            groupBox1.Controls.Add(txtEdadRecomendada);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 42);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(427, 346);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nueva Película";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(312, 297);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 27);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(146, 298);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(88, 27);
            btnInsertar.TabIndex = 20;
            btnInsertar.Text = "Añadir";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(146, 158);
            txtDescripcion.Margin = new Padding(4, 3, 4, 3);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(254, 131);
            txtDescripcion.TabIndex = 19;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(146, 80);
            txtDuracion.Margin = new Padding(4, 3, 4, 3);
            txtDuracion.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(140, 23);
            txtDuracion.TabIndex = 18;
            // 
            // txtEdadRecomendada
            // 
            txtEdadRecomendada.Location = new Point(146, 119);
            txtEdadRecomendada.Margin = new Padding(4, 3, 4, 3);
            txtEdadRecomendada.Name = "txtEdadRecomendada";
            txtEdadRecomendada.Size = new Size(140, 23);
            txtEdadRecomendada.TabIndex = 17;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(146, 42);
            txtTitulo.Margin = new Padding(4, 3, 4, 3);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(254, 23);
            txtTitulo.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 82);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 15;
            label6.Text = "Minutos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 121);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 14;
            label5.Text = "Años";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 13;
            label4.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 12;
            label3.Text = "Edad recomendada:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 82);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Duración:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 10;
            label1.Text = "Título:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvPeliculas);
            groupBox2.Location = new Point(479, 42);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(427, 346);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cartelera de Cine";
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeliculas.Location = new Point(8, 42);
            dgvPeliculas.Margin = new Padding(4, 3, 4, 3);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.Size = new Size(411, 283);
            dgvPeliculas.TabIndex = 0;
            dgvPeliculas.CellClick += onClickCell;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(932, 417);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEdadRecomendada).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown txtDuracion;
        private System.Windows.Forms.NumericUpDown txtEdadRecomendada;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPeliculas;
    }
}
