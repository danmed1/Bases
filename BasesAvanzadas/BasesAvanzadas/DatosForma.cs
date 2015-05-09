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
    public partial class DatosForma : Form
    {
        public DatosForma()
        {
            InitializeComponent();
            guardarModificadosBoton.Visible = false;
        }

        private void regresarMenuContextPacienteBoton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modificarDatosBoton_Click(object sender, EventArgs e)
        {
            guardarModificadosBoton.Visible = true;
        }
    }
}
