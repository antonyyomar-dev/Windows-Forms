namespace Lab03
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgAtenciones = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTotalServicio1 = new System.Windows.Forms.Label();
            this.lbTotalServicio2 = new System.Windows.Forms.Label();
            this.lbTotalServicio3 = new System.Windows.Forms.Label();
            this.lbPromedioServicio1 = new System.Windows.Forms.Label();
            this.lbServicioMenorD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Vehículo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Servicio: ";
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "A",
            "C"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(236, 31);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(223, 24);
            this.cbTipoVehiculo.TabIndex = 2;
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTipoServicio.Location = new System.Drawing.Point(697, 31);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(191, 24);
            this.cbTipoServicio.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(361, 89);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(229, 56);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgAtenciones
            // 
            this.dgAtenciones.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtenciones.Location = new System.Drawing.Point(53, 160);
            this.dgAtenciones.Name = "dgAtenciones";
            this.dgAtenciones.RowHeadersWidth = 51;
            this.dgAtenciones.RowTemplate.Height = 24;
            this.dgAtenciones.Size = new System.Drawing.Size(835, 189);
            this.dgAtenciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Servicio 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Servicio 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Servicio 3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(306, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Promedio Servicio 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(569, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(276, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Servicio con Menor Demanda:";
            // 
            // lbTotalServicio1
            // 
            this.lbTotalServicio1.AutoSize = true;
            this.lbTotalServicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalServicio1.Location = new System.Drawing.Point(231, 381);
            this.lbTotalServicio1.Name = "lbTotalServicio1";
            this.lbTotalServicio1.Size = new System.Drawing.Size(23, 25);
            this.lbTotalServicio1.TabIndex = 11;
            this.lbTotalServicio1.Text = "0";
            // 
            // lbTotalServicio2
            // 
            this.lbTotalServicio2.AutoSize = true;
            this.lbTotalServicio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalServicio2.Location = new System.Drawing.Point(231, 430);
            this.lbTotalServicio2.Name = "lbTotalServicio2";
            this.lbTotalServicio2.Size = new System.Drawing.Size(23, 25);
            this.lbTotalServicio2.TabIndex = 12;
            this.lbTotalServicio2.Text = "0";
            // 
            // lbTotalServicio3
            // 
            this.lbTotalServicio3.AutoSize = true;
            this.lbTotalServicio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalServicio3.Location = new System.Drawing.Point(465, 381);
            this.lbTotalServicio3.Name = "lbTotalServicio3";
            this.lbTotalServicio3.Size = new System.Drawing.Size(23, 25);
            this.lbTotalServicio3.TabIndex = 13;
            this.lbTotalServicio3.Text = "0";
            // 
            // lbPromedioServicio1
            // 
            this.lbPromedioServicio1.AutoSize = true;
            this.lbPromedioServicio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPromedioServicio1.Location = new System.Drawing.Point(518, 430);
            this.lbPromedioServicio1.Name = "lbPromedioServicio1";
            this.lbPromedioServicio1.Size = new System.Drawing.Size(23, 25);
            this.lbPromedioServicio1.TabIndex = 14;
            this.lbPromedioServicio1.Text = "0";
            // 
            // lbServicioMenorD
            // 
            this.lbServicioMenorD.AutoSize = true;
            this.lbServicioMenorD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServicioMenorD.Location = new System.Drawing.Point(851, 381);
            this.lbServicioMenorD.Name = "lbServicioMenorD";
            this.lbServicioMenorD.Size = new System.Drawing.Size(19, 25);
            this.lbServicioMenorD.TabIndex = 15;
            this.lbServicioMenorD.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 496);
            this.Controls.Add(this.lbServicioMenorD);
            this.Controls.Add(this.lbPromedioServicio1);
            this.Controls.Add(this.lbTotalServicio3);
            this.Controls.Add(this.lbTotalServicio2);
            this.Controls.Add(this.lbTotalServicio1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgAtenciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.cbTipoVehiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Atenciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoVehiculo;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgAtenciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTotalServicio1;
        private System.Windows.Forms.Label lbTotalServicio2;
        private System.Windows.Forms.Label lbTotalServicio3;
        private System.Windows.Forms.Label lbPromedioServicio1;
        private System.Windows.Forms.Label lbServicioMenorD;
    }
}

