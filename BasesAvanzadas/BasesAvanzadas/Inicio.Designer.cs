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
            this.menuPaciente = new System.Windows.Forms.GroupBox();
            this.vistaPacientes = new System.Windows.Forms.SplitContainer();
            this.botonMenuGenera = new System.Windows.Forms.Button();
            this.botonAltaPaciente = new System.Windows.Forms.Button();
            this.botonBuscarPaciente = new System.Windows.Forms.Button();
            this.segurosocialPaciente = new System.Windows.Forms.TextBox();
            this.apellidoPaciente = new System.Windows.Forms.TextBox();
            this.nombrePaciente = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuContextPaciente = new System.Windows.Forms.GroupBox();
            this.ContextPacienteVista = new System.Windows.Forms.SplitContainer();
            this.expedienteBoton = new System.Windows.Forms.Button();
            this.regresarPacienteMenuBoton = new System.Windows.Forms.Button();
            this.verNotaBoton = new System.Windows.Forms.Button();
            this.agregarNotaBoton = new System.Windows.Forms.Button();
            this.datosBoton = new System.Windows.Forms.Button();
            this.menuAgregarNotas = new System.Windows.Forms.GroupBox();
            this.regresarMenuContexPacienteBoton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.notaAltaboton = new System.Windows.Forms.Button();
            this.menuVerNota = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.regresarMenuNotaBoton = new System.Windows.Forms.Button();
            this.menuPersonal = new System.Windows.Forms.GroupBox();
            this.vistaDetallesPersonal = new System.Windows.Forms.SplitContainer();
            this.modicarDatosPersonalBoton = new System.Windows.Forms.Button();
            this.regresarMenuPrincipalBoton = new System.Windows.Forms.Button();
            this.altaDatosPersonal = new System.Windows.Forms.Button();
            this.buscarDetallesPersonalBoton = new System.Windows.Forms.Button();
            this.apellidoPersonal = new System.Windows.Forms.TextBox();
            this.nombrePersonal = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.menuHospital = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.regresarMenuGeneralBoton = new System.Windows.Forms.Button();
            this.modificarHospitalBoton = new System.Windows.Forms.Button();
            this.altasHospitalBoton = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.menuGeneral = new System.Windows.Forms.GroupBox();
            this.Division1 = new System.Windows.Forms.SplitContainer();
            this.hospitalBoton = new System.Windows.Forms.Button();
            this.personalBoton = new System.Windows.Forms.Button();
            this.pacienteBoton = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.proyectoDBADataSet = new BasesAvanzadas.ProyectoDBADataSet();
            this.hospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalTableAdapter = new BasesAvanzadas.ProyectoDBADataSetTableAdapters.HospitalTableAdapter();
            this.idHospitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaPacientes)).BeginInit();
            this.vistaPacientes.Panel1.SuspendLayout();
            this.vistaPacientes.Panel2.SuspendLayout();
            this.vistaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.menuContextPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContextPacienteVista)).BeginInit();
            this.ContextPacienteVista.Panel1.SuspendLayout();
            this.ContextPacienteVista.SuspendLayout();
            this.menuAgregarNotas.SuspendLayout();
            this.menuVerNota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetallesPersonal)).BeginInit();
            this.vistaDetallesPersonal.Panel1.SuspendLayout();
            this.vistaDetallesPersonal.Panel2.SuspendLayout();
            this.vistaDetallesPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.menuHospital.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.menuGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Division1)).BeginInit();
            this.Division1.Panel1.SuspendLayout();
            this.Division1.Panel2.SuspendLayout();
            this.Division1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPaciente
            // 
            this.menuPaciente.Controls.Add(this.vistaPacientes);
            this.menuPaciente.Location = new System.Drawing.Point(6, 110);
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(1361, 544);
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
            // 
            // vistaPacientes.Panel2
            // 
            this.vistaPacientes.Panel2.Controls.Add(this.dataGridView2);
            this.vistaPacientes.Size = new System.Drawing.Size(1355, 525);
            this.vistaPacientes.SplitterDistance = 413;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.DataSource = this.dataSet1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(53, 213);
            this.dataGridView2.TabIndex = 0;
            // 
            // menuContextPaciente
            // 
            this.menuContextPaciente.Controls.Add(this.ContextPacienteVista);
            this.menuContextPaciente.Location = new System.Drawing.Point(35, 65);
            this.menuContextPaciente.Name = "menuContextPaciente";
            this.menuContextPaciente.Size = new System.Drawing.Size(1315, 500);
            this.menuContextPaciente.TabIndex = 8;
            this.menuContextPaciente.TabStop = false;
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
            this.ContextPacienteVista.Size = new System.Drawing.Size(1309, 481);
            this.ContextPacienteVista.SplitterDistance = 424;
            this.ContextPacienteVista.TabIndex = 0;
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
            this.expedienteBoton.Click += new System.EventHandler(this.expedienteBoton_Click);
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
            this.regresarPacienteMenuBoton.Click += new System.EventHandler(this.regresarPacienteMenuBoton_Click);
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
            this.verNotaBoton.Click += new System.EventHandler(this.verNotaBoton_Click);
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
            this.agregarNotaBoton.Click += new System.EventHandler(this.agregarNotaBoton_Click);
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
            this.datosBoton.Click += new System.EventHandler(this.datosBoton_Click);
            // 
            // menuAgregarNotas
            // 
            this.menuAgregarNotas.Controls.Add(this.regresarMenuContexPacienteBoton);
            this.menuAgregarNotas.Controls.Add(this.button3);
            this.menuAgregarNotas.Controls.Add(this.notaAltaboton);
            this.menuAgregarNotas.Location = new System.Drawing.Point(905, 492);
            this.menuAgregarNotas.Name = "menuAgregarNotas";
            this.menuAgregarNotas.Size = new System.Drawing.Size(66, 357);
            this.menuAgregarNotas.TabIndex = 9;
            this.menuAgregarNotas.TabStop = false;
            // 
            // regresarMenuContexPacienteBoton
            // 
            this.regresarMenuContexPacienteBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuContexPacienteBoton.Location = new System.Drawing.Point(111, 208);
            this.regresarMenuContexPacienteBoton.Name = "regresarMenuContexPacienteBoton";
            this.regresarMenuContexPacienteBoton.Size = new System.Drawing.Size(114, 31);
            this.regresarMenuContexPacienteBoton.TabIndex = 2;
            this.regresarMenuContexPacienteBoton.Text = "Regresar";
            this.regresarMenuContexPacienteBoton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(111, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 44);
            this.button3.TabIndex = 1;
            this.button3.Text = "Nota Actualización";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // notaAltaboton
            // 
            this.notaAltaboton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaAltaboton.Location = new System.Drawing.Point(111, 66);
            this.notaAltaboton.Name = "notaAltaboton";
            this.notaAltaboton.Size = new System.Drawing.Size(114, 49);
            this.notaAltaboton.TabIndex = 0;
            this.notaAltaboton.Text = "Nota Alta";
            this.notaAltaboton.UseVisualStyleBackColor = true;
            // 
            // menuVerNota
            // 
            this.menuVerNota.Controls.Add(this.dataGridView1);
            this.menuVerNota.Controls.Add(this.regresarMenuNotaBoton);
            this.menuVerNota.Location = new System.Drawing.Point(18, 91);
            this.menuVerNota.Name = "menuVerNota";
            this.menuVerNota.Size = new System.Drawing.Size(1338, 480);
            this.menuVerNota.TabIndex = 10;
            this.menuVerNota.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(201, 134);
            this.dataGridView1.TabIndex = 1;
            // 
            // regresarMenuNotaBoton
            // 
            this.regresarMenuNotaBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuNotaBoton.Location = new System.Drawing.Point(0, 19);
            this.regresarMenuNotaBoton.Name = "regresarMenuNotaBoton";
            this.regresarMenuNotaBoton.Size = new System.Drawing.Size(91, 29);
            this.regresarMenuNotaBoton.TabIndex = 0;
            this.regresarMenuNotaBoton.Text = "Regresar";
            this.regresarMenuNotaBoton.UseVisualStyleBackColor = true;
            // 
            // menuPersonal
            // 
            this.menuPersonal.Controls.Add(this.vistaDetallesPersonal);
            this.menuPersonal.Location = new System.Drawing.Point(61, 24);
            this.menuPersonal.Name = "menuPersonal";
            this.menuPersonal.Size = new System.Drawing.Size(1300, 538);
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
            this.vistaDetallesPersonal.Size = new System.Drawing.Size(1294, 519);
            this.vistaDetallesPersonal.SplitterDistance = 427;
            this.vistaDetallesPersonal.TabIndex = 0;
            // 
            // modicarDatosPersonalBoton
            // 
            this.modicarDatosPersonalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modicarDatosPersonalBoton.Location = new System.Drawing.Point(4, 184);
            this.modicarDatosPersonalBoton.Name = "modicarDatosPersonalBoton";
            this.modicarDatosPersonalBoton.Size = new System.Drawing.Size(99, 33);
            this.modicarDatosPersonalBoton.TabIndex = 5;
            this.modicarDatosPersonalBoton.Text = "Modificar";
            this.modicarDatosPersonalBoton.UseVisualStyleBackColor = true;
            // 
            // regresarMenuPrincipalBoton
            // 
            this.regresarMenuPrincipalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuPrincipalBoton.Location = new System.Drawing.Point(3, 262);
            this.regresarMenuPrincipalBoton.Name = "regresarMenuPrincipalBoton";
            this.regresarMenuPrincipalBoton.Size = new System.Drawing.Size(100, 34);
            this.regresarMenuPrincipalBoton.TabIndex = 4;
            this.regresarMenuPrincipalBoton.Text = "Regresar";
            this.regresarMenuPrincipalBoton.UseVisualStyleBackColor = true;
            // 
            // altaDatosPersonal
            // 
            this.altaDatosPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaDatosPersonal.Location = new System.Drawing.Point(3, 223);
            this.altaDatosPersonal.Name = "altaDatosPersonal";
            this.altaDatosPersonal.Size = new System.Drawing.Size(100, 33);
            this.altaDatosPersonal.TabIndex = 3;
            this.altaDatosPersonal.Text = "Altas";
            this.altaDatosPersonal.UseVisualStyleBackColor = true;
            // 
            // buscarDetallesPersonalBoton
            // 
            this.buscarDetallesPersonalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarDetallesPersonalBoton.Location = new System.Drawing.Point(4, 147);
            this.buscarDetallesPersonalBoton.Name = "buscarDetallesPersonalBoton";
            this.buscarDetallesPersonalBoton.Size = new System.Drawing.Size(100, 31);
            this.buscarDetallesPersonalBoton.TabIndex = 2;
            this.buscarDetallesPersonalBoton.Text = "Buscar";
            this.buscarDetallesPersonalBoton.UseVisualStyleBackColor = true;
            // 
            // apellidoPersonal
            // 
            this.apellidoPersonal.Location = new System.Drawing.Point(4, 102);
            this.apellidoPersonal.Name = "apellidoPersonal";
            this.apellidoPersonal.Size = new System.Drawing.Size(100, 20);
            this.apellidoPersonal.TabIndex = 1;
            this.apellidoPersonal.Text = "Apellido";
            this.apellidoPersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nombrePersonal
            // 
            this.nombrePersonal.Location = new System.Drawing.Point(4, 63);
            this.nombrePersonal.Name = "nombrePersonal";
            this.nombrePersonal.Size = new System.Drawing.Size(100, 20);
            this.nombrePersonal.TabIndex = 0;
            this.nombrePersonal.Text = "Nombre";
            this.nombrePersonal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(29, 94);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(163, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // menuHospital
            // 
            this.menuHospital.Controls.Add(this.splitContainer1);
            this.menuHospital.Location = new System.Drawing.Point(78, 5);
            this.menuHospital.Name = "menuHospital";
            this.menuHospital.Size = new System.Drawing.Size(1289, 557);
            this.menuHospital.TabIndex = 13;
            this.menuHospital.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.regresarMenuGeneralBoton);
            this.splitContainer1.Panel1.Controls.Add(this.modificarHospitalBoton);
            this.splitContainer1.Panel1.Controls.Add(this.altasHospitalBoton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView4);
            this.splitContainer1.Size = new System.Drawing.Size(1283, 538);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 0;
            // 
            // regresarMenuGeneralBoton
            // 
            this.regresarMenuGeneralBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresarMenuGeneralBoton.Location = new System.Drawing.Point(0, 299);
            this.regresarMenuGeneralBoton.Name = "regresarMenuGeneralBoton";
            this.regresarMenuGeneralBoton.Size = new System.Drawing.Size(146, 44);
            this.regresarMenuGeneralBoton.TabIndex = 2;
            this.regresarMenuGeneralBoton.Text = "Regresar";
            this.regresarMenuGeneralBoton.UseVisualStyleBackColor = true;
            // 
            // modificarHospitalBoton
            // 
            this.modificarHospitalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarHospitalBoton.Location = new System.Drawing.Point(3, 177);
            this.modificarHospitalBoton.Name = "modificarHospitalBoton";
            this.modificarHospitalBoton.Size = new System.Drawing.Size(143, 45);
            this.modificarHospitalBoton.TabIndex = 1;
            this.modificarHospitalBoton.Text = "Modificar";
            this.modificarHospitalBoton.UseVisualStyleBackColor = true;
            this.modificarHospitalBoton.Click += new System.EventHandler(this.modificarHospitalBoton_Click);
            // 
            // altasHospitalBoton
            // 
            this.altasHospitalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altasHospitalBoton.Location = new System.Drawing.Point(3, 70);
            this.altasHospitalBoton.Name = "altasHospitalBoton";
            this.altasHospitalBoton.Size = new System.Drawing.Size(143, 39);
            this.altasHospitalBoton.TabIndex = 0;
            this.altasHospitalBoton.Text = "Altas";
            this.altasHospitalBoton.UseVisualStyleBackColor = true;
            this.altasHospitalBoton.Click += new System.EventHandler(this.altasHospitalBoton_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idHospitalDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.hospitalBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(15, 66);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(496, 348);
            this.dataGridView4.TabIndex = 0;
            this.dataGridView4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellContentClick);
            // 
            // menuGeneral
            // 
            this.menuGeneral.AutoSize = true;
            this.menuGeneral.Controls.Add(this.Division1);
            this.menuGeneral.Location = new System.Drawing.Point(6, 5);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(1347, 517);
            this.menuGeneral.TabIndex = 15;
            this.menuGeneral.TabStop = false;
            // 
            // Division1
            // 
            this.Division1.Location = new System.Drawing.Point(13, 6);
            this.Division1.Name = "Division1";
            // 
            // Division1.Panel1
            // 
            this.Division1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Division1.Panel1.Controls.Add(this.hospitalBoton);
            this.Division1.Panel1.Controls.Add(this.personalBoton);
            this.Division1.Panel1.Controls.Add(this.pacienteBoton);
            // 
            // Division1.Panel2
            // 
            this.Division1.Panel2.Controls.Add(this.cerrarSesion);
            this.Division1.Size = new System.Drawing.Size(1328, 491);
            this.Division1.SplitterDistance = 276;
            this.Division1.TabIndex = 5;
            // 
            // hospitalBoton
            // 
            this.hospitalBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalBoton.Location = new System.Drawing.Point(3, 234);
            this.hospitalBoton.Name = "hospitalBoton";
            this.hospitalBoton.Size = new System.Drawing.Size(272, 61);
            this.hospitalBoton.TabIndex = 2;
            this.hospitalBoton.Text = "Hospitales";
            this.hospitalBoton.UseVisualStyleBackColor = true;
            this.hospitalBoton.Click += new System.EventHandler(this.hospitalBoton_Click_1);
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
            // 
            // pacienteBoton
            // 
            this.pacienteBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pacienteBoton.Location = new System.Drawing.Point(3, 10);
            this.pacienteBoton.Name = "pacienteBoton";
            this.pacienteBoton.Size = new System.Drawing.Size(272, 53);
            this.pacienteBoton.TabIndex = 0;
            this.pacienteBoton.Text = "Pacientes";
            this.pacienteBoton.UseVisualStyleBackColor = true;
            this.pacienteBoton.Click += new System.EventHandler(this.pacienteBoton_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesion.Location = new System.Drawing.Point(371, 35);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(125, 28);
            this.cerrarSesion.TabIndex = 3;
            this.cerrarSesion.Text = "Cerrar sesión";
            this.cerrarSesion.UseVisualStyleBackColor = true;
            // 
            // proyectoDBADataSet
            // 
            this.proyectoDBADataSet.DataSetName = "ProyectoDBADataSet";
            this.proyectoDBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hospitalBindingSource
            // 
            this.hospitalBindingSource.DataMember = "Hospital";
            this.hospitalBindingSource.DataSource = this.proyectoDBADataSet;
            // 
            // hospitalTableAdapter
            // 
            this.hospitalTableAdapter.ClearBeforeFill = true;
            // 
            // idHospitalDataGridViewTextBoxColumn
            // 
            this.idHospitalDataGridViewTextBoxColumn.DataPropertyName = "Id_Hospital";
            this.idHospitalDataGridViewTextBoxColumn.HeaderText = "Id_Hospital";
            this.idHospitalDataGridViewTextBoxColumn.Name = "idHospitalDataGridViewTextBoxColumn";
            this.idHospitalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1362, 561);
            this.Controls.Add(this.menuGeneral);
            this.Controls.Add(this.menuHospital);
            this.Controls.Add(this.menuAgregarNotas);
            this.Controls.Add(this.menuContextPaciente);
            this.Controls.Add(this.menuPersonal);
            this.Controls.Add(this.menuVerNota);
            this.Controls.Add(this.menuPaciente);
            this.Name = "Inicio";
            this.Text = "Equipo Negro App";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuPaciente.ResumeLayout(false);
            this.vistaPacientes.Panel1.ResumeLayout(false);
            this.vistaPacientes.Panel1.PerformLayout();
            this.vistaPacientes.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaPacientes)).EndInit();
            this.vistaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.menuContextPaciente.ResumeLayout(false);
            this.ContextPacienteVista.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContextPacienteVista)).EndInit();
            this.ContextPacienteVista.ResumeLayout(false);
            this.menuAgregarNotas.ResumeLayout(false);
            this.menuVerNota.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuPersonal.ResumeLayout(false);
            this.vistaDetallesPersonal.Panel1.ResumeLayout(false);
            this.vistaDetallesPersonal.Panel1.PerformLayout();
            this.vistaDetallesPersonal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vistaDetallesPersonal)).EndInit();
            this.vistaDetallesPersonal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.menuHospital.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.menuGeneral.ResumeLayout(false);
            this.Division1.Panel1.ResumeLayout(false);
            this.Division1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Division1)).EndInit();
            this.Division1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.proyectoDBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.GroupBox menuAgregarNotas;
        private System.Windows.Forms.Button regresarMenuContexPacienteBoton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button notaAltaboton;
        private System.Windows.Forms.GroupBox menuVerNota;
        private System.Windows.Forms.Button regresarMenuNotaBoton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox menuPersonal;
        private System.Windows.Forms.SplitContainer vistaDetallesPersonal;
        private System.Windows.Forms.Button regresarMenuPrincipalBoton;
        private System.Windows.Forms.Button altaDatosPersonal;
        private System.Windows.Forms.Button buscarDetallesPersonalBoton;
        private System.Windows.Forms.TextBox apellidoPersonal;
        private System.Windows.Forms.TextBox nombrePersonal;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button modicarDatosPersonalBoton;
        private System.Windows.Forms.GroupBox menuHospital;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button altasHospitalBoton;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button modificarHospitalBoton;
        private System.Windows.Forms.Button regresarMenuGeneralBoton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox menuGeneral;
        private System.Windows.Forms.SplitContainer Division1;
        private System.Windows.Forms.Button hospitalBoton;
        private System.Windows.Forms.Button personalBoton;
        private System.Windows.Forms.Button pacienteBoton;
        private System.Windows.Forms.Button cerrarSesion;
        private ProyectoDBADataSet proyectoDBADataSet;
        private System.Windows.Forms.BindingSource hospitalBindingSource;
        private ProyectoDBADataSetTableAdapters.HospitalTableAdapter hospitalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idHospitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}

