using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasesAvanzadas
{
    public partial class Inicio : Form
    {

        Form4 altaProfesional = new Form4();
        public Inicio()
        {
            InitializeComponent();
            menuPaciente.Visible = false;
            menuContextPaciente.Visible = false;
            menuAgregarNotas.Visible = false;
            menuVerNota.Visible = false;
            menuHospital.Visible = false;
            menuPersonal.Visible = false;
        }

        private void Pacientes(object sender, EventArgs e)
        {
            menuPaciente.Visible = true;
            menuGeneral.Visible = false;
        }
        private void Personal(object sender, EventArgs e) {
            menuPersonal.Visible = true;
            menuGeneral.Visible = false;
        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Hospital(object sender, EventArgs e)
        {
            menuGeneral.Visible = false;
        }
        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            menuContextPaciente.Visible = true;
            menuPaciente.Visible = false;
        }

        private void agregarNotaBoton_Click(object sender, EventArgs e)
        {
            menuContextPaciente.Visible = false;
            menuAgregarNotas.Visible = true;
        }

        private void verNotaBoton_Click(object sender, EventArgs e)
        {
            menuVerNota.Visible = true;
            menuContextPaciente.Visible = false;
        }

        private void datosBoton_Click(object sender, EventArgs e)
        {
            DatosForma datosForma = new DatosForma();
            datosForma.Show();
        }

        private void altasHospitalBoton_Click(object sender, EventArgs e)
        {
            ////PON AQUI TU FORMA MEMO
            FormHospital fomraprueba = new FormHospital();
            fomraprueba.Show();
        }

        private void modificarHospitalBoton_Click(object sender, EventArgs e)
        {
            HospitalForma hospitalforma = new HospitalForma();
            hospitalBoton.Show();
        }

        private void hospitalBoton_Click(object sender, EventArgs e)
        {
            menuHospital.Visible = true;
        }

        private void regresarPacienteMenuBoton_Click(object sender, EventArgs e)
        {
            menuContextPaciente.Visible = false;
            menuPaciente.Visible = true;
        }

        private void expedienteBoton_Click(object sender, EventArgs e)
        {
            //cosas de word
        }

        private void menuGeneral_Enter(object sender, EventArgs e)
        {
            

        }

        private void altaDatosPersonal_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet1.Hospital' Puede moverla o quitarla según sea necesario.
            this.hospitalTableAdapter1.Fill(this.proyectoDBADataSet1.Hospital);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet.Paciente' Puede moverla o quitarla según sea necesario.
          //  this.pacienteTableAdapter.Fill(this.proyectoDBADataSet.Paciente);

        }

        private void pacienteBoton_Click(object sender, EventArgs e)
        {
            Pacientes(sender,e);
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hospitalBoton_Click_1(object sender, EventArgs e)
        {
            menuHospital.Visible = true;
            menuGeneral.Visible = false;
        }
    }
}
