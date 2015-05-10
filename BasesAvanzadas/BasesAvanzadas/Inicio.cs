﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BasesAvanzadas
{
    public partial class Inicio : Form
    {
        public string mandarDato;
        private string SeguroSocialPacientePS;
        private int idProfSalLogIn;
        private int idMedicTratante;
        AltaPersonal altaProfesional = new AltaPersonal();
        FormHospital altaHospital = new FormHospital();
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
            altaHospital.Show();
        }
        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        public void filtradoPacientes()
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.0.12;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password");
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                ////-----Busquedas en Pacientes------
                
                    cmd = new SqlCommand("SELECT * FROM Paciente WHERE NumSeguroSocial LIKE '%" + segurosocialPaciente.Text + "%' and Nombre_P LIKE '%" + nombrePaciente.Text + "%' and Ap_PatP LIKE '%" + apellidoPaciente.Text + "%';", con);
                
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("NumSeguroSocial", typeof(string));
                    dt.Columns.Add("Nombre_P", typeof(string));
                    dt.Columns.Add("Ap_PatP", typeof(string));
                    dt.Columns.Add("Ap_Mat", typeof(string));
                    dt.Columns.Add("F_Nac", typeof(DateTime));
                    dt.Columns.Add("Genero", typeof(char));
                    dt.Columns.Add("Domicilio", typeof(string));
                    dt.Columns.Add("Escolaridad", typeof(string));
                    dt.Columns.Add("Etnia", typeof(string));
                    dt.Columns.Add("Religion", typeof(string));
                    dt.Load(reader);

                    dataGridView2.DataSource = dt;

                    Console.Write("i have rows");

                }
                else
                {
                    Console.Write("no rows");
                }
                con.Close();
            }
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
            DatosForma datosForma = new DatosForma(mandarDato, SeguroContextoPaciente.Text);
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
            menuGeneral.Visible = false;
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
            AutoSize = true;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet3.Nota_Gen' Puede moverla o quitarla según sea necesario.
            this.nota_GenTableAdapter.Fill(this.proyectoDBADataSet3.Nota_Gen);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet2.Profesional_Salud' Puede moverla o quitarla según sea necesario.
            this.profesional_SaludTableAdapter.Fill(this.proyectoDBADataSet2.Profesional_Salud);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet1.Hospital' Puede moverla o quitarla según sea necesario.
            this.hospitalTableAdapter.Fill(this.proyectoDBADataSet1.Hospital);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.proyectoDBADataSet.Paciente);

            VerMasBoton.Hide();
        }

        private void regresarMenuPrincipalBoton_Click(object sender, EventArgs e)
        {
            menuPersonal.Visible = false;
            menuGeneral.Visible = true;
        }

        private void regresarMenuNotaBoton_Click(object sender, EventArgs e)
        {
            menuVerNota.Visible = false;
            menuContextPaciente.Visible = true;
        }

        private void botonMenuGenera_Click(object sender, EventArgs e)
        {
            menuPaciente.Visible = false;
            menuGeneral.Visible = true;
        }

        private void regresarMenuGeneralBoton_Click(object sender, EventArgs e)
        {
            menuHospital.Visible = false;
            menuGeneral.Visible = true;
        }

        private void regresarMenuContexPacienteBoton_Click(object sender, EventArgs e)
        {
            menuAgregarNotas.Visible = false;
            menuContextPaciente.Visible = true;
        }

        private void modicarDatosPersonalBoton_Click(object sender, EventArgs e)
        {

        }

        private void altaDatosPersonal_Click(object sender, EventArgs e)
        {
            AltaPersonal altaPersonal = new AltaPersonal();
            altaPersonal.Show();
        }

        private void buscarDetallesPersonalBoton_Click(object sender, EventArgs e)
        {
            String apellidoP = apellidoPersonal.Text;
            String nombreP = nombrePersonal.Text;

            if (!apellidoP.Equals(""))
            {
                
            }
        }

        private void menuVerNota_Enter(object sender, EventArgs e)
        {

        }

        private void VerMasBoton_Click(object sender, EventArgs e)
        {
                menuContextPaciente.Visible = true;
                menuPaciente.Visible = false;
                nombreContextoPaciente.Text = nombrePaciente.Text + " " + apellidoPaciente.Text;
                mandarDato = nombrePaciente.Text + "," + apellidoPaciente.Text;
                SeguroContextoPaciente.Text = segurosocialPaciente.Text;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombrePaciente.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            apellidoPaciente.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            SeguroSocialPacientePS = segurosocialPaciente.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            nombrePaciente.Show();
            apellidoPaciente.Show();
            segurosocialPaciente.Show();
            VerMasBoton.Show();
        }

        private void nombrePaciente_TextChanged(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        private void apellidoPaciente_TextChanged(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        private void segurosocialPaciente_TextChanged(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

    }
}
