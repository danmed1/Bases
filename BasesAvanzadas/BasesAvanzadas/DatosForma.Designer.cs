namespace BasesAvanzadas
{
    partial class DatosForma
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.modificarDatosBoton = new System.Windows.Forms.Button();
            this.regresarMenuContextPacienteBoton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.guardarModificadosBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.guardarModificadosBoton);
            this.splitContainer1.Panel1.Controls.Add(this.regresarMenuContextPacienteBoton);
            this.splitContainer1.Panel1.Controls.Add(this.modificarDatosBoton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(657, 435);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 0;
            // 
            // modificarDatosBoton
            // 
            this.modificarDatosBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarDatosBoton.Location = new System.Drawing.Point(38, 91);
            this.modificarDatosBoton.Name = "modificarDatosBoton";
            this.modificarDatosBoton.Size = new System.Drawing.Size(134, 31);
            this.modificarDatosBoton.TabIndex = 0;
            this.modificarDatosBoton.Text = "Modificar";
            this.modificarDatosBoton.UseVisualStyleBackColor = true;
            this.modificarDatosBoton.Click += new System.EventHandler(this.modificarDatosBoton_Click);
            // 
            // regresarMenuContextPacienteBoton
            // 
            this.regresarMenuContextPacienteBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuContextPacienteBoton.Location = new System.Drawing.Point(38, 262);
            this.regresarMenuContextPacienteBoton.Name = "regresarMenuContextPacienteBoton";
            this.regresarMenuContextPacienteBoton.Size = new System.Drawing.Size(134, 33);
            this.regresarMenuContextPacienteBoton.TabIndex = 1;
            this.regresarMenuContextPacienteBoton.Text = "Regresar";
            this.regresarMenuContextPacienteBoton.UseVisualStyleBackColor = true;
            this.regresarMenuContextPacienteBoton.Click += new System.EventHandler(this.regresarMenuContextPacienteBoton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(294, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // guardarModificadosBoton
            // 
            this.guardarModificadosBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarModificadosBoton.Location = new System.Drawing.Point(38, 172);
            this.guardarModificadosBoton.Name = "guardarModificadosBoton";
            this.guardarModificadosBoton.Size = new System.Drawing.Size(134, 35);
            this.guardarModificadosBoton.TabIndex = 2;
            this.guardarModificadosBoton.Text = "Guardar";
            this.guardarModificadosBoton.UseVisualStyleBackColor = true;
            // 
            // DatosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 435);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DatosForma";
            this.Text = "Datos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button regresarMenuContextPacienteBoton;
        private System.Windows.Forms.Button modificarDatosBoton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button guardarModificadosBoton;
    }
}