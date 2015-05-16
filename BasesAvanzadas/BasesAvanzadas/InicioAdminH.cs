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


using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace BasesAvanzadas
{

    public partial class InicioAdminH : Form
    {
        public string mandarDato;
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";                        
        int hospital = Login.hospitalUsuario;
        AltaPersonalAdminH altaPersonalAdminH = new AltaPersonalAdminH();
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

        
        private void filtradoPersonal()
        {
            SqlConnection con = new SqlConnection(conexionBase);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                
                ////-----Busquedas en Personal------                

                cmd = new SqlCommand("SELECT Id_Profesional_Salud,Nombre_PS,Ap_Pat,Ap_Mat,No_Cedula,Descripcion_Perfil,Descripcion_Especialidad,Id_Hospital FROM VistaMaestra WHERE Id_Hospital="+hospital +" AND Nombre_PS LIKE '%" + nombrePersonal.Text + "%' AND (Ap_Pat LIKE '%" + apellidoPersonal.Text + "%' OR Ap_Mat LIKE '%" + apellidoPersonal.Text + "%');", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("Id_Profesional_Salud", typeof(string));
                    dt.Columns.Add("Nombre_PS", typeof(string));
                    dt.Columns.Add("Ap_Pat", typeof(string));
                    dt.Columns.Add("Ap_Mat", typeof(string));
                    dt.Columns.Add("No_Cedula", typeof(string));
                    dt.Columns.Add("Descripcion_Perfil", typeof(string));
                    dt.Columns.Add("Descripcion_Especialidad", typeof(string));
                    dt.Columns.Add("Id_Hospital", typeof(string));
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
            altaPersonalAdminH.ShowDialog();
        }

        private void buscarDetallesPersonalBoton_Click(object sender, EventArgs e)
        {
            String apellidoP = apellidoPersonal.Text;
            String nombreP = nombrePersonal.Text;

            if (!apellidoP.Equals(""))
            {
                
            }
        }

        private void nombrePersonal_TextChanged(object sender, EventArgs e)
        {
            filtradoPersonal();
        }

        private void apellidoPersonal_TextChanged(object sender, EventArgs e)
        {
            filtradoPersonal();
        }

        private void InicioAdminH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoDBADataSet21.Profesional_Salud' table. You can move, or remove it, as needed.
            this.profesional_SaludTableAdapter.Fill(this.proyectoDBADataSet21.Profesional_Salud,hospital);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

    }
}
