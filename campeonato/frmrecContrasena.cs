using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using csNotificaciones;

namespace campeonato
{
    public partial class frmreccontrasena : Form
    {
        public frmreccontrasena()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter SQL_cmd;
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String S_cadena;
        public static String usuario;
        private void button1_Click(object sender, EventArgs e)
        {
            S_cadena = "server=localhost;user id=root;database=campeonato";
            SQL_Conexion.ConnectionString = S_cadena;
            SQL_Conexion.Open();
            SQL_cmd = new MySqlDataAdapter("Select vrespuesta from mausuario WHERE vnombre='" + frmlogin.sNombre + "'", SQL_Conexion);
            DataTable DT_hq = new DataTable();
            SQL_cmd.Fill(DT_hq);
            if (DT_hq.Rows[0][0].ToString() != txB_respuesta.Text )
            {
                Notificacion.mostrarVentana("Error", "Respuesta Incorrecta", Notificacion.Imagen.Error, 5);
                SQL_Conexion.Close();
            }
            else
            {   SQL_Conexion.Close();
                Recuperar_Pass();
                this.Hide();
            }
        }

        private void rec_contrasena_Load(object sender, EventArgs e)
        {
            Consultar_Pregunta();
        }
        private void Consultar_Pregunta()
        {
            Nom_usuario.Text = frmlogin.sNombre;
            S_cadena = "server=localhost;user id=root;database=campeonato";
            SQL_Conexion.ConnectionString = S_cadena;
            SQL_Conexion.Open();
            SQL_cmd = new MySqlDataAdapter("Select vpregunta from mausuario WHERE vnombre='" + frmlogin.sNombre + "'", SQL_Conexion);
            DataTable DT_hq = new DataTable();
            SQL_cmd.Fill(DT_hq);
            txB_Pregunta.Text = DT_hq.Rows[0][0].ToString();
            SQL_Conexion.Close();

        }

        private void Recuperar_Pass()
        {
            S_cadena = "server=localhost;user id=root;database=campeonato";
            SQL_Conexion.ConnectionString = S_cadena;
            SQL_Conexion.Open();
            SQL_cmd = new MySqlDataAdapter("Select vpassword  from mausuario WHERE vnombre='" + frmlogin.sNombre + "'", SQL_Conexion);
            DataTable DT_hq = new DataTable();
            SQL_cmd.Fill(DT_hq);
            SQL_Conexion.Close();
            Notificacion.mostrarVentana("Aceptado", "Respuesta Correcta\n Tú Password es: " + DT_hq.Rows[0][0].ToString(), Notificacion.Imagen.Llave, 5);


        }
    }
    }
