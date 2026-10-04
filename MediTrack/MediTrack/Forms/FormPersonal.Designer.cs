namespace MediTrack.Forms
{
    partial class FormPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnAsignarTurno = new System.Windows.Forms.Button();
            this.btnCambiarClave = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.errores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(0, 105, 120);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(980, 56);
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
            this.lblTitulo.Text = "Gestión de personal";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // gbDatos
            // 
            this.gbDatos.Location = new System.Drawing.Point(20, 70);
            this.gbDatos.Size = new System.Drawing.Size(940, 150);
            this.gbDatos.Text = "Datos del trabajador";
            this.gbDatos.TabIndex = 1;
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblNombres);
            this.gbDatos.Controls.Add(this.txtNombres);
            this.gbDatos.Controls.Add(this.lblApellidos);
            this.gbDatos.Controls.Add(this.txtApellidos);
            this.gbDatos.Controls.Add(this.lblUsuario);
            this.gbDatos.Controls.Add(this.txtUsuario);
            this.gbDatos.Controls.Add(this.lblClave);
            this.gbDatos.Controls.Add(this.txtClave);
            this.gbDatos.Controls.Add(this.lblRol);
            this.gbDatos.Controls.Add(this.cmbRol);
            this.gbDatos.Controls.Add(this.lblArea);
            this.gbDatos.Controls.Add(this.cmbArea);
            this.gbDatos.Controls.Add(this.lblTurno);
            this.gbDatos.Controls.Add(this.cmbTurno);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 33);
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Name = "lblCodigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 30);
            this.txtCodigo.Size = new System.Drawing.Size(200, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Name = "txtCodigo";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(15, 69);
            this.lblNombres.Text = "Nombres:";
            this.lblNombres.TabIndex = 2;
            this.lblNombres.Name = "lblNombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(100, 66);
            this.txtNombres.Size = new System.Drawing.Size(200, 26);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.Name = "txtNombres";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(15, 105);
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Name = "lblApellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(100, 102);
            this.txtApellidos.Size = new System.Drawing.Size(200, 26);
            this.txtApellidos.TabIndex = 5;
            this.txtApellidos.Name = "txtApellidos";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(335, 33);
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(425, 30);
            this.txtUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtUsuario.TabIndex = 7;
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(335, 69);
            this.lblClave.Text = "Contraseña:";
            this.lblClave.TabIndex = 8;
            this.lblClave.Name = "lblClave";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(425, 66);
            this.txtClave.Size = new System.Drawing.Size(200, 26);
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TabIndex = 9;
            this.txtClave.Name = "txtClave";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(335, 105);
            this.lblRol.Text = "Rol:";
            this.lblRol.TabIndex = 10;
            this.lblRol.Name = "lblRol";
            // 
            // cmbRol
            // 
            this.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(425, 102);
            this.cmbRol.Size = new System.Drawing.Size(200, 26);
            this.cmbRol.TabIndex = 11;
            this.cmbRol.Name = "cmbRol";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(655, 33);
            this.lblArea.Text = "Área:";
            this.lblArea.TabIndex = 12;
            this.lblArea.Name = "lblArea";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(725, 30);
            this.cmbArea.Size = new System.Drawing.Size(195, 26);
            this.cmbArea.TabIndex = 13;
            this.cmbArea.Name = "cmbArea";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(655, 69);
            this.lblTurno.Text = "Turno:";
            this.lblTurno.TabIndex = 14;
            this.lblTurno.Name = "lblTurno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(725, 66);
            this.cmbTurno.Size = new System.Drawing.Size(195, 26);
            this.cmbTurno.TabIndex = 15;
            this.cmbTurno.Name = "cmbTurno";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnRegistrar.Location = new System.Drawing.Point(20, 232);
            this.btnRegistrar.Size = new System.Drawing.Size(110, 32);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnModificar.Location = new System.Drawing.Point(140, 232);
            this.btnModificar.Size = new System.Drawing.Size(110, 32);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.btnDesactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnDesactivar.Location = new System.Drawing.Point(260, 232);
            this.btnDesactivar.Size = new System.Drawing.Size(110, 32);
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.TabIndex = 4;
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnAsignarTurno
            // 
            this.btnAsignarTurno.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnAsignarTurno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsignarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTurno.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnAsignarTurno.Location = new System.Drawing.Point(380, 232);
            this.btnAsignarTurno.Size = new System.Drawing.Size(125, 32);
            this.btnAsignarTurno.Text = "Asignar turno";
            this.btnAsignarTurno.UseVisualStyleBackColor = false;
            this.btnAsignarTurno.FlatAppearance.BorderSize = 0;
            this.btnAsignarTurno.TabIndex = 5;
            this.btnAsignarTurno.Name = "btnAsignarTurno";
            this.btnAsignarTurno.Click += new System.EventHandler(this.btnAsignarTurno_Click);
            // 
            // btnCambiarClave
            // 
            this.btnCambiarClave.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnCambiarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarClave.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnCambiarClave.Location = new System.Drawing.Point(515, 232);
            this.btnCambiarClave.Size = new System.Drawing.Size(160, 32);
            this.btnCambiarClave.Text = "Cambiar contraseña";
            this.btnCambiarClave.UseVisualStyleBackColor = false;
            this.btnCambiarClave.FlatAppearance.BorderSize = 0;
            this.btnCambiarClave.TabIndex = 6;
            this.btnCambiarClave.Name = "btnCambiarClave";
            this.btnCambiarClave.Click += new System.EventHandler(this.btnCambiarClave_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnLimpiar.Location = new System.Drawing.Point(685, 232);
            this.btnLimpiar.Size = new System.Drawing.Size(90, 32);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(20, 285);
            this.lblBuscar.Text = "Buscar (código o nombre):";
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Name = "lblBuscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(195, 282);
            this.txtBuscar.Size = new System.Drawing.Size(220, 26);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.Name = "txtBuscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnBuscar.Location = new System.Drawing.Point(425, 280);
            this.btnBuscar.Size = new System.Drawing.Size(90, 32);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnVerTodos.Location = new System.Drawing.Point(525, 280);
            this.btnVerTodos.Size = new System.Drawing.Size(100, 32);
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.TabIndex = 11;
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // grid
            // 
            this.grid.Location = new System.Drawing.Point(20, 325);
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.MultiSelect = false;
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(940, 335);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(238, 247, 248);
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(178, 223, 230);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.grid.TabIndex = 12;
            this.grid.Name = "grid";
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // errores
            // 
            this.errores.ContainerControl = this;
            // 
            // FormPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(980, 680);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnAsignarTurno);
            this.Controls.Add(this.btnCambiarClave);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.grid);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediTrack - Gestión de personal";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnAsignarTurno;
        private System.Windows.Forms.Button btnCambiarClave;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ErrorProvider errores;
    }
}
