using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BasesAvanzadas
{
    public partial class DatosForma : Form
    {

        public DatosForma(string x, string y)
        {
            InitializeComponent();
            guardarModificadosBoton.Visible = false;
            labelApellidoM.Visible = false;
            labelApellidoP.Visible = false;
            labelDomicilio.Visible = false;
            labelReligion.Visible = false;
            labelEscolaridad.Visible = false;
            labelFecha.Visible = false;
            labelNombre.Visible = false;
            labelGenero.Visible = false;
            labelSeguroSocial.Visible = false;
            labelNumeroSeguroSocial.Visible = false;
            textBoxApellidoMaterno.Visible = false;
            textBoxApellidoPaterno.Visible = false;
            textBoxDomicilio.Visible = false;
            textBoxEscolaridad.Visible = false;
            textBoxNombre.Visible = false;
            textBoxReligion.Visible = false;
            fechaNacimiento.Visible = false;
            textBoxGenero.Visible = false;

            String[] nombre = x.Split(',');

            SqlConnection conn = new SqlConnection("Data Source=192.168.0.12;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password");
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM Paciente WHERE Nombre_P = '" + nombre[0] + "' AND Ap_PatP = '" + nombre[1] + "' AND NumSeguroSocial = '" + y + "';", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            if (reader.HasRows)
            {
                dt.Columns.Add("NumSeguroSocial", typeof(string));
                dt.Columns.Add("Nombre_P", typeof(string));
                dt.Columns.Add("Ap_PatP", typeof(string));
                dt.Columns.Add("Ap_MatP", typeof(string));
                dt.Columns.Add("F_Nac", typeof(DateTime));
                dt.Columns.Add("Genero", typeof(char));
                dt.Columns.Add("Domicilio", typeof(string));
                dt.Columns.Add("Escolaridad", typeof(string));
                dt.Columns.Add("Etnia", typeof(string));
                dt.Columns.Add("Religion", typeof(string));
                dt.Load(reader);

                dataGridViewEspecifica.DataSource = dt;
            }
            conn.Close();
        }

        private void regresarMenuContextPacienteBoton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modificarDatosBoton_Click(object sender, EventArgs e)
        {
            guardarModificadosBoton.Visible = true;
            labelApellidoM.Visible = true;
            labelApellidoP.Visible = true;
            labelDomicilio.Visible = true;
            labelReligion.Visible = true;
            labelEscolaridad.Visible = true;
            labelFecha.Visible = true;
            labelNombre.Visible = true;
            labelGenero.Visible = true;
            textBoxApellidoMaterno.Visible = true;
            textBoxApellidoPaterno.Visible = true;
            textBoxDomicilio.Visible = true;
            textBoxEscolaridad.Visible = true;
            textBoxNombre.Visible = true;
            textBoxReligion.Visible = true;
            fechaNacimiento.Visible = true;
            textBoxGenero.Visible = true;
            labelSeguroSocial.Visible = true;
            labelNumeroSeguroSocial.Visible = true;

        }


        private void DatosForma_Load(object sender, EventArgs e)
        {

        }

        private void guardarModificadosBoton_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=192.168.0.12;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password");
            conn.Open();
            SqlCommand sc = new SqlCommand("UPDATE Paciente set Nombre_P = '"+textBoxNombre.Text+"', Ap_PatP = '"+
                textBoxApellidoPaterno.Text+"', Ap_MatP = '"+textBoxApellidoMaterno.Text+"', F_Nac = '"+fechaNacimiento.Value.Date+"', Genero = '"+
                textBoxGenero.Text+"', Domicilio = '"+textBoxDomicilio.Text+"', Escolaridad = '"+textBoxEscolaridad.Text+"',Religion = '"+
                textBoxReligion.Text+"' where NumSeguroSocial = '"+labelSeguroSocial.Text+"';", conn);
            sc.ExecuteNonQuery();
            conn.Close();
            Close();
        }

        private void dataGridViewEspecifica_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombre.Text = dataGridViewEspecifica.CurrentRow.Cells[1].Value.ToString();
            textBoxApellidoPaterno.Text = dataGridViewEspecifica.CurrentRow.Cells[2].Value.ToString();
            textBoxApellidoMaterno.Text = dataGridViewEspecifica.CurrentRow.Cells[3].Value.ToString();
            fechaNacimiento.Value = DateTime.Parse(dataGridViewEspecifica.CurrentRow.Cells[4].Value.ToString());
            textBoxGenero.Text = dataGridViewEspecifica.CurrentRow.Cells[5].Value.ToString();
            textBoxDomicilio.Text = dataGridViewEspecifica.CurrentRow.Cells[6].Value.ToString();
            textBoxEscolaridad.Text = dataGridViewEspecifica.CurrentRow.Cells[7].Value.ToString();
            textBoxReligion.Text = dataGridViewEspecifica.CurrentRow.Cells[8].Value.ToString();
            labelSeguroSocial.Text = dataGridViewEspecifica.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
