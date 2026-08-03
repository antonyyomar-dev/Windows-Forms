namespace Lab01_Introducción_a_WF
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_abrirf1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Este es mi segundo formulario";
            // 
            // btn_abrirf1
            // 
            this.btn_abrirf1.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_abrirf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrirf1.Location = new System.Drawing.Point(259, 239);
            this.btn_abrirf1.Name = "btn_abrirf1";
            this.btn_abrirf1.Size = new System.Drawing.Size(245, 52);
            this.btn_abrirf1.TabIndex = 1;
            this.btn_abrirf1.Text = "Abrir Form 1";
            this.btn_abrirf1.UseVisualStyleBackColor = false;
            this.btn_abrirf1.Click += new System.EventHandler(this.btn_abrirf1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_abrirf1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_abrirf1;
    }
}