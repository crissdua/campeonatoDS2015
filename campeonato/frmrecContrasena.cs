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
        private MySqlDataAdapter sqlCmd;
        private MySqlConnection sqlConexion = new MySqlConnection();
        private String sCadena;
        public static String sUsuario;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text=="")
            {
                MessageBox.Show("Ingrese una Respuesta");
            }
            else
            {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            sqlCmd = new MySqlDataAdapter("Select vrespuesta from mausuario WHERE usuario='" + frmlogin.sNombre + "'", sqlConexion);
            DataTable DT_hq = new DataTable();
            sqlCmd.Fill(DT_hq);
            if (DT_hq.Rows[0][0].ToString() != txtRespuesta.Text )
            {
                Notificacion.mostrarVentana("Error", "Respuesta Incorrecta", Notificacion.Imagen.Error, 5);
                sqlConexion.Close();
            }
            else
            {   
                sqlConexion.Close();
                fncRecuperarpass();
                this.Hide();
            }
            }
        }

        private void frmrecContrasena(object sender, EventArgs e)
        {
            fncConsultarrespuesta();
        }
        private void fncConsultarrespuesta()
        {
            Nom_usuario.Text = frmlogin.sNombre;
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            sqlCmd = new MySqlDataAdapter("Select vpregunta from mausuario WHERE usuario='" + frmlogin.sNombre + "'", sqlConexion);
            DataTable DT_hq = new DataTable();
            sqlCmd.Fill(DT_hq);
            lblPregunta.Text = DT_hq.Rows[0][0].ToString();
            sqlConexion.Close();

        }

        private void fncRecuperarpass()
        {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            sqlCmd = new MySqlDataAdapter("Select vpassword  from mausuario WHERE usuario='" + frmlogin.sNombre + "'", sqlConexion);
            DataTable DT_hq = new DataTable();
            sqlCmd.Fill(DT_hq);
            sqlConexion.Close();
            Notificacion.mostrarVentana("Aceptado", "Respuesta Correcta\n Tú Password es: " + DT_hq.Rows[0][0].ToString(), Notificacion.Imagen.Llave, 5);


        }
    }
    }
