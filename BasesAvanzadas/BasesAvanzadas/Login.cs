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
    public partial class Login : Form
    {

        private string conexionBase = "Data Source=wc064g5hsn.database.windows.net;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Alejandro;Password=Guanabana1";
        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void entrar_Click(object sender, EventArgs e)
        {

            //
            //SqlConnection con = new SqlConnection("Data Source=192.168.0.12;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Alejandro;Password=Guanabana1");
            //{
            //    con.Open();
            //    SqlCommand cmd = new SqlCommand();

            //    ////-----Busquedas en Pacientes------

            //    cmd = new SqlCommand("SELECT * FROM Paciente WHERE NumSeguroSocial LIKE '%" + segurosocialPaciente.Text + "%' and Nombre_P LIKE '%" + nombrePaciente.Text + "%' and Ap_PatP LIKE '%" + apellidoPaciente.Text + "%';", con);

            //    SqlDataReader reader = cmd.ExecuteReader();
            //    DataTable dt = new DataTable();
            //    if (reader.HasRows)
            //    {
            //        dt.Columns.Add("NumSeguroSocial", typeof(string));
            //        dt.Columns.Add("Nombre_P", typeof(string));
            //        dt.Columns.Add("Ap_PatP", typeof(string));
            //        dt.Columns.Add("Ap_Mat", typeof(string));
            //        dt.Columns.Add("F_Nac", typeof(DateTime));
            //        dt.Columns.Add("Genero", typeof(char));
            //        dt.Columns.Add("Domicilio", typeof(string));
            //        dt.Columns.Add("Escolaridad", typeof(string));
            //        dt.Columns.Add("Etnia", typeof(string));
            //        dt.Columns.Add("Religion", typeof(string));
            //        dt.Load(reader);

            //        dataGridView2.DataSource = dt;

            //        Console.Write("i have rows");

            //    }
            //    else
            //    {
            //        Console.Write("no rows");
            //    }
            //    con.Close();
            //}

            //

        }
    }
}
