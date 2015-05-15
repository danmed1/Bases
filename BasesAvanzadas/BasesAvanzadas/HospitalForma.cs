using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BasesAvanzadas
{
    public partial class HospitalForma : Form
    {
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        public HospitalForma()
        {
            InitializeComponent();
            guardarHospitalBoton.Visible = false;
        }

        private void modificarHospitalesBoton_Click(object sender, EventArgs e)
        {
            guardarHospitalBoton.Visible = true;
        }

        private void regresarMenuHospitalBoton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarHospitalBoton_Click(object sender, EventArgs e)
        {

        }
    }
}
