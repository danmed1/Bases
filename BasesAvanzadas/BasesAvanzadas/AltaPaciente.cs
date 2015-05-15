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
    public partial class AltaPaciente : Form
    {
        private string conexionBase = "Data Source=wc064g5hsn.database.windows.net;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Alejandro;Password=Guanabana1";
        public AltaPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void bGuardar_Click(object sender, EventArgs e)
        {

        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Paciente(object sender, EventArgs e)
        {            
            SqlConnection con = new SqlConnection(conexionBase);
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Paciente (NumSeguroSocial,Nombre_P,Ap_PatP,Ap_MatP,F_Nac,Genero,Domicilio, Escolaridad, Etnia, Religion) VALUES (@Seguro,@Name,@Paterno,@Materno,@FechaNac,@Genero,@Domicilio,@Escolaridad,@Etnia,@Religion);", con);
                cmd.Parameters.AddWithValue("@Seguro", tbSeguro.Text);
                cmd.Parameters.AddWithValue("@Name", tbNombrePaciente.Text);
                cmd.Parameters.AddWithValue("@Paterno", tbApPatPaciente.Text);
                cmd.Parameters.AddWithValue("@Materno", tbApMatPaciente.Text);
                cmd.Parameters.AddWithValue("@FechaNac", dateFechaNac.Value);
                cmd.Parameters.AddWithValue("@Genero", cbGenero.Text);
                cmd.Parameters.AddWithValue("@Domicilio", tbDomicilio.Text);
                cmd.Parameters.AddWithValue("@Escolaridad", cbEscolaridad.Text);
                cmd.Parameters.AddWithValue("@Etnia", tbEtnia.Text);
                cmd.Parameters.AddWithValue("@Religion", tbReligión.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }

    }
}
