namespace Lab02
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnProcesarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.nuMinutosTardanza = new System.Windows.Forms.NumericUpDown();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinutosTardanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinutosTardanza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(129, 33);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(211, 30);
            this.tbNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(387, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minutos Tardanza: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoría: ";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbCategoria.Location = new System.Drawing.Point(142, 115);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(207, 33);
            this.cbCategoria.TabIndex = 5;
            // 
            // btnProcesarEmpleado
            // 
            this.btnProcesarEmpleado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProcesarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarEmpleado.Location = new System.Drawing.Point(471, 108);
            this.btnProcesarEmpleado.Name = "btnProcesarEmpleado";
            this.btnProcesarEmpleado.Size = new System.Drawing.Size(224, 45);
            this.btnProcesarEmpleado.TabIndex = 6;
            this.btnProcesarEmpleado.Text = "Procesar Empleado";
            this.btnProcesarEmpleado.UseVisualStyleBackColor = false;
            this.btnProcesarEmpleado.Click += new System.EventHandler(this.btnProcesarEmpleado_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Categoría,
            this.MinutosTardanza,
            this.Pago});
            this.dgvEmpleados.Location = new System.Drawing.Point(36, 194);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.Size = new System.Drawing.Size(746, 186);
            this.dgvEmpleados.TabIndex = 7;
            // 
            // nuMinutosTardanza
            // 
            this.nuMinutosTardanza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuMinutosTardanza.Location = new System.Drawing.Point(574, 28);
            this.nuMinutosTardanza.Name = "nuMinutosTardanza";
            this.nuMinutosTardanza.Size = new System.Drawing.Size(151, 30);
            this.nuMinutosTardanza.TabIndex = 8;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Categoría
            // 
            this.Categoría.HeaderText = "Categoría";
            this.Categoría.MinimumWidth = 6;
            this.Categoría.Name = "Categoría";
            this.Categoría.Width = 125;
            // 
            // MinutosTardanza
            // 
            this.MinutosTardanza.HeaderText = "MinutosTardanza";
            this.MinutosTardanza.MinimumWidth = 6;
            this.MinutosTardanza.Name = "MinutosTardanza";
            this.MinutosTardanza.Width = 125;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.MinimumWidth = 6;
            this.Pago.Name = "Pago";
            this.Pago.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nuMinutosTardanza);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.btnProcesarEmpleado);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuMinutosTardanza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnProcesarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.NumericUpDown nuMinutosTardanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinutosTardanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
    }
}

