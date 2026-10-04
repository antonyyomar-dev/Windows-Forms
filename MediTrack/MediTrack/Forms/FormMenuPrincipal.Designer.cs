namespace MediTrack.Forms
{
    partial class FormMenuPrincipal
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
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.flpOpciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.btnJustificaciones = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnTurnos = new System.Windows.Forms.Button();
            this.btnJornadas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.flpOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(0, 105, 120);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(380, 80);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblUsuario);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(20, 10);
            this.lblTitulo.Text = "Menú principal";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(205, 235, 240);
            this.lblUsuario.Location = new System.Drawing.Point(22, 46);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // flpOpciones
            // 
            this.flpOpciones.AutoSize = true;
            this.flpOpciones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpOpciones.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOpciones.Location = new System.Drawing.Point(40, 100);
            this.flpOpciones.Size = new System.Drawing.Size(300, 368);
            this.flpOpciones.WrapContents = false;
            this.flpOpciones.TabIndex = 1;
            this.flpOpciones.Name = "flpOpciones";
            this.flpOpciones.Controls.Add(this.btnMarcar);
            this.flpOpciones.Controls.Add(this.btnJustificaciones);
            this.flpOpciones.Controls.Add(this.btnPersonal);
            this.flpOpciones.Controls.Add(this.btnTurnos);
            this.flpOpciones.Controls.Add(this.btnJornadas);
            this.flpOpciones.Controls.Add(this.btnReportes);
            this.flpOpciones.Controls.Add(this.btnAreas);
            this.flpOpciones.Controls.Add(this.btnCerrarSesion);
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnMarcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnMarcar.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnMarcar.Size = new System.Drawing.Size(300, 38);
            this.btnMarcar.Text = "Marcar asistencia";
            this.btnMarcar.UseVisualStyleBackColor = false;
            this.btnMarcar.FlatAppearance.BorderSize = 0;
            this.btnMarcar.TabIndex = 0;
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // btnJustificaciones
            // 
            this.btnJustificaciones.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnJustificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJustificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJustificaciones.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnJustificaciones.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnJustificaciones.Size = new System.Drawing.Size(300, 38);
            this.btnJustificaciones.Text = "Justificaciones";
            this.btnJustificaciones.UseVisualStyleBackColor = false;
            this.btnJustificaciones.FlatAppearance.BorderSize = 0;
            this.btnJustificaciones.TabIndex = 1;
            this.btnJustificaciones.Name = "btnJustificaciones";
            this.btnJustificaciones.Click += new System.EventHandler(this.btnJustificaciones_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonal.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnPersonal.Size = new System.Drawing.Size(300, 38);
            this.btnPersonal.Text = "Gestión de personal";
            this.btnPersonal.UseVisualStyleBackColor = false;
            this.btnPersonal.FlatAppearance.BorderSize = 0;
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnos.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnTurnos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnTurnos.Size = new System.Drawing.Size(300, 38);
            this.btnTurnos.Text = "Gestión de turnos";
            this.btnTurnos.UseVisualStyleBackColor = false;
            this.btnTurnos.FlatAppearance.BorderSize = 0;
            this.btnTurnos.TabIndex = 3;
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnJornadas
            // 
            this.btnJornadas.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnJornadas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJornadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJornadas.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnJornadas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnJornadas.Size = new System.Drawing.Size(300, 38);
            this.btnJornadas.Text = "Programar jornadas";
            this.btnJornadas.UseVisualStyleBackColor = false;
            this.btnJornadas.FlatAppearance.BorderSize = 0;
            this.btnJornadas.TabIndex = 4;
            this.btnJornadas.Name = "btnJornadas";
            this.btnJornadas.Click += new System.EventHandler(this.btnJornadas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnReportes.Size = new System.Drawing.Size(300, 38);
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.TabIndex = 5;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAreas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnAreas.Size = new System.Drawing.Size(300, 38);
            this.btnAreas.Text = "Gestión de áreas";
            this.btnAreas.UseVisualStyleBackColor = false;
            this.btnAreas.FlatAppearance.BorderSize = 0;
            this.btnAreas.TabIndex = 6;
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnCerrarSesion.Size = new System.Drawing.Size(300, 38);
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(380, 500);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.flpOpciones);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediTrack - Menú principal";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.flpOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.FlowLayoutPanel flpOpciones;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Button btnJustificaciones;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnTurnos;
        private System.Windows.Forms.Button btnJornadas;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
