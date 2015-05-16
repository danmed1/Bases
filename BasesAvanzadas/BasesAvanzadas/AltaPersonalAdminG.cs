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
    public partial class AltaPersonalAdminG : Form
    {
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        public AltaPersonalAdminG()
        {
            InitializeComponent();
            mostrarHospital();
            mostrarEspecialidad();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void mostrarHospital()
        {

            SqlConnection conn = new SqlConnection(conexionBase);
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT Id_Hospital as IDH,Nombre_H AS Hospital FROM VistaMaestra", conn);
            SqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("IDH", typeof(string));
            dt.Columns.Add("Hospital", typeof(string));
            dt.Load(reader);

            cbHospital.ValueMember = "IDH";
            cbHospital.DisplayMember = "Hospital";
            cbHospital.DataSource = dt;

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
                SqlCommand cmd = new SqlCommand("INSERT INTO Profesional_Salud (Nombre_PS,Ap_Pat,Ap_Mat,No_Cedula,Id_Especialidad)  OUTPUT INSERTED.Id_Profesional_Salud VALUES (@Name,@Paterno,@Materno,@Cedula,@Especialidad);", con);
                cmd.Parameters.AddWithValue("@Name", tbNombre.Text);
                cmd.Parameters.AddWithValue("@Paterno", tbApPat.Text);
                cmd.Parameters.AddWithValue("@Materno", tbApMat.Text);
                cmd.Parameters.AddWithValue("@Cedula", tbCedula.Text);
                cmd.Parameters.AddWithValue("@Especialidad", cbEspecialidad.SelectedValue);

                con.Open();
                int x = (int)cmd.ExecuteScalar();

                SqlCommand cmd1 = new SqlCommand("INSERT INTO Hospital_Profesional_Salud (Id_Profesional_Salud,Id_Hospital,Username,Password,Id_Perfil) VALUES (" + x + ",@Hospital,@Username,@Password,3);", con);
                cmd1.Parameters.AddWithValue("@Hospital", cbHospital.SelectedValue);
                cmd1.Parameters.AddWithValue("@Username", tbUsuario.Text);
                cmd1.Parameters.AddWithValue("@Password", tbPassword.Text);

                cmd1.ExecuteNonQuery();
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
