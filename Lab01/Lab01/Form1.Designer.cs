namespace Lab01
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
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.lblForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMensaje.Location = new System.Drawing.Point(295, 166);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(177, 58);
            this.btnEnviarMensaje.TabIndex = 0;
            this.btnEnviarMensaje.Text = "Enviar Mensaje";
            this.btnEnviarMensaje.UseVisualStyleBackColor = false;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.Location = new System.Drawing.Point(27, 42);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(348, 25);
            this.lblForm.TabIndex = 1;
            this.lblForm.Text = "BIENVENIDO AL FORMULARIO 1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Name = "Form1";
            this.Text = "Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviarMensaje;
        private System.Windows.Forms.Label lblForm;
    }
}

