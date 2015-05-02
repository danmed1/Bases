﻿using System;
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
            AutoSize = true;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDBADataSet1.Hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.proyectoDBADataSet1.Hospital);
            // TODO: This line of code loads data into the 'proyectoDBADataSet1.Paciente' table. You can move, or remove it, as needed.
            this.pacienteTableAdapter.Fill(this.proyectoDBADataSet1.Paciente);
            // TODO: This line of code loads data into the 'proyectoDBADataSet1.Nota_Gen' table. You can move, or remove it, as needed.
            this.nota_GenTableAdapter.Fill(this.proyectoDBADataSet1.Nota_Gen);
            // TODO: This line of code loads data into the 'proyectoDBADataSet.Profesional_Salud' table. You can move, or remove it, as needed.
            this.profesional_SaludTableAdapter.Fill(this.proyectoDBADataSet.Profesional_Salud);

        }


    }
}
