using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Permissions;
using csNotificaciones;
using System.Net.Mail;
using System.Net;
using System.Security.Principal;

namespace campeonato
{
    public partial class nuevoequipo : Form
    {
        public nuevoequipo()
        {
            InitializeComponent();
        }
        private MySqlCommand SQL_cmd;
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String S_cadena;
        public static String S_vnombre;
        private void nuevoequipo_Load(object sender, EventArgs e)
        {
            cargagrid();   
        }
        private void cargagrid()
        {
            string S_Cconn = "server=localhost;user id=root;database=campeonato";
            MySqlConnection SQL_conexion = new MySqlConnection();
            SQL_conexion.ConnectionString = S_Cconn;
            SQL_conexion.Open();
            MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from maequipo", SQL_conexion);
            DataTable DT_dat = new DataTable();
            SQL_da.Fill(DT_dat);
            this.dataGridView1.DataSource = DT_dat;
            SQL_conexion.Close();
        }
    }
}
