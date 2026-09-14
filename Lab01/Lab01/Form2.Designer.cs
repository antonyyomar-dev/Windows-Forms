namespace Lab01
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
            this.btnFormulario1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormulario1
            // 
            this.btnFormulario1.BackColor = System.Drawing.Color.Green;
            this.btnFormulario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormulario1.Location = new System.Drawing.Point(462, 150);
            this.btnFormulario1.Name = "btnFormulario1";
            this.btnFormulario1.Size = new System.Drawing.Size(248, 55);
            this.btnFormulario1.TabIndex = 0;
            this.btnFormulario1.Text = "Abrir FORM 1";
            this.btnFormulario1.UseVisualStyleBackColor = false;
            this.btnFormulario1.Click += new System.EventHandler(this.btnFormulario1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab01.Properties.Resources.descarga1;
            this.pictureBox1.Location = new System.Drawing.Point(39, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFormulario1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormulario1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}