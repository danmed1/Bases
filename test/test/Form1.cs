using System;
using System.Collections.Generic;
using System.Collections;

using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
//using Microsoft.Office.Tools.Word;
using System.Diagnostics;


namespace test
{
    public partial class Form1 : Form
    {
        private String SeguroSocialPacientePS = "12345";
        private String idProfSalLogin = "Daniel@Hticoman.com";
        private String idMedicTratante = "1016";

        private static Object oMissing = System.Reflection.Missing.Value;

        private static Object oTemplatePath = "";

        private const String txtNHospitalNI = "1726178585";//0
        private const String fechaElabNI = "1001166377";//1
        private const String txtDirHNI = "378211563";//2

        private const String txtNMTratNI = "1372887101";//3
        private const String txtEspeNI = "485905416";//4
        private const String txtNcedMtratNI = "3321671902";//5

        private const String txtNSSNI = "575868325";//6
        private const String txtNomPNI = "1701207138";//7
        private const String txtApPatPNI = "2411188545";//8
        private const String txtApMatPNI = "3027040718";//9
        private const String txtGenPNI = "1462076139";//10
        private const String fNacPNI = "2900150605";//11
        private const String txtDomPNI = "2559662763";//12
        private const String txtEscPNI = "3347958648";//13
        private const String txtEtnPNI = "825245716";//14
        private const String txtRelPNI = "251392476";//15

        private const String cmbHosProcNI = "635688600";//16
        private const String txtMotIngreNI = "2318756361";//17
        private const String txtObservNI = "3527728851";//18
        private const String txtMedElabNI = "1129599720";//19
        private const String txtCedElabNI = "1935319829";//20

        private int newNoteId;

        private Microsoft.Office.Interop.Word.Application wordApp;
        private Microsoft.Office.Interop.Word.Document wordDoc;


        private ContentControl[] contentControlsNI;
        private ContentControl[] contentControlsNA;




        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            oTemplatePath = Path.Combine(outPutDirectory, "TemplateFolder\\Nota_Ingreso.dotx");
            wordApp = new Microsoft.Office.Interop.Word.Application();
            wordDoc = new Microsoft.Office.Interop.Word.Document();
            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);
            wordApp.DocumentBeforeSave += wordApp_DocumentBeforeSave;
            wordApp.DefaultSaveFormat = "";

            contentControlsNI = new ContentControl[23];
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password");

