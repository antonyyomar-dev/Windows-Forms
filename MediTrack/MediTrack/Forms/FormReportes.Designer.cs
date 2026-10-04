namespace MediTrack.Forms
{
    partial class FormReportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblArea = new System.Windows.Forms.Label();
            this.cmbArea = new System.Windows.Forms.ComboBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.cmbPersonal = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabResumen = new System.Windows.Forms.TabPage();
            this.tabIncidencias = new System.Windows.Forms.TabPage();
            this.gridResumen = new System.Windows.Forms.DataGridView();
            this.gridIncidencias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridResumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncidencias)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabResumen.SuspendLayout();
            this.tabIncidencias.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(0, 105, 120);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(1020, 56);
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
            this.lblTitulo.Text = "Reportes de asistencia";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Name = "lblTitulo";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Location = new System.Drawing.Point(20, 70);
            this.gbFiltros.Size = new System.Drawing.Size(980, 115);
            this.gbFiltros.Text = "Filtros";
            this.gbFiltros.TabIndex = 1;
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Controls.Add(this.lblDesde);
            this.gbFiltros.Controls.Add(this.dtpDesde);
            this.gbFiltros.Controls.Add(this.lblHasta);
            this.gbFiltros.Controls.Add(this.dtpHasta);
            this.gbFiltros.Controls.Add(this.lblArea);
            this.gbFiltros.Controls.Add(this.cmbArea);
            this.gbFiltros.Controls.Add(this.lblPersonal);
            this.gbFiltros.Controls.Add(this.cmbPersonal);
            this.gbFiltros.Controls.Add(this.btnGenerar);
            this.gbFiltros.Controls.Add(this.btnGraficos);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(15, 33);
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Name = "lblDesde";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(70, 30);
            this.dtpDesde.Size = new System.Drawing.Size(115, 26);
            this.dtpDesde.TabIndex = 1;
            this.dtpDesde.Name = "dtpDesde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(205, 33);
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Name = "lblHasta";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(260, 30);
            this.dtpHasta.Size = new System.Drawing.Size(115, 26);
            this.dtpHasta.TabIndex = 3;
            this.dtpHasta.Name = "dtpHasta";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(395, 33);
            this.lblArea.Text = "Área:";
            this.lblArea.TabIndex = 4;
            this.lblArea.Name = "lblArea";
            // 
            // cmbArea
            // 
            this.cmbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.Location = new System.Drawing.Point(440, 30);
            this.cmbArea.Size = new System.Drawing.Size(170, 26);
            this.cmbArea.TabIndex = 5;
            this.cmbArea.Name = "cmbArea";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(630, 33);
            this.lblPersonal.Text = "Trabajador:";
            this.lblPersonal.TabIndex = 6;
            this.lblPersonal.Name = "lblPersonal";
            // 
            // cmbPersonal
            // 
            this.cmbPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonal.FormattingEnabled = true;
            this.cmbPersonal.Location = new System.Drawing.Point(715, 30);
            this.cmbPersonal.Size = new System.Drawing.Size(250, 26);
            this.cmbPersonal.TabIndex = 7;
            this.cmbPersonal.Name = "cmbPersonal";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            this.btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGenerar.Location = new System.Drawing.Point(15, 70);
            this.btnGenerar.Size = new System.Drawing.Size(110, 32);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnGraficos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraficos.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.btnGraficos.Location = new System.Drawing.Point(135, 70);
            this.btnGraficos.Size = new System.Drawing.Size(120, 32);
            this.btnGraficos.Text = "Ver gráficos";
            this.btnGraficos.UseVisualStyleBackColor = false;
            this.btnGraficos.FlatAppearance.BorderSize = 0;
            this.btnGraficos.TabIndex = 9;
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Click += new System.EventHandler(this.btnGraficos_Click);
            // 
            // tabs
            // 
            this.tabs.Location = new System.Drawing.Point(20, 200);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(980, 450);
            this.tabs.TabIndex = 2;
            this.tabs.Name = "tabs";
            this.tabs.Controls.Add(this.tabResumen);
            this.tabs.Controls.Add(this.tabIncidencias);
            // 
            // tabResumen
            // 
            this.tabResumen.Location = new System.Drawing.Point(4, 26);
            this.tabResumen.Padding = new System.Windows.Forms.Padding(3);
            this.tabResumen.Size = new System.Drawing.Size(972, 420);
            this.tabResumen.Text = "Resumen de asistencia";
            this.tabResumen.UseVisualStyleBackColor = true;
            this.tabResumen.Name = "tabResumen";
            this.tabResumen.Controls.Add(this.gridResumen);
            // 
            // tabIncidencias
            // 
            this.tabIncidencias.Location = new System.Drawing.Point(4, 26);
            this.tabIncidencias.Padding = new System.Windows.Forms.Padding(3);
            this.tabIncidencias.Size = new System.Drawing.Size(972, 420);
            this.tabIncidencias.Text = "Incidencias diarias";
            this.tabIncidencias.UseVisualStyleBackColor = true;
            this.tabIncidencias.Name = "tabIncidencias";
            this.tabIncidencias.Controls.Add(this.gridIncidencias);
            // 
            // gridResumen
            // 
            this.gridResumen.AllowUserToAddRows = false;
            this.gridResumen.AllowUserToDeleteRows = false;
            this.gridResumen.AllowUserToResizeRows = false;
            this.gridResumen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResumen.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.gridResumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridResumen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResumen.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridResumen.EnableHeadersVisualStyles = false;
            this.gridResumen.MultiSelect = false;
            this.gridResumen.ReadOnly = true;
            this.gridResumen.RowHeadersVisible = false;
            this.gridResumen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridResumen.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.gridResumen.TabIndex = 0;
            this.gridResumen.Name = "gridResumen";
            // 
            // gridIncidencias
            // 
            this.gridIncidencias.AllowUserToAddRows = false;
            this.gridIncidencias.AllowUserToDeleteRows = false;
            this.gridIncidencias.AllowUserToResizeRows = false;
            this.gridIncidencias.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridIncidencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIncidencias.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.gridIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridIncidencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridIncidencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridIncidencias.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridIncidencias.EnableHeadersVisualStyles = false;
            this.gridIncidencias.MultiSelect = false;
            this.gridIncidencias.ReadOnly = true;
            this.gridIncidencias.RowHeadersVisible = false;
            this.gridIncidencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIncidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(0, 128, 145);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(238, 247, 248);
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(33, 37, 41);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(178, 223, 230);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(0, 0, 0);
            this.gridIncidencias.TabIndex = 0;
            this.gridIncidencias.Name = "gridIncidencias";
            // 
            // FormReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            this.ClientSize = new System.Drawing.Size(1020, 670);
            this.Controls.Add(this.pnlEncabezado);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediTrack - Reportes";
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabResumen.ResumeLayout(false);
            this.tabIncidencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridIncidencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ComboBox cmbArea;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.ComboBox cmbPersonal;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabResumen;
        private System.Windows.Forms.TabPage tabIncidencias;
        private System.Windows.Forms.DataGridView gridResumen;
        private System.Windows.Forms.DataGridView gridIncidencias;
    }
}
