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
using Microsoft.Office.Core;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace BasesAvanzadas
{
    public partial class InicioDoctor : Form
    {
        public string mandarDato;
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        private string SeguroSocialPacientePS;
        private int idProfSalLogIn;
        private int idMedicTratante;        
        FormHospital altaHospital = new FormHospital();
        AltaPaciente altaPaciente = new AltaPaciente();
        public InicioDoctor()
        {
            InitializeComponent();
            menuPaciente.Visible = false;
            menuContextPaciente.Visible = false;
            menuAgregarNotas.Visible = false;
            menuVerNota.Visible = false;            
            menuPersonal.Visible = false;
        }

        private void Pacientes(object sender, EventArgs e)
        {
            menuPaciente.Visible = true;
            menuGeneral.Visible = false;
        }
        private void Personal(object sender, EventArgs e) {
            menuPersonal.Visible = true;
            menuGeneral.Visible = false;
        }

        private void Salir(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void Hospital(object sender, EventArgs e)
        {
            menuGeneral.Visible = false;
            altaHospital.Show();
        }
        private void botonBuscarPaciente_Click(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        public void filtradoPacientes()
        {

            SqlConnection con = new SqlConnection(conexionBase);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                ////-----Busquedas en Pacientes------

                cmd = new SqlCommand("SELECT * FROM Paciente WHERE NumSeguroSocial LIKE '%" + segurosocialPaciente.Text + "%' and Nombre_P LIKE '%" + nombrePaciente.Text + "%' and (Ap_PatP LIKE '%" + apellidoPaciente.Text + "%' or Ap_MatP LIKE '%" + apellidoPaciente.Text + "%');", con);
                
                SqlDataReader reader = cmd.ExecuteReader();
                System.Data.DataTable dt = new System.Data.DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("NumSeguroSocial", typeof(string));
                    dt.Columns.Add("Nombre_P", typeof(string));
                    dt.Columns.Add("Ap_PatP", typeof(string));
                    dt.Columns.Add("Ap_Mat", typeof(string));
                    dt.Columns.Add("F_Nac", typeof(DateTime));
                    dt.Columns.Add("Genero", typeof(char));
                    dt.Columns.Add("Domicilio", typeof(string));
                    dt.Columns.Add("Escolaridad", typeof(string));
                    dt.Columns.Add("Etnia", typeof(string));
                    dt.Columns.Add("Religion", typeof(string));
                    dt.Load(reader);

                    dataGridView2.DataSource = dt;

                    Console.Write("i have rows");

                }
                else
                {
                    dataGridView2.DataSource = dt;
                }
                con.Close();
            }
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
                System.Data.DataTable dt = new System.Data.DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("Nombre_ps", typeof(string));
                    dt.Columns.Add("Ap_Pat", typeof(string));
                    dt.Columns.Add("Ap_Mat", typeof(string));
                    dt.Columns.Add("Descripcion_Perfil", typeof(string));
                    dt.Columns.Add("Descripcion_Especialidad", typeof(string));
                    dt.Load(reader);

                    dataGridView3.DataSource = dt;
                }
                else
                {
                    dataGridView3.DataSource = dt;
                }
                con.Close();
            }

        }

        private void agregarNotaBoton_Click(object sender, EventArgs e)
        {
            menuContextPaciente.Visible = false;
            menuAgregarNotas.Visible = true;
        }

        private void verNotaBoton_Click(object sender, EventArgs e)
        {
            menuVerNota.Visible = true;
            menuContextPaciente.Visible = false;

            SqlConnection con = new SqlConnection(conexionBase);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();


                cmd = new SqlCommand("select Id_Nota_Gen,tipo,Dia,Mes,Anio from Nota_Gen as ng inner join Tiempo as t on ng.Id_Tiempo = t.Id_Tiempo where NumSeguroSocial ='"+segurosocialPaciente.Text+"';", con);
                SqlDataReader reader = cmd.ExecuteReader();
                System.Data.DataTable dt = new System.Data.DataTable();
                if (reader.HasRows)
                {
                    dt.Columns.Add("Id_Nota_Gen", typeof(string));
                    dt.Columns.Add("tipo", typeof(string));
                    dt.Columns.Add("Dia", typeof(int));
                    dt.Columns.Add("Mes", typeof(int));
                    dt.Columns.Add("Anio", typeof(int));
                    dt.Load(reader);

                    dataGridViewNotas.DataSource = dt;

                }
                else
                {
                    dataGridViewNotas.DataSource = dt;
                }
                con.Close();
            }
            mostrarIdNotas();

            //
        }

        private void datosBoton_Click(object sender, EventArgs e)
        {
            DatosForma datosForma = new DatosForma(mandarDato, SeguroContextoPaciente.Text);
            datosForma.Show();
        }

        private void altasHospitalBoton_Click(object sender, EventArgs e)
        {
            ////PON AQUI TU FORMA MEMO
            FormHospital fomraprueba = new FormHospital();
            fomraprueba.Show();
        }
                

        private void regresarPacienteMenuBoton_Click(object sender, EventArgs e)
        {
            menuContextPaciente.Visible = false;
            menuPaciente.Visible = true;
        }

        private void expedienteBoton_Click(object sender, EventArgs e)
        {
            //cosas de word
        }

        private void menuGeneral_Enter(object sender, EventArgs e)
        {
            AutoSize = true;

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet3.Nota_Gen' Puede moverla o quitarla según sea necesario.
            this.nota_GenTableAdapter.Fill(this.proyectoDBADataSet3.Nota_Gen);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet2.Profesional_Salud' Puede moverla o quitarla según sea necesario.
            this.profesional_SaludTableAdapter.Fill(this.proyectoDBADataSet2.Profesional_Salud);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet1.Hospital' Puede moverla o quitarla según sea necesario.
            this.hospitalTableAdapter.Fill(this.proyectoDBADataSet1.Hospital);
            // TODO: esta línea de código carga datos en la tabla 'proyectoDBADataSet.Paciente' Puede moverla o quitarla según sea necesario.
            this.pacienteTableAdapter.Fill(this.proyectoDBADataSet.Paciente);

            VerMasBoton.Hide();
        }

        private void regresarMenuPrincipalBoton_Click(object sender, EventArgs e)
        {
            menuPersonal.Visible = false;
            menuGeneral.Visible = true;
        }

        private void regresarMenuNotaBoton_Click(object sender, EventArgs e)
        {
            menuVerNota.Visible = false;
            menuContextPaciente.Visible = true;
        }

        private void botonMenuGenera_Click(object sender, EventArgs e)
        {
            menuPaciente.Visible = false;
            menuGeneral.Visible = true;
        }
        
        private void regresarMenuContexPacienteBoton_Click(object sender, EventArgs e)
        {
            menuAgregarNotas.Visible = false;
            menuContextPaciente.Visible = true;
        }

        private void modicarDatosPersonalBoton_Click(object sender, EventArgs e)
        {

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

        private void VerMasBoton_Click(object sender, EventArgs e)
        {
                menuContextPaciente.Visible = true;
                menuPaciente.Visible = false;
                nombreContextoPaciente.Text = nombrePaciente.Text + " " + apellidoPaciente.Text;
                mandarDato = nombrePaciente.Text + "," + apellidoPaciente.Text;
                SeguroContextoPaciente.Text = segurosocialPaciente.Text;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombrePaciente.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            apellidoPaciente.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            SeguroSocialPacientePS = segurosocialPaciente.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            nombrePaciente.Show();
            apellidoPaciente.Show();
            segurosocialPaciente.Show();
            VerMasBoton.Show();
        }

        private void nombrePaciente_TextChanged(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        private void apellidoPaciente_TextChanged(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        private void segurosocialPaciente_TextChanged(object sender, EventArgs e)
        {
            filtradoPacientes();
        }

        private void botonAltaPaciente_Click(object sender, EventArgs e)
        {
            altaPaciente.ShowDialog();
            //Hide
        }
                
        private void nombrePersonal_TextChanged(object sender, EventArgs e)
        {
            filtradoPersonal();
        }

        private void apellidoPersonal_TextChanged(object sender, EventArgs e)
        {
            filtradoPersonal();
        }

        private void dataGridViewNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void verWord() {

            XmlDocument xdoc = new XmlDocument();

            SqlConnection con = new SqlConnection(conexionBase);
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                ////-----Busquedas en Personal------                

                cmd = new SqlCommand("select Doc from Nota_Gen as ng inner join Tiempo as t on ng.Id_Tiempo = t.Id_Tiempo where NumSeguroSocial ="+segurosocialPaciente.Text+" AND Id_Nota_Gen ="+comboBoxIDNotas.SelectedValue+";", con);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    using (XmlReader xml = reader.GetSqlXml(0).CreateReader())
                    {
                        xdoc.Load(xml);
                    }

                }
                con.Close();
            }
            xdoc.Save("C:\\Users\\moises\\Documents\\escuela\\8 sem\\bases\\Prueba1\\BasesAvanzadas\\BasesAvanzadas\\ArchivosXml\\intento.xml");

            var applicationWord = new Microsoft.Office.Interop.Word.Application();

            
            string ruta = "C:\\Users\\moises\\Documents\\escuela\\8 sem\\bases\\Prueba1\\BasesAvanzadas\\BasesAvanzadas\\ArchivosXml\\intento.xml";                        

            applicationWord.Documents.Open(ruta);
            applicationWord.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            verWord();
        }

        private void mostrarIdNotas() {

            SqlConnection conn = new SqlConnection(conexionBase);
            conn.Open();
            SqlCommand sc = new SqlCommand("select Id_Nota_Gen from Nota_Gen as ng inner join Tiempo as t on ng.Id_Tiempo = t.Id_Tiempo where NumSeguroSocial =" + segurosocialPaciente.Text + ";", conn);
            //SqlDataReader reader = sc.ExecuteReader();
            SqlDataReader r = sc.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.Add("Id_Nota_Gen", typeof(string));
            dt.Load(r);

            comboBoxIDNotas.ValueMember = "Id_Nota_Gen";
            comboBoxIDNotas.DisplayMember = "Id_Nota_Gen";
            comboBoxIDNotas.DataSource = dt;

            conn.Close();

        }
    }
}
