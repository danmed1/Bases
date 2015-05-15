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
    public partial class InicioAdminH : Form
    {
        public string mandarDato;
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        private string SeguroSocialPacientePS;
        private int idProfSalLogIn;
        private int idMedicTratante;
        AltaPersonal altaProfesional = new AltaPersonal();
        FormHospital altaHospital = new FormHospital();
        AltaPaciente altaPaciente = new AltaPaciente();
        public InicioAdminH()
        {
            InitializeComponent();            
            menuPersonal.Visible = false;
        }
        
        private void Personal(object sender, EventArgs e) {
            menuPersonal.Visible = true;
            menuGeneral.Visible = false;
        }

        private void Salir(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Hospital(object sender, EventArgs e)
        {
            menuGeneral.Visible = false;
            altaHospital.Show();
        }
        
        private void filtradoPersonal()
        {
            SqlConnection con = new SqlConnection(conexionBase);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                ////-----Busquedas en Personal------                

                cmd = new SqlCommand("SELECT Nombre_ps, Ap_Pat,Ap_Mat,Perfil.Descripcion_Perfil as Perfil,Especialidad.Descripcion_Especialidad as Especialidad FROM dbo.Profesional_Salud INNER JOIN dbo.Especialidad ON Profesional_Salud.Id_Especialidad=Especialidad.Id_Especialidad INNER JOIN dbo.Perfil ON Profesional_Salud.Id_Perfil=Perfil.Id_Perfil WHERE  Nombre_ps LIKE '%" + nombrePersonal.Text + "%' AND (Ap_Pat LIKE '%" + apellidoPersonal.Text + "%' OR Ap_Mat LIKE '%" + apellidoPersonal.Text + "%');", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("Nombre_ps", typeof(string));
                    dt.Columns.Add("Ap_Pat", typeof(string));
                    dt.Columns.Add("Ap_Mat", typeof(string));
                    dt.Columns.Add("Descripcion_Perfil", typeof(string));
                    dt.Columns.Add("Descripcion_Especialidad", typeof(string));
                    dt.Load(reader);

                    dataGridView3.DataSource = dt;

                    Console.Write("i have rows ");

                }
                else
                {
                    dataGridView3.DataSource = dt;
                }
                con.Close();
            }

        }
                
        private void altasHospitalBoton_Click(object sender, EventArgs e)
        {
            ////PON AQUI TU FORMA MEMO
            FormHospital fomraprueba = new FormHospital();
            fomraprueba.Show();
        }
                        
        private void menuGeneral_Enter(object sender, EventArgs e)
        {
            AutoSize = true;

        }
        
        private void regresarMenuPrincipalBoton_Click(object sender, EventArgs e)
        {
            menuPersonal.Visible = false;
            menuGeneral.Visible = true;
        }

        private void modicarDatosPersonalBoton_Click(object sender, EventArgs e)
        {

        }

        private void altaDatosPersonal_Click(object sender, EventArgs e)
        {
            AltaPersonal altaPersonal = new AltaPersonal();
            altaPersonal.ShowDialog();
        }

        private void buscarDetallesPersonalBoton_Click(object sender, EventArgs e)
        {
            String apellidoP = apellidoPersonal.Text;
            String nombreP = nombrePersonal.Text;

            if (!apellidoP.Equals(""))
            {
                
            }
        }

        private void menuVerNota_Enter(object sender, EventArgs e)
        {

        }

        private void nombrePersonal_TextChanged(object sender, EventArgs e)
        {
            filtradoPersonal();
        }

        private void apellidoPersonal_TextChanged(object sender, EventArgs e)
        {
            filtradoPersonal();
        }
        

    }
}
