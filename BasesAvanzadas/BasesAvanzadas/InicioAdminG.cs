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
    public partial class InicioAdminG : Form
    {
        public string mandarDato;
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        private string SeguroSocialPacientePS;
        private int idProfSalLogIn;
        private int idMedicTratante;
        AltaPersonalAdminG altaPersonalAdminG = new AltaPersonalAdminG();
        FormHospital altaHospital = new FormHospital();
        AltaPaciente altaPaciente = new AltaPaciente();
        public InicioAdminG()
        {
            InitializeComponent();            
            menuHospital.Visible = false;
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

                cmd = new SqlCommand("SELECT Nombre_PS as Nombre, Ap_Pat as Apellido_P , Ap_Mat as Apellido_M , Descripcion_Especialidad as Especialidad ,Nombre_H as Hospital FROM VistaMaestra WHERE Id_Perfil = 3 AND Nombre_ps LIKE '%" + nombrePersonal.Text + "%' AND (Ap_Pat LIKE '%" + apellidoPersonal.Text + "%' OR Ap_Mat LIKE '%" + apellidoPersonal.Text + "%');", con);
               //cmd = new SqlCommand("SELECT Id_Profesional_Salud,Nombre_PS,Ap_Pat,Ap_Mat,No_Cedula,Descripcion_Perfil,Descripcion_Especialidad,Id_Hospital FROM VistaMaestra WHERE Nombre_ps LIKE '%" + nombrePersonal.Text + "%' AND (Ap_Pat LIKE '%" + apellidoPersonal.Text + "%' OR Ap_Mat LIKE '%" + apellidoPersonal.Text + "%');", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("Nombre", typeof(string));
                    dt.Columns.Add("Apellido_P", typeof(string));
                    dt.Columns.Add("Apellido_M", typeof(string));
                    dt.Columns.Add("Especialidad", typeof(string));
                    dt.Columns.Add("Hospital", typeof(string));
                    dt.Load(reader);

                    dataGridView1.DataSource = dt;
                }
                else
                {
                    dataGridView1.DataSource = dt;
                }
                con.Close();
            }

        }

        private void altasHospitalBoton_Click(object sender, EventArgs e)
        {
            FormHospital fomraprueba = new FormHospital();
            fomraprueba.Show();
        }

        private void modificarHospitalBoton_Click(object sender, EventArgs e)
        {
            HospitalForma hospitalforma = new HospitalForma();
            hospitalBoton.Show();
        }

        private void hospitalBoton_Click(object sender, EventArgs e)
        {
            menuHospital.Visible = true;
            menuGeneral.Visible = false;
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

        private void regresarMenuGeneralBoton_Click(object sender, EventArgs e)
        {
            menuHospital.Visible = false;
            menuGeneral.Visible = true;
        }

        private void modicarDatosPersonalBoton_Click(object sender, EventArgs e)
        {

        }

        private void altaDatosPersonal_Click(object sender, EventArgs e)
        {            
            altaPersonalAdminG.ShowDialog();
        }

        private void buscarDetallesPersonalBoton_Click(object sender, EventArgs e)
        {
            filtradoPersonal();
        }
                
        private void textBoxHospitalNombre_TextChanged(object sender, EventArgs e)
        {
            filtrarHospital();
        }

        private void textBoxDireccionHospital_TextChanged(object sender, EventArgs e)
        {
            filtrarHospital();
        }

        public void filtrarHospital() {
            SqlConnection con = new SqlConnection(conexionBase);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                ////-----Busquedas en Pacientes------                
                cmd = new SqlCommand("SELECT * FROM Hospital WHERE Nombre_H LIKE '%" + textBoxHospitalNombre.Text + "%' and Direccion LIKE '%" + textBoxDireccionHospital.Text + "%';", con);                

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("Nombre_H", typeof(string));
                    dt.Columns.Add("Direccion", typeof(string));
                    dt.Load(reader);

                    dataGridView4.DataSource = dt;
                }
                else dataGridView4.DataSource = dt;
                con.Close();
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

        private void InicioAdminG_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet5.VistaMaestra' Puede moverla o quitarla según sea necesario.
            this.vistaMaestraTableAdapter1.Fill(this.proyectoDBADataSet5.VistaMaestra);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.vistaMaestraTableAdapter.FillBy(this.proyectoDBADataSet4.VistaMaestra);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombrePersonal.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            apellidoPersonal.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
        

    }
}