            connection.Open();
            fillContentControlsNI(wordDoc);
            fillHospUserFields(connection);
            fillTratanteFields(connection);
            fillPacienteFields(connection);
            fillHospCombo(connection);
            connection.Close();
            wordApp.Visible = true;
            //wordApp.Application.Quit();



        }

        void wordApp_DocumentBeforeSave(Document Doc, ref bool SaveAsUI, ref bool Cancel)
        {
            int idTiempo = 0;
            SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password");
            SqlCommand getIDTiempo = new SqlCommand("Select Id_Tiempo from Tiempo where Anio=@Anio and Mes=@Mes and Dia=@Dia");
            SqlDataReader reader = getIDTiempo.ExecuteReader();
            if (reader.Read())
            {
                idTiempo = reader.GetInt32(0);
            }
            reader.Close();
            SqlCommand cmd = new SqlCommand("INSERT INTO Nota_Gen  (NumSeguroSocial,Id_Profesional_Salud_MT,Id_Hospital,Clave_Diagnostico,Id_Profesional_Salud_Elab,Id_Tiempo,tipo)VALUES (@NumSeguroSocial,@Id_Profesional_Salud_MT,@Id_Hospital,@Clave_Diagnostico,@Id_Profesional_Salud_Elab,@Id_Tiempo,@tipo);SELECT CAST(scope_identity() AS int)", connection);
            cmd.Parameters.AddWithValue("NumSeguroSocial", SeguroSocialPacientePS);
            cmd.Parameters.AddWithValue("Id_Profesional_Salud_MT", idMedicTratante);
            cmd.Parameters.AddWithValue("Id_Hospital", null);
            cmd.Parameters.AddWithValue("Clave_Diagnostico", null);
            cmd.Parameters.AddWithValue("Id_Profesional_Salud_Elab", null);
            cmd.Parameters.AddWithValue("Id_Tiempo", idTiempo);
            cmd.Parameters.AddWithValue("tipo", "Ingreso");
            newNoteId = (int)cmd.ExecuteScalar();
            foreach (ContentControlListEntry a in contentControlsNI[16].DropdownListEntries)
            {
                if (a.Text.Equals(contentControlsNI[16].Range.Text))
                {

                }
            }

            //wordApp.Application.Quit();
        }

        private void fillContentControlsNI(Document wordDoc)
        {
            foreach (Microsoft.Office.Interop.Word.ContentControl test in wordDoc.ContentControls)
            {
                switch (test.ID)
                {

                    case txtNHospitalNI: contentControlsNI[0] = test;

                        break;
                    case fechaElabNI:
                        contentControlsNI[1] = test;
                        test.Range.Text = DateTime.Now.ToString("M/d/yyyy");
                        test.LockContents = true;
                        test.LockContentControl = true;
                        break;
                    case txtDirHNI:
                        contentControlsNI[2] = test;
                        break;
                    case txtNMTratNI:
                        contentControlsNI[3] = test;
                        break;
                    case txtEspeNI:
                        contentControlsNI[4] = test;
                        break;
                    case txtNcedMtratNI:
                        contentControlsNI[5] = test;
                        break;
                    case txtNSSNI:
                        contentControlsNI[6] = test;
                        break;
                    case txtNomPNI:
                        contentControlsNI[7] = test;
                        break;
                    case txtApPatPNI:
                        contentControlsNI[8] = test;
                        break;
                    case txtApMatPNI:
                        contentControlsNI[9] = test;
                        break;
                    case txtGenPNI:
                        contentControlsNI[10] = test;
                        break;
                    case fNacPNI:
                        contentControlsNI[11] = test;
                        break;
                    case txtDomPNI:
                        contentControlsNI[12] = test;
                        break;
                    case txtEscPNI:
                        contentControlsNI[13] = test;
                        break;
                    case txtEtnPNI:
                        contentControlsNI[14] = test;
                        break;
                    case txtRelPNI:
                        contentControlsNI[15] = test;
                        break;
                    case cmbHosProcNI:
                        contentControlsNI[16] = test;
                        break;
                    case txtMotIngreNI:
                        contentControlsNI[17] = test;
                        break;
                    case txtObservNI:
                        contentControlsNI[18] = test;
                        break;
                    case txtMedElabNI:
                        contentControlsNI[19] = test;
                        break;
                    case txtCedElabNI:
                        contentControlsNI[20] = test;
                        break;
                }
            }

        }

        private void fillTratanteFields(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from mezclado WHERE Id_Profesional_Salud = @IDPS", connection);
            cmd.Parameters.AddWithValue("IDPS", idMedicTratante);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                // Read advances to the next row.
                while (reader.Read())
                {
                    contentControlsNI[3].Range.Text = reader.GetString(reader.GetOrdinal("Nombre_PS"));
                    contentControlsNI[4].Range.Text = reader.GetString(reader.GetOrdinal("Especialidad"));
                    contentControlsNI[5].Range.Text = reader.GetString(reader.GetOrdinal("No_Cedula"));

                }
            }
            contentControlsNI[3].LockContentControl = true;
            contentControlsNI[3].LockContents = true;
            contentControlsNI[4].LockContentControl = true;
            contentControlsNI[4].LockContents = true;
            contentControlsNI[5].LockContentControl = true;
            contentControlsNI[5].LockContents = true;
            reader.Close();
        }
        private void fillHospUserFields(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from MedHospPer WHERE Username = @Username", connection);
            cmd.Parameters.AddWithValue("Username", idProfSalLogin);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                // Read advances to the next row.
                while (reader.Read())
                {
                    String nComplElab = reader.GetString(reader.GetOrdinal("Nombre_PS")) + " " + reader.GetString(reader.GetOrdinal("Ap_Pat")) + " " + reader.GetString(reader.GetOrdinal("Ap_Mat"));
                    contentControlsNI[0].Range.Text = reader.GetString(reader.GetOrdinal("Nombre_H"));
                    contentControlsNI[2].Range.Text = reader.GetString(reader.GetOrdinal("Direccion"));
                    contentControlsNI[19].Range.Text = nComplElab;
                    contentControlsNI[20].Range.Text = reader.GetString(reader.GetOrdinal("No_Cedula"));
                }
            }
            reader.Close();
            contentControlsNI[0].LockContentControl = true;
            contentControlsNI[0].LockContents = true;
            contentControlsNI[2].LockContentControl = true;
            contentControlsNI[2].LockContents = true;
            contentControlsNI[19].LockContentControl = true;
            contentControlsNI[19].LockContents = true;
            contentControlsNI[20].LockContentControl = true;
            contentControlsNI[20].LockContents = true;
        }

        private void fillPacienteFields(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT * from Paciente WHERE NumSeguroSocial = @Nss", connection);
            cmd.Parameters.AddWithValue("Nss", SeguroSocialPacientePS);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                // Read advances to the next row.
                while (reader.Read())
                {
                    contentControlsNI[6].Range.Text = reader.GetString(reader.GetOrdinal("NumSeguroSocial")); //NoSeguroSocial                    
                    contentControlsNI[7].Range.Text = reader.GetString(reader.GetOrdinal("Nombre_P")); //Nombre Paciente
                    contentControlsNI[8].Range.Text = reader.GetString(reader.GetOrdinal("Ap_PatP")); //ApellidoPaternoPaciente
                    contentControlsNI[9].Range.Text = reader.GetString(reader.GetOrdinal("Ap_MatP")); //ApellidoMaternoPaciente
                    contentControlsNI[10].Range.Text = reader.GetDateTime(reader.GetOrdinal("F_Nac")).ToString(); //GeneroPaciente
                    contentControlsNI[11].Range.Text = reader.GetString(reader.GetOrdinal("Genero")); //FechaNacPaciente
                    contentControlsNI[12].Range.Text = reader.GetString(reader.GetOrdinal("Domicilio")); //DomicilioPaciente
                    contentControlsNI[13].Range.Text = reader.GetString(reader.GetOrdinal("Escolaridad")); //EsolaridadPaciente
                    contentControlsNI[14].Range.Text = reader.GetString(reader.GetOrdinal("Etnia")); //EtniaPaciaente
                    contentControlsNI[15].Range.Text = reader.GetString(reader.GetOrdinal("Religion")); //ReligionPaciente

                }
                reader.Close();
                contentControlsNI[6].LockContentControl = true;
                contentControlsNI[6].LockContents = true;
                contentControlsNI[7].LockContentControl = true;
                contentControlsNI[7].LockContents = true;
                contentControlsNI[8].LockContentControl = true;
                contentControlsNI[8].LockContents = true;
                contentControlsNI[9].LockContentControl = true;
                contentControlsNI[9].LockContents = true;
                contentControlsNI[10].LockContentControl = true;
                contentControlsNI[10].LockContents = true;
                contentControlsNI[11].LockContentControl = true;
                contentControlsNI[11].LockContents = true;
                contentControlsNI[12].LockContentControl = true;
                contentControlsNI[12].LockContents = true;
                contentControlsNI[13].LockContentControl = true;
                contentControlsNI[13].LockContents = true;
                contentControlsNI[14].LockContentControl = true;
                contentControlsNI[14].LockContents = true;
                contentControlsNI[15].LockContentControl = true;
                contentControlsNI[15].LockContents = true;
            }
        }
        private void fillHospCombo(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("SELECT Id_Hospital,Nombre_H from Hospital", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            if (reader.HasRows)
            {
                // Read advances to the next row.
                while (reader.Read())
                {
                    String nombre = reader.GetString(1);
                    String id = reader.GetInt32(0).ToString();

                    contentControlsNI[16].DropdownListEntries.Add(nombre, id, i);

                    i++;
                }
            }
            reader.Close();
            contentControlsNI[16].LockContentControl = true;


        }

    }
}


