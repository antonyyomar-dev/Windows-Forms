namespace MediTrack.Forms
{
    partial class FormMarcacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que se estén usando.
        /// </summary>
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
            this.components = new System.ComponentModel.Container();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(0, 105, 120);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(440, 56);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(20, 12);
            this.lblTitulo.Text = "Marcación de asistencia";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = false;
            this.lblReloj.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.ForeColor = System.Drawing.Color.FromArgb(0, 105, 120);
            this.lblReloj.Location = new System.Drawing.Point(0, 72);
            this.lblReloj.Size = new System.Drawing.Size(440, 52);
            this.lblReloj.Text = "00:00:00";
            this.lblReloj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblReloj.TabIndex = 1;
            this.lblReloj.Name = "lblReloj";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = false;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.lblFecha.Location = new System.Drawing.Point(0, 124);
            this.lblFecha.Size = new System.Drawing.Size(440, 24);
            this.lblFecha.Text = "fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Name = "lblFecha";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(60, 168);
            this.lblCodigo.Text = "Código del trabajador";
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Name = "lblCodigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(60, 190);
            this.txtCodigo.Size = new System.Drawing.Size(320, 26);
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.Name = "txtCodigo";
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(39, 140, 90);
            this.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnIngreso.Location = new System.Drawing.Point(60, 238);
            this.btnIngreso.Size = new System.Drawing.Size(155, 38);
            this.btnIngreso.Text = "Registrar ingreso";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.TabIndex = 5;
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(214, 125, 30);
            this.btnSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnSalida.Location = new System.Drawing.Point(225, 238);
            this.btnSalida.Size = new System.Drawing.Size(155, 38);
            this.btnSalida.Text = "Registrar salida";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.TabIndex = 6;
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = false;
            this.lblMensaje.Location = new System.Drawing.Point(30, 292);
            this.lblMensaje.Size = new System.Drawing.Size(380, 50);
            this.lblMensaje.Text = "";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.Name = "lblMensaje";
            // 
            // reloj
            // 
            this.reloj.Interval = 1000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // FormMarcacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(440, 360);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.lblMensaje);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMarcacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediTrack - Marcación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMarcacion_FormClosed);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer reloj;
    }
}
