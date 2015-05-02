namespace BasesAvanzadas
{
    partial class HospitalForma
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
            this.modificarHospitalesBoton = new System.Windows.Forms.Button();
            this.guardarHospitalBoton = new System.Windows.Forms.Button();
            this.regresarMenuHospitalBoton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.splitContainer1.Panel1.Controls.Add(this.regresarMenuHospitalBoton);
            this.splitContainer1.Panel1.Controls.Add(this.guardarHospitalBoton);
            this.splitContainer1.Panel1.Controls.Add(this.modificarHospitalesBoton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(755, 520);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 0;
            // 
            // modificarHospitalesBoton
            // 
            this.modificarHospitalesBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarHospitalesBoton.Location = new System.Drawing.Point(65, 112);
            this.modificarHospitalesBoton.Name = "modificarHospitalesBoton";
            this.modificarHospitalesBoton.Size = new System.Drawing.Size(130, 42);
            this.modificarHospitalesBoton.TabIndex = 0;
            this.modificarHospitalesBoton.Text = "Modificar";
            this.modificarHospitalesBoton.UseVisualStyleBackColor = true;
            this.modificarHospitalesBoton.Click += new System.EventHandler(this.modificarHospitalesBoton_Click);
            // 
            // guardarHospitalBoton
            // 
            this.guardarHospitalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardarHospitalBoton.Location = new System.Drawing.Point(65, 247);
            this.guardarHospitalBoton.Name = "guardarHospitalBoton";
            this.guardarHospitalBoton.Size = new System.Drawing.Size(130, 45);
            this.guardarHospitalBoton.TabIndex = 1;
            this.guardarHospitalBoton.Text = "Guardar";
            this.guardarHospitalBoton.UseVisualStyleBackColor = true;
            // 
            // regresarMenuHospitalBoton
            // 
            this.regresarMenuHospitalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuHospitalBoton.Location = new System.Drawing.Point(65, 386);
            this.regresarMenuHospitalBoton.Name = "regresarMenuHospitalBoton";
            this.regresarMenuHospitalBoton.Size = new System.Drawing.Size(130, 49);
            this.regresarMenuHospitalBoton.TabIndex = 2;
            this.regresarMenuHospitalBoton.Text = "Regresar";
            this.regresarMenuHospitalBoton.UseVisualStyleBackColor = true;
            this.regresarMenuHospitalBoton.Click += new System.EventHandler(this.regresarMenuHospitalBoton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 185);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // HospitalForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 520);
            this.Controls.Add(this.splitContainer1);
            this.Name = "HospitalForma";
            this.Text = "Hospital";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button regresarMenuHospitalBoton;
        private System.Windows.Forms.Button guardarHospitalBoton;
        private System.Windows.Forms.Button modificarHospitalesBoton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}