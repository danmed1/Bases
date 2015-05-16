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
    public partial class AltaPersonalAdminH : Form
    {
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        public AltaPersonalAdminH()
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
            SqlCommand sc = new SqlCommand("SELECT * FROM Perfil WHERE Id_Perfil=1 or Id_Perfil = 2", conn);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO Profesional_Salud (Nombre_PS,Ap_Pat,Ap_Mat,No_Cedula,Id_Especialidad)  OUTPUT INSERTED.Id_Profesional_Salud VALUES (@Name,@Paterno,@Materno,@Cedula,@Especialidad);", con);               
                
                cmd.Parameters.AddWithValue("@Name", tbNombre.Text);
                cmd.Parameters.AddWithValue("@Paterno", tbApPat.Text);
                cmd.Parameters.AddWithValue("@Materno", tbApMat.Text);
                cmd.Parameters.AddWithValue("@Cedula", tbCedula.Text);                
                cmd.Parameters.AddWithValue("@Especialidad", cbEspecialidad.SelectedValue);

                con.Open();
                int z = (int)cmd.ExecuteScalar();

                SqlCommand cmd2 = new SqlCommand("INSERT INTO Hospital_Profesional_Salud (Id_Profesional_Salud,Username,Password,Id_Perfil,Id_Hospital) VALUES ("+z+",@Usuario,@Password,@Perfil,@Hospital);", con);               

                cmd2.Parameters.AddWithValue("@Perfil", cbPerfil.SelectedValue);
                cmd2.Parameters.AddWithValue("@Usuario", tbUsuario.Text);
                cmd2.Parameters.AddWithValue("@Password", tbPassword.Text);
                cmd2.Parameters.AddWithValue("@Hospital", 5);                               
                                
                cmd2.ExecuteNonQuery();
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
