namespace BasesAvanzadas
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Division1 = new System.Windows.Forms.SplitContainer();
            this.menuGeneral = new System.Windows.Forms.GroupBox();
            this.menuPaciente = new System.Windows.Forms.GroupBox();
            this.vistaPacientes = new System.Windows.Forms.SplitContainer();
            this.botonMenuGenera = new System.Windows.Forms.Button();
            this.botonAltaPaciente = new System.Windows.Forms.Button();
            this.botonBuscarPaciente = new System.Windows.Forms.Button();
            this.segurosocialPaciente = new System.Windows.Forms.TextBox();
            this.apellidoPaciente = new System.Windows.Forms.TextBox();
            this.nombrePaciente = new System.Windows.Forms.TextBox();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuContextPaciente = new System.Windows.Forms.GroupBox();
            this.ContextPacienteVista = new System.Windows.Forms.SplitContainer();
            this.datosBoton = new System.Windows.Forms.Button();
            this.agregarNotaBoton = new System.Windows.Forms.Button();
            this.verNotaBoton = new System.Windows.Forms.Button();
            this.regresarPacienteMenuBoton = new System.Windows.Forms.Button();
            this.expedienteBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Division1)).BeginInit();
            this.Division1.Panel1.SuspendLayout();
            this.Division1.Panel2.SuspendLayout();
            this.Division1.SuspendLayout();
            this.menuGeneral.SuspendLayout();
            this.menuPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPacientes)).BeginInit();
            this.vistaPacientes.Panel1.SuspendLayout();
            this.vistaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.menuContextPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContextPacienteVista)).BeginInit();
            this.ContextPacienteVista.Panel1.SuspendLayout();
            this.ContextPacienteVista.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pacientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Pacientes);
            // 
            // button2
            // 
            this.button2.AllowDrop = true;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Profesional de Salud";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ProfesionalDeLaSalud);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.Location = new System.Drawing.Point(429, 3);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(125, 28);
            this.cerrarSesion.TabIndex = 3;
            this.cerrarSesion.Text = "Cerrar sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            this.cerrarSesion.Click += new System.EventHandler(this.Salir);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 234);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(272, 61);
            this.button5.TabIndex = 2;
            this.button5.Text = "Hospitales";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Hospital);
            // 
            // Division1
            // 
            this.Division1.Location = new System.Drawing.Point(6, 9);
            this.Division1.Name = "Division1";
            // 
            // Division1.Panel1
            // 
            this.Division1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Division1.Panel1.Controls.Add(this.button5);
            this.Division1.Panel1.Controls.Add(this.button2);
            this.Division1.Panel1.Controls.Add(this.button1);
            // 
            // Division1.Panel2
            // 
            this.Division1.Panel2.Controls.Add(this.cerrarSesion);
            this.Division1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Division1_Panel2_Paint);
            this.Division1.Size = new System.Drawing.Size(839, 359);
            this.Division1.SplitterDistance = 240;
            this.Division1.TabIndex = 5;
            // 
            // menuGeneral
            // 
            this.menuGeneral.Controls.Add(this.Division1);
            this.menuGeneral.Location = new System.Drawing.Point(294, 47);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(190, 300);
            this.menuGeneral.TabIndex = 6;
            this.menuGeneral.TabStop = false;
            // 
            // menuPaciente
            // 
            this.menuPaciente.Controls.Add(this.vistaPacientes);
            this.menuPaciente.Location = new System.Drawing.Point(36, 31);
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(218, 319);
            this.menuPaciente.TabIndex = 7;
            this.menuPaciente.TabStop = false;
            // 
            // vistaPacientes
            // 
            this.vistaPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaPacientes.Location = new System.Drawing.Point(3, 16);
            this.vistaPacientes.Name = "vistaPacientes";
            // 
            // vistaPacientes.Panel1
            // 
            this.vistaPacientes.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vistaPacientes.Panel1.Controls.Add(this.botonMenuGenera);
            this.vistaPacientes.Panel1.Controls.Add(this.botonAltaPaciente);
            this.vistaPacientes.Panel1.Controls.Add(this.botonBuscarPaciente);
            this.vistaPacientes.Panel1.Controls.Add(this.segurosocialPaciente);
            this.vistaPacientes.Panel1.Controls.Add(this.apellidoPaciente);
            this.vistaPacientes.Panel1.Controls.Add(this.nombrePaciente);
            this.vistaPacientes.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.vistaPacientes_Panel1_Paint);
            this.vistaPacientes.Size = new System.Drawing.Size(212, 300);
            this.vistaPacientes.SplitterDistance = 70;
            this.vistaPacientes.TabIndex = 0;
            // 
            // botonMenuGenera
            // 
            this.botonMenuGenera.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonMenuGenera.Location = new System.Drawing.Point(4, 277);
            this.botonMenuGenera.Name = "botonMenuGenera";
            this.botonMenuGenera.Size = new System.Drawing.Size(191, 45);
            this.botonMenuGenera.TabIndex = 5;
            this.botonMenuGenera.Text = "Menú";
            this.botonMenuGenera.UseVisualStyleBackColor = true;
            // 
            // botonAltaPaciente
            // 
            this.botonAltaPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAltaPaciente.Location = new System.Drawing.Point(3, 226);
            this.botonAltaPaciente.Name = "botonAltaPaciente";
            this.botonAltaPaciente.Size = new System.Drawing.Size(191, 44);
            this.botonAltaPaciente.TabIndex = 4;
            this.botonAltaPaciente.Text = "Altas";
            this.botonAltaPaciente.UseVisualStyleBackColor = true;
            // 
            // botonBuscarPaciente
            // 
            this.botonBuscarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonBuscarPaciente.Location = new System.Drawing.Point(4, 181);
            this.botonBuscarPaciente.Name = "botonBuscarPaciente";
            this.botonBuscarPaciente.Size = new System.Drawing.Size(191, 39);
            this.botonBuscarPaciente.TabIndex = 3;
            this.botonBuscarPaciente.Text = "Buscar";
            this.botonBuscarPaciente.UseVisualStyleBackColor = true;
            this.botonBuscarPaciente.Click += new System.EventHandler(this.botonBuscarPaciente_Click);
            // 
            // segurosocialPaciente
            // 
            this.segurosocialPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.segurosocialPaciente.Location = new System.Drawing.Point(40, 136);
            this.segurosocialPaciente.Name = "segurosocialPaciente";
            this.segurosocialPaciente.Size = new System.Drawing.Size(122, 20);
            this.segurosocialPaciente.TabIndex = 2;
            this.segurosocialPaciente.Text = "Número Seguro Social";
            this.segurosocialPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // apellidoPaciente
            // 
            this.apellidoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.apellidoPaciente.Location = new System.Drawing.Point(40, 86);
            this.apellidoPaciente.Name = "apellidoPaciente";
            this.apellidoPaciente.Size = new System.Drawing.Size(122, 20);
            this.apellidoPaciente.TabIndex = 1;
            this.apellidoPaciente.Text = "Apellido";
            this.apellidoPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombrePaciente
            // 
            this.nombrePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrePaciente.Location = new System.Drawing.Point(40, 32);
            this.nombrePaciente.Name = "nombrePaciente";
            this.nombrePaciente.Size = new System.Drawing.Size(122, 20);
            this.nombrePaciente.TabIndex = 0;
            this.nombrePaciente.Text = "Nombre";
            this.nombrePaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuContextPaciente
            // 
            this.menuContextPaciente.Controls.Add(this.ContextPacienteVista);
            this.menuContextPaciente.Location = new System.Drawing.Point(559, 47);
            this.menuContextPaciente.Name = "menuContextPaciente";
            this.menuContextPaciente.Size = new System.Drawing.Size(185, 312);
            this.menuContextPaciente.TabIndex = 8;
            this.menuContextPaciente.TabStop = false;
            this.menuContextPaciente.Enter += new System.EventHandler(this.vistaContextPaciente_Enter);
            // 
            // ContextPacienteVista
            // 
            this.ContextPacienteVista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContextPacienteVista.Location = new System.Drawing.Point(3, 16);
            this.ContextPacienteVista.Name = "ContextPacienteVista";
            // 
            // ContextPacienteVista.Panel1
            // 
            this.ContextPacienteVista.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ContextPacienteVista.Panel1.Controls.Add(this.expedienteBoton);
            this.ContextPacienteVista.Panel1.Controls.Add(this.regresarPacienteMenuBoton);
            this.ContextPacienteVista.Panel1.Controls.Add(this.verNotaBoton);
            this.ContextPacienteVista.Panel1.Controls.Add(this.agregarNotaBoton);
            this.ContextPacienteVista.Panel1.Controls.Add(this.datosBoton);
            this.ContextPacienteVista.Size = new System.Drawing.Size(179, 293);
            this.ContextPacienteVista.SplitterDistance = 59;
            this.ContextPacienteVista.TabIndex = 0;
            // 
            // datosBoton
            // 
            this.datosBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosBoton.Location = new System.Drawing.Point(3, 3);
            this.datosBoton.Name = "datosBoton";
            this.datosBoton.Size = new System.Drawing.Size(194, 45);
            this.datosBoton.TabIndex = 0;
            this.datosBoton.Text = "Datos";
            this.datosBoton.UseVisualStyleBackColor = true;
            // 
            // agregarNotaBoton
            // 
            this.agregarNotaBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarNotaBoton.Location = new System.Drawing.Point(3, 57);
            this.agregarNotaBoton.Name = "agregarNotaBoton";
            this.agregarNotaBoton.Size = new System.Drawing.Size(193, 41);
            this.agregarNotaBoton.TabIndex = 1;
            this.agregarNotaBoton.Text = "Agregar Nota";
            this.agregarNotaBoton.UseVisualStyleBackColor = true;
            // 
            // verNotaBoton
            // 
            this.verNotaBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verNotaBoton.Location = new System.Drawing.Point(4, 104);
            this.verNotaBoton.Name = "verNotaBoton";
            this.verNotaBoton.Size = new System.Drawing.Size(193, 46);
            this.verNotaBoton.TabIndex = 2;
            this.verNotaBoton.Text = "Ver Notas";
            this.verNotaBoton.UseVisualStyleBackColor = true;
            // 
            // regresarPacienteMenuBoton
            // 
            this.regresarPacienteMenuBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarPacienteMenuBoton.Location = new System.Drawing.Point(4, 156);
            this.regresarPacienteMenuBoton.Name = "regresarPacienteMenuBoton";
            this.regresarPacienteMenuBoton.Size = new System.Drawing.Size(193, 46);
            this.regresarPacienteMenuBoton.TabIndex = 3;
            this.regresarPacienteMenuBoton.Text = "Regresar";
            this.regresarPacienteMenuBoton.UseVisualStyleBackColor = true;
            // 
            // expedienteBoton
            // 
            this.expedienteBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expedienteBoton.Location = new System.Drawing.Point(4, 208);
            this.expedienteBoton.Name = "expedienteBoton";
            this.expedienteBoton.Size = new System.Drawing.Size(193, 44);
            this.expedienteBoton.TabIndex = 4;
            this.expedienteBoton.Text = "Expediente";
            this.expedienteBoton.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1068, 539);
            this.Controls.Add(this.menuContextPaciente);
            this.Controls.Add(this.menuGeneral);
            this.Controls.Add(this.menuPaciente);
            this.Name = "Inicio";
            this.Text = "Equipo Negro App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Division1.Panel1.ResumeLayout(false);
            this.Division1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division1)).EndInit();
            this.Division1.ResumeLayout(false);
            this.menuGeneral.ResumeLayout(false);
            this.menuPaciente.ResumeLayout(false);
            this.vistaPacientes.Panel1.ResumeLayout(false);
            this.vistaPacientes.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPacientes)).EndInit();
            this.vistaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.menuContextPaciente.ResumeLayout(false);
            this.ContextPacienteVista.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContextPacienteVista)).EndInit();
            this.ContextPacienteVista.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.SplitContainer Division1;
        private System.Windows.Forms.GroupBox menuGeneral;
        private System.Windows.Forms.GroupBox menuPaciente;
        private System.Windows.Forms.SplitContainer vistaPacientes;
        private System.Windows.Forms.Button botonMenuGenera;
        private System.Windows.Forms.Button botonAltaPaciente;
        private System.Windows.Forms.Button botonBuscarPaciente;
        private System.Windows.Forms.TextBox segurosocialPaciente;
        private System.Windows.Forms.TextBox apellidoPaciente;
        private System.Windows.Forms.TextBox nombrePaciente;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.GroupBox menuContextPaciente;
        private System.Windows.Forms.SplitContainer ContextPacienteVista;
        private System.Windows.Forms.Button expedienteBoton;
        private System.Windows.Forms.Button regresarPacienteMenuBoton;
        private System.Windows.Forms.Button verNotaBoton;
        private System.Windows.Forms.Button agregarNotaBoton;
        private System.Windows.Forms.Button datosBoton;
    }
}

