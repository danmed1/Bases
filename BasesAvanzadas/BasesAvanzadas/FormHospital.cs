﻿using System;
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
    public partial class FormHospital : Form
    {
        private string conexionBase = "Data Source=192.168.100.107;Initial Catalog=ProyectoDBA;Persist Security Info=True;User ID=Admin;Password=password";
        public FormHospital()
        {
            InitializeComponent();
        }

        private void Hospital(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(conexionBase);
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Hospital (Nombre_H,Direccion) VALUES (@Nombre,@Direccion);", con);
                cmd.Parameters.AddWithValue("@Nombre", tbHospital.Text);
                cmd.Parameters.AddWithValue("@Direccion", tbDireccion.Text);                

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            this.Close();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
