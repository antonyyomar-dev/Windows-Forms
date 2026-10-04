namespace MediTrack.Forms
{
    partial class FormLogin
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuarioTxt = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.pnlEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(0, 105, 120);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(380, 100);
            this.pnlEncabezado.TabIndex = 0;
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Controls.Add(this.lblTitulo);
            this.pnlEncabezado.Controls.Add(this.lblSubtitulo);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = false;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.lblTitulo.Location = new System.Drawing.Point(0, 14);
            this.lblTitulo.Size = new System.Drawing.Size(380, 42);
            this.lblTitulo.Text = "MediTrack";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = false;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(205, 235, 240);
            this.lblSubtitulo.Location = new System.Drawing.Point(0, 58);
            this.lblSubtitulo.Size = new System.Drawing.Size(380, 24);
            this.lblSubtitulo.Text = "Control de asistencia del personal";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Name = "lblSubtitulo";
            // 
            // lblUsuarioTxt
            // 
            this.lblUsuarioTxt.AutoSize = true;
            this.lblUsuarioTxt.Location = new System.Drawing.Point(40, 128);
            this.lblUsuarioTxt.Text = "Usuario";
            this.lblUsuarioTxt.TabIndex = 1;
            this.lblUsuarioTxt.Name = "lblUsuarioTxt";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(40, 148);
            this.txtUsuario.Size = new System.Drawing.Size(300, 26);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(40, 188);
            this.lblClave.Text = "Contraseña";
            this.lblClave.TabIndex = 3;
            this.lblClave.Name = "lblClave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(40, 208);
            this.txtClave.Size = new System.Drawing.Size(300, 26);
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TabIndex = 4;
            this.txtClave.Name = "txtClave";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnIngresar.Location = new System.Drawing.Point(40, 262);
            this.btnIngresar.Size = new System.Drawing.Size(300, 38);
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnMarcar
            // 
            this.btnMarcar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnMarcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnMarcar.Location = new System.Drawing.Point(40, 308);
            this.btnMarcar.Size = new System.Drawing.Size(300, 38);
            this.btnMarcar.Text = "Marcar asistencia";
            this.btnMarcar.UseVisualStyleBackColor = false;
            this.btnMarcar.FlatAppearance.BorderSize = 0;
            this.btnMarcar.TabIndex = 6;
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(380, 360);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.lblUsuarioTxt);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnMarcar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediTrack - Inicio de sesión";
            this.AcceptButton = this.btnIngresar;
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuarioTxt;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnMarcar;
    }
}
