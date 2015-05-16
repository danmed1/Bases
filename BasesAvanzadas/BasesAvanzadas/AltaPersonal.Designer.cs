namespace BasesAvanzadas
{
    partial class AltaPersonal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApPat = new System.Windows.Forms.TextBox();
            this.tbApMat = new System.Windows.Forms.TextBox();
            this.tbCedula = new System.Windows.Forms.TextBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.bGuardar = new System.Windows.Forms.Button();
            this.regresarMenuPaciente = new System.Windows.Forms.Button();
            this.cbPerfil = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido materno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cédula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hospital";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Especialidad";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(270, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(191, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // tbApPat
            // 
            this.tbApPat.Location = new System.Drawing.Point(270, 70);
            this.tbApPat.Name = "tbApPat";
            this.tbApPat.Size = new System.Drawing.Size(191, 20);
            this.tbApPat.TabIndex = 7;
            // 
            // tbApMat
            // 
            this.tbApMat.Location = new System.Drawing.Point(270, 111);
            this.tbApMat.Name = "tbApMat";
            this.tbApMat.Size = new System.Drawing.Size(191, 20);
            this.tbApMat.TabIndex = 8;
            this.tbApMat.TextChanged += new System.EventHandler(this.tbApMat_TextChanged);
            // 
            // tbCedula
            // 
            this.tbCedula.Location = new System.Drawing.Point(270, 154);
            this.tbCedula.Name = "tbCedula";
            this.tbCedula.Size = new System.Drawing.Size(191, 20);
            this.tbCedula.TabIndex = 9;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(270, 234);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(191, 21);
            this.cbEspecialidad.TabIndex = 11;
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(270, 417);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 12;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.Profesional);
            // 
            // regresarMenuPaciente
            // 
            this.regresarMenuPaciente.Location = new System.Drawing.Point(86, 417);
            this.regresarMenuPaciente.Name = "regresarMenuPaciente";
            this.regresarMenuPaciente.Size = new System.Drawing.Size(75, 23);
            this.regresarMenuPaciente.TabIndex = 13;
            this.regresarMenuPaciente.Text = "Regresar";
            this.regresarMenuPaciente.UseVisualStyleBackColor = true;
            this.regresarMenuPaciente.Click += new System.EventHandler(this.regresarMenuPaciente_Click);
            // 
            // cbPerfil
            // 
            this.cbPerfil.FormattingEnabled = true;
            this.cbPerfil.Location = new System.Drawing.Point(270, 196);
            this.cbPerfil.Name = "cbPerfil";
            this.cbPerfil.Size = new System.Drawing.Size(191, 21);
            this.cbPerfil.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre Usuario";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(270, 285);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(191, 20);
            this.textBoxUsername.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(270, 351);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(191, 20);
            this.textBoxPassword.TabIndex = 17;
            // 
            // AltaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 484);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.regresarMenuPaciente);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.cbEspecialidad);
            this.Controls.Add(this.cbPerfil);
            this.Controls.Add(this.tbCedula);
            this.Controls.Add(this.tbApMat);
            this.Controls.Add(this.tbApPat);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaPersonal";
            this.Text = "Alta Personal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApPat;
        private System.Windows.Forms.TextBox tbApMat;
        private System.Windows.Forms.TextBox tbCedula;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button regresarMenuPaciente;
        private System.Windows.Forms.ComboBox cbPerfil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}