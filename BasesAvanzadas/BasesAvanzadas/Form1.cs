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
    public partial class Form1 : Form
    {
        Form2 siguienteForma = new Form2();
        Form3 formaPaciente = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void Pacientes(object sender, EventArgs e)
        {
            siguienteForma.Show();
        }

        private void ProfesionalDeLaSalud(object sender, EventArgs e)
        {
            formaPaciente.Show();
        }

        private void Diagnostico(object sender, EventArgs e)
        {

        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
