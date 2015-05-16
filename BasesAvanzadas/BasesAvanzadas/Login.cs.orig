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

        
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
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
   
        public static int hospitalUsuario;
        private void entrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conexionBase);
            conn.Open();
            SqlCommand sc = new SqlCommand("SELECT Id_Perfil FROM Hospital_Profesional_Salud WHERE Username = '" + textBoxUsername.Text + "' AND Password = '" + textBoxPassword.Text + "';", conn);            
            sc.ExecuteNonQuery();
            
            SqlDataReader dReader = sc.ExecuteReader();
            

            int perfil = 0;
            while (dReader.Read())
            {
                perfil = dReader.GetInt32(0);
            }
            
            conn.Close();
            conn.Open();
            SqlCommand sc2 = new SqlCommand("SELECT Id_Hospital FROM Hospital_Profesional_Salud WHERE Username = '" + textBoxUsername.Text + "' AND Password = '" + textBoxPassword.Text + "';", conn);
            sc2.ExecuteNonQuery();
            SqlDataReader dReader2 = sc2.ExecuteReader();
            while (dReader2.Read())
            {
                hospitalUsuario = dReader2.GetInt32(0);
            }

            if (perfil == 0)
            {
                labelResultadoErroneo.Text = "Usuario o contraseña incorrectos";
            }

            else
            {                
                switch (perfil)
                {
                    case 1:
                        this.Hide();
                        InicioDoctor inicioDoc = new InicioDoctor();
                        inicioDoc.Closed += (s, args) => this.Close();
                        inicioDoc.Show();
                        break;
                    case 2:
                        this.Hide();
                        InicioDoctor inicioDoc2 = new InicioDoctor();
                        inicioDoc2.Closed += (s, args) => this.Close();
                        inicioDoc2.Show();
                        break;
                    case 3:
                        this.Hide();
                        InicioAdminH inAH = new InicioAdminH();                        
                        inAH.Closed += (s, args) => this.Close();
                        inAH.Show();
                        break;
                    case 4:
                        this.Hide();
                        InicioAdminG inAG = new InicioAdminG();                        
                        inAG.Closed += (s, args) => this.Close();
                        inAG.Show();
                        break;
                }               
            }
        }
    }
}
