namespace BasesAvanzadas
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
            this.altas = new System.Windows.Forms.Button();
            this.bajas = new System.Windows.Forms.Button();
            this.cambio = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // altas
            // 
            this.altas.Location = new System.Drawing.Point(232, 100);
            this.altas.Name = "altas";
            this.altas.Size = new System.Drawing.Size(75, 23);
            this.altas.TabIndex = 0;
            this.altas.Text = "Altas";
            this.altas.UseVisualStyleBackColor = true;
            this.altas.Click += new System.EventHandler(this.altas_Click);
            // 
            // bajas
            // 
            this.bajas.Location = new System.Drawing.Point(232, 223);
            this.bajas.Name = "bajas";
            this.bajas.Size = new System.Drawing.Size(75, 23);
            this.bajas.TabIndex = 1;
            this.bajas.Text = "Bajas";
            this.bajas.UseVisualStyleBackColor = true;
            // 
            // cambio
            // 
            this.cambio.Location = new System.Drawing.Point(232, 331);
            this.cambio.Name = "cambio";
            this.cambio.Size = new System.Drawing.Size(75, 23);
            this.cambio.TabIndex = 2;
            this.cambio.Text = "Cambio";
            this.cambio.UseVisualStyleBackColor = true;
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(47, 45);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(75, 23);
            this.regresar.TabIndex = 3;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(577, 458);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.cambio);
            this.Controls.Add(this.bajas);
            this.Controls.Add(this.altas);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button altas;
        private System.Windows.Forms.Button bajas;
        private System.Windows.Forms.Button cambio;
        private System.Windows.Forms.Button regresar;
    }
}