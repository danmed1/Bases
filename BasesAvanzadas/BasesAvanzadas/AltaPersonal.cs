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
    public partial class AltaPersonal : Form
    {
        private string conexionBase = "Data Source=192.168.1.84;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        public AltaPersonal()
        {
            InitializeComponent();
            mostrarPerfil();            
            mostrarEspecialidad();        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void mostrarPerfil()
        {

            SqlConnection conn = new SqlConnection(conexionBase);
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM Perfil", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("Id_Perfil", typeof(string));
            dt.Columns.Add("Descripcion_Perfil", typeof(string));
            dt.Load(reader);

            cbPerfil.ValueMember = "Id_Perfil";
            cbPerfil.DisplayMember = "Descripcion_Perfil";
            cbPerfil.DataSource = dt;

            conn.Close();


        }
       
        private void mostrarEspecialidad()
        {

            SqlConnection conn = new SqlConnection(conexionBase);
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT * FROM Especialidad", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("Id_Especialidad", typeof(string));
            dt.Columns.Add("Descripcion_Especialidad", typeof(string));
            dt.Load(reader);

            cbEspecialidad.ValueMember = "Id_Especialidad";
            cbEspecialidad.DisplayMember = "Descripcion_Especialidad";
            cbEspecialidad.DataSource = dt;

            conn.Close();


        }

        private void Profesional(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conexionBase);
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Profesional_Salud (Nombre_PS,Ap_Pat,Ap_Mat,No_Cedula,Id_Perfil,Id_Especialidad) VALUES (@Name,@Paterno,@Materno,@Cedula,@Perfil,@Especialidad);", con);               
                cmd.Parameters.AddWithValue("@Name", tbNombre.Text);
                cmd.Parameters.AddWithValue("@Paterno", tbApPat.Text);
                cmd.Parameters.AddWithValue("@Materno", tbApMat.Text);
                cmd.Parameters.AddWithValue("@Cedula", tbCedula.Text);
                cmd.Parameters.AddWithValue("@Perfil", cbPerfil.SelectedValue);
                cmd.Parameters.AddWithValue("@Especialidad", cbEspecialidad.SelectedValue);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }

        private void tbApMat_TextChanged(object sender, EventArgs e)
        {

        }

        private void regresarMenuPaciente_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
