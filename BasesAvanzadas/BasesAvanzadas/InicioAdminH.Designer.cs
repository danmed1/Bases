namespace BasesAvanzadas
{
    partial class InicioAdminH
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
            this.personalBoton = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.Division1 = new System.Windows.Forms.SplitContainer();
            this.menuGeneral = new System.Windows.Forms.GroupBox();
            this.pacienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDBADataSet = new BasesAvanzadas.ProyectoDBADataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaGenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuPersonal = new System.Windows.Forms.GroupBox();
            this.vistaDetallesPersonal = new System.Windows.Forms.SplitContainer();
            this.label8A = new System.Windows.Forms.Label();
            this.label8N = new System.Windows.Forms.Label();
            this.modicarDatosPersonalBoton = new System.Windows.Forms.Button();
            this.regresarMenuPrincipalBoton = new System.Windows.Forms.Button();
            this.altaDatosPersonal = new System.Windows.Forms.Button();
            this.buscarDetallesPersonalBoton = new System.Windows.Forms.Button();
            this.apellidoPersonal = new System.Windows.Forms.TextBox();
            this.nombrePersonal = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombrePSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesionalSaludBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDBADataSet2 = new BasesAvanzadas.ProyectoDBADataSet2();
            this.profesionalSaludBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profesionalSaludBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDBADataSet1 = new BasesAvanzadas.ProyectoDBADataSet1();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notaGenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoDBADataSet3 = new BasesAvanzadas.ProyectoDBADataSet3();
            this.pacienteTableAdapter = new BasesAvanzadas.ProyectoDBADataSetTableAdapters.PacienteTableAdapter();
            this.hospitalTableAdapter = new BasesAvanzadas.ProyectoDBADataSet1TableAdapters.HospitalTableAdapter();
            this.nota_GenTableAdapter = new BasesAvanzadas.ProyectoDBADataSet3TableAdapters.Nota_GenTableAdapter();
            this.profesional_SaludTableAdapter = new BasesAvanzadas.ProyectoDBADataSet2TableAdapters.Profesional_SaludTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Division1)).BeginInit();
            this.Division1.Panel1.SuspendLayout();
            this.Division1.Panel2.SuspendLayout();
            this.Division1.SuspendLayout();
            this.menuGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaGenBindingSource)).BeginInit();
            this.menuPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetallesPersonal)).BeginInit();
            this.vistaDetallesPersonal.Panel1.SuspendLayout();
            this.vistaDetallesPersonal.Panel2.SuspendLayout();
            this.vistaDetallesPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalSaludBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalSaludBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalSaludBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaGenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // personalBoton
            // 
            this.personalBoton.AllowDrop = true;
            this.personalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalBoton.Location = new System.Drawing.Point(3, 121);
            this.personalBoton.Name = "personalBoton";
            this.personalBoton.Size = new System.Drawing.Size(272, 54);
            this.personalBoton.TabIndex = 1;
            this.personalBoton.Text = "Personal";
            this.personalBoton.UseVisualStyleBackColor = true;
            this.personalBoton.Click += new System.EventHandler(this.Personal);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.Location = new System.Drawing.Point(427, 3);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(125, 28);
            this.cerrarSesion.TabIndex = 3;
            this.cerrarSesion.Text = "Cerrar sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            this.cerrarSesion.Click += new System.EventHandler(this.Salir);
            // 
            // Division1
            // 
            this.Division1.Location = new System.Drawing.Point(12, 19);
            this.Division1.Name = "Division1";
            // 
            // Division1.Panel1
            // 
            this.Division1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Division1.Panel1.Controls.Add(this.personalBoton);
            // 
            // Division1.Panel2
            // 
            this.Division1.Panel2.Controls.Add(this.cerrarSesion);
            this.Division1.Size = new System.Drawing.Size(837, 517);
            this.Division1.SplitterDistance = 281;
            this.Division1.TabIndex = 5;
            // 
            // menuGeneral
            // 
            this.menuGeneral.AutoSize = true;
            this.menuGeneral.Controls.Add(this.Division1);
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.MinimumSize = new System.Drawing.Size(800, 600);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(858, 600);
            this.menuGeneral.TabIndex = 6;
            this.menuGeneral.TabStop = false;
            this.menuGeneral.Enter += new System.EventHandler(this.menuGeneral_Enter);
            // 
            // pacienteBindingSource1
            // 
            this.pacienteBindingSource1.DataMember = "Paciente";
            this.pacienteBindingSource1.DataSource = this.proyectoDBADataSet;
            // 
            // proyectoDBADataSet
            // 
            this.proyectoDBADataSet.DataSetName = "ProyectoDBADataSet";
            this.proyectoDBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuPersonal
            // 
            this.menuPersonal.Controls.Add(this.vistaDetallesPersonal);
            this.menuPersonal.Location = new System.Drawing.Point(0, 0);
            this.menuPersonal.MinimumSize = new System.Drawing.Size(800, 600);
            this.menuPersonal.Name = "menuPersonal";
            this.menuPersonal.Size = new System.Drawing.Size(861, 600);
            this.menuPersonal.TabIndex = 12;
            this.menuPersonal.TabStop = false;
            // 
            // vistaDetallesPersonal
            // 
            this.vistaDetallesPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vistaDetallesPersonal.Location = new System.Drawing.Point(3, 16);
            this.vistaDetallesPersonal.Name = "vistaDetallesPersonal";
            // 
            // vistaDetallesPersonal.Panel1
            // 
            this.vistaDetallesPersonal.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.label8A);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.label8N);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.modicarDatosPersonalBoton);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.regresarMenuPrincipalBoton);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.altaDatosPersonal);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.buscarDetallesPersonalBoton);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.apellidoPersonal);
            this.vistaDetallesPersonal.Panel1.Controls.Add(this.nombrePersonal);
            // 
            // vistaDetallesPersonal.Panel2
            // 
            this.vistaDetallesPersonal.Panel2.Controls.Add(this.dataGridView3);
            this.vistaDetallesPersonal.Size = new System.Drawing.Size(855, 581);
            this.vistaDetallesPersonal.SplitterDistance = 282;
            this.vistaDetallesPersonal.TabIndex = 0;
            // 
            // label8A
            // 
            this.label8A.AutoSize = true;
            this.label8A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8A.Location = new System.Drawing.Point(17, 102);
            this.label8A.Name = "label8A";
            this.label8A.Size = new System.Drawing.Size(65, 20);
            this.label8A.TabIndex = 7;
            this.label8A.Text = "Apellido";
            // 
            // label8N
            // 
            this.label8N.AutoSize = true;
            this.label8N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8N.Location = new System.Drawing.Point(15, 63);
            this.label8N.Name = "label8N";
            this.label8N.Size = new System.Drawing.Size(65, 20);
            this.label8N.TabIndex = 6;
            this.label8N.Text = "Nombre";
            // 
            // modicarDatosPersonalBoton
            // 
            this.modicarDatosPersonalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modicarDatosPersonalBoton.Location = new System.Drawing.Point(4, 184);
            this.modicarDatosPersonalBoton.Name = "modicarDatosPersonalBoton";
            this.modicarDatosPersonalBoton.Size = new System.Drawing.Size(264, 36);
            this.modicarDatosPersonalBoton.TabIndex = 5;
            this.modicarDatosPersonalBoton.Text = "Modificar";
            this.modicarDatosPersonalBoton.UseVisualStyleBackColor = true;
            this.modicarDatosPersonalBoton.Click += new System.EventHandler(this.modicarDatosPersonalBoton_Click);
            // 
            // regresarMenuPrincipalBoton
            // 
            this.regresarMenuPrincipalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuPrincipalBoton.Location = new System.Drawing.Point(3, 262);
            this.regresarMenuPrincipalBoton.Name = "regresarMenuPrincipalBoton";
            this.regresarMenuPrincipalBoton.Size = new System.Drawing.Size(265, 37);
            this.regresarMenuPrincipalBoton.TabIndex = 4;
            this.regresarMenuPrincipalBoton.Text = "Regresar";
            this.regresarMenuPrincipalBoton.UseVisualStyleBackColor = true;
            this.regresarMenuPrincipalBoton.Click += new System.EventHandler(this.regresarMenuPrincipalBoton_Click);
            // 
            // altaDatosPersonal
            // 
            this.altaDatosPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaDatosPersonal.Location = new System.Drawing.Point(3, 223);
            this.altaDatosPersonal.Name = "altaDatosPersonal";
            this.altaDatosPersonal.Size = new System.Drawing.Size(265, 36);
            this.altaDatosPersonal.TabIndex = 3;
            this.altaDatosPersonal.Text = "Altas";
            this.altaDatosPersonal.UseVisualStyleBackColor = true;
            this.altaDatosPersonal.Click += new System.EventHandler(this.altaDatosPersonal_Click);
            // 
            // buscarDetallesPersonalBoton
            // 
            this.buscarDetallesPersonalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDetallesPersonalBoton.Location = new System.Drawing.Point(4, 147);
            this.buscarDetallesPersonalBoton.Name = "buscarDetallesPersonalBoton";
            this.buscarDetallesPersonalBoton.Size = new System.Drawing.Size(265, 34);
            this.buscarDetallesPersonalBoton.TabIndex = 2;
            this.buscarDetallesPersonalBoton.Text = "Buscar";
            this.buscarDetallesPersonalBoton.UseVisualStyleBackColor = true;
            this.buscarDetallesPersonalBoton.Click += new System.EventHandler(this.buscarDetallesPersonalBoton_Click);
            // 
            // apellidoPersonal
            // 
            this.apellidoPersonal.Location = new System.Drawing.Point(124, 102);
            this.apellidoPersonal.Name = "apellidoPersonal";
            this.apellidoPersonal.Size = new System.Drawing.Size(145, 20);
            this.apellidoPersonal.TabIndex = 1;
            this.apellidoPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apellidoPersonal.TextChanged += new System.EventHandler(this.apellidoPersonal_TextChanged);
            // 
            // nombrePersonal
            // 
            this.nombrePersonal.Location = new System.Drawing.Point(124, 63);
            this.nombrePersonal.Name = "nombrePersonal";
            this.nombrePersonal.Size = new System.Drawing.Size(145, 20);
            this.nombrePersonal.TabIndex = 0;
            this.nombrePersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombrePersonal.TextChanged += new System.EventHandler(this.nombrePersonal_TextChanged);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrePSDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.Perfil,
            this.Especialidad});
            this.dataGridView3.DataSource = this.profesionalSaludBindingSource2;
            this.dataGridView3.Location = new System.Drawing.Point(24, 32);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(542, 488);
            this.dataGridView3.TabIndex = 0;
            // 
            // nombrePSDataGridViewTextBoxColumn
            // 
            this.nombrePSDataGridViewTextBoxColumn.DataPropertyName = "Nombre_PS";
            this.nombrePSDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombrePSDataGridViewTextBoxColumn.Name = "nombrePSDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Ap_Pat";
            this.dataGridViewTextBoxColumn10.HeaderText = "Apellido paterno";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 110;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Ap_Mat";
            this.dataGridViewTextBoxColumn11.HeaderText = "Apellido materno";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 110;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "Perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Especialidad";
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            // 
            // profesionalSaludBindingSource2
            // 
            this.profesionalSaludBindingSource2.DataMember = "Profesional_Salud";
            this.profesionalSaludBindingSource2.DataSource = this.proyectoDBADataSet2;
            // 
            // proyectoDBADataSet2
            // 
            this.proyectoDBADataSet2.DataSetName = "ProyectoDBADataSet2";
            this.proyectoDBADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource1
            // 
            this.hospitalBindingSource1.DataMember = "Hospital";
            this.hospitalBindingSource1.DataSource = this.proyectoDBADataSet1;
            // 
            // proyectoDBADataSet1
            // 
            this.proyectoDBADataSet1.DataSetName = "ProyectoDBADataSet1";
            this.proyectoDBADataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notaGenBindingSource1
            // 
            this.notaGenBindingSource1.DataMember = "Nota_Gen";
            this.notaGenBindingSource1.DataSource = this.proyectoDBADataSet3;
            // 
            // proyectoDBADataSet3
            // 
            this.proyectoDBADataSet3.DataSetName = "ProyectoDBADataSet3";
            this.proyectoDBADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // nota_GenTableAdapter
            // 
            this.nota_GenTableAdapter.ClearBeforeFill = true;
            // 
            // profesional_SaludTableAdapter
            // 
            this.profesional_SaludTableAdapter.ClearBeforeFill = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(873, 548);
            this.Controls.Add(this.menuGeneral);
            this.Controls.Add(this.menuPersonal);
            this.Name = "Inicio";
            this.Text = "Equipo Negro App";            
            this.Division1.Panel1.ResumeLayout(false);
            this.Division1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division1)).EndInit();
            this.Division1.ResumeLayout(false);
            this.menuGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaGenBindingSource)).EndInit();
            this.menuPersonal.ResumeLayout(false);
            this.vistaDetallesPersonal.Panel1.ResumeLayout(false);
            this.vistaDetallesPersonal.Panel1.PerformLayout();
            this.vistaDetallesPersonal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetallesPersonal)).EndInit();
            this.vistaDetallesPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalSaludBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalSaludBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesionalSaludBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaGenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button personalBoton;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.SplitContainer Division1;
        private System.Windows.Forms.GroupBox menuGeneral;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.GroupBox menuPersonal;
        private System.Windows.Forms.SplitContainer vistaDetallesPersonal;
        private System.Windows.Forms.Button regresarMenuPrincipalBoton;
        private System.Windows.Forms.Button altaDatosPersonal;
        private System.Windows.Forms.Button buscarDetallesPersonalBoton;
        private System.Windows.Forms.TextBox apellidoPersonal;
        private System.Windows.Forms.TextBox nombrePersonal;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button modicarDatosPersonalBoton;
        private System.Windows.Forms.BindingSource profesionalSaludBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPerfilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proyectoDBADataSetBindingSource;
        private System.Windows.Forms.BindingSource notaGenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNotaGenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSeguroSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesionalSaludMTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDiagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfesionalSaludElabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTiempoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSeguroSocialDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apPatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apMatDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fNacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn escolaridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn religionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHospitalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource profesionalSaludBindingSource1;
        private ProyectoDBADataSet proyectoDBADataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource1;
        private ProyectoDBADataSetTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private ProyectoDBADataSet1 proyectoDBADataSet1;
        private System.Windows.Forms.BindingSource hospitalBindingSource1;
        private ProyectoDBADataSet1TableAdapters.HospitalTableAdapter hospitalTableAdapter;
        private ProyectoDBADataSet2 proyectoDBADataSet2;
        private System.Windows.Forms.BindingSource profesionalSaludBindingSource2;
        private ProyectoDBADataSet2TableAdapters.Profesional_SaludTableAdapter profesional_SaludTableAdapter;
        private ProyectoDBADataSet3 proyectoDBADataSet3;
        private System.Windows.Forms.BindingSource notaGenBindingSource1;
        private ProyectoDBADataSet3TableAdapters.Nota_GenTableAdapter nota_GenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.Label label8A;
        private System.Windows.Forms.Label label8N;        
    }
}

