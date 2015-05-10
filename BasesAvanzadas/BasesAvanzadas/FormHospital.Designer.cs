namespace BasesAvanzadas
{
    partial class FormHospital
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbHospital = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // tbHospital
            // 
            this.tbHospital.Location = new System.Drawing.Point(169, 76);
            this.tbHospital.Name = "tbHospital";
            this.tbHospital.Size = new System.Drawing.Size(246, 20);
            this.tbHospital.TabIndex = 2;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(169, 128);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(246, 20);
            this.tbDireccion.TabIndex = 3;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(339, 198);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 4;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.Hospital);
            // 
            // regresar
            // 
            this.regresar.Location = new System.Drawing.Point(169, 197);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(75, 23);
            this.regresar.TabIndex = 5;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = true;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // FormHospital
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 323);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbHospital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHospital";
            this.Text = "FormHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHospital;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button regresar;
    }
}