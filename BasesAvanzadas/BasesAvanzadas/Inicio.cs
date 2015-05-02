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
        FormHospital altaHospital = new FormHospital();
        public Inicio()
        {
            InitializeComponent();
            menuPaciente.Visible = false;
            menuContextPaciente.Visible = false;
        }

        private void Pacientes(object sender, EventArgs e)
        {
            menuPaciente.Visible = true;
            menuGeneral.Visible = false;
        }

        private void ProfesionalDeLaSalud(object sender, EventArgs e)
        {
            menuGeneral.Visible = false;
            altaProfesional.Show();            
        }

        private void Diagnostico(object sender, EventArgs e)
        {

        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void vistaPacientes_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            menuContextPaciente.Visible = true;
            menuPaciente.Visible = false;
        }

        private void vistaContextPaciente_Enter(object sender, EventArgs e)
        {

        }

        private void Division1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
