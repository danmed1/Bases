using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Paciente(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=COMPULI;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password");
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO paciente (NumSeguroSocial, Nombre,Ap_Pat,Ap_Mat,Genero,Domicilio,Escolaridad,Etnia,Religion) VALUES (@Secure,@Name,@Paterno,@Materno,@Genero,@Domic,@Escol,@Etnia,@Religion);",con);
                cmd.Parameters.AddWithValue("@Secure",tbSeguro.Text);
                cmd.Parameters.AddWithValue("@Name", tbName.Text);
                cmd.Parameters.AddWithValue("@Paterno", tbPaterno.Text);
                cmd.Parameters.AddWithValue("@Materno", tbMaterno.Text);
                cmd.Parameters.AddWithValue("@Genero", cbGenero.Text);
                cmd.Parameters.AddWithValue("@Domic", tbDomicilio.Text);
                cmd.Parameters.AddWithValue("@Escol", tbEscolaridad.Text);
                cmd.Parameters.AddWithValue("@Etnia", tbEtnia.Text);
                cmd.Parameters.AddWithValue("@Religion", tbReligion.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }
    }
}
