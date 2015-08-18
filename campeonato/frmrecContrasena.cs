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

        public static String sUsuario;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtRespuesta.Text=="")
            {
                MessageBox.Show("Ingrese una Respuesta");
            }
            else
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select vrespuesta from mausuario WHERE usuario='" + frmlogin.sNombre + "'", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);
            if (DT_dat.Rows[0][0].ToString() != txtRespuesta.Text )
            {
                Notificacion.mostrarVentana("Error", "Respuesta Incorrecta", Notificacion.Imagen.Error, 5);
                cConectar.SqlConexion.Close();
            }
            else
            {
                cConectar.SqlConexion.Close();
                fncRecuperarpass();
                this.Hide();
            }
            }
        }

        private void frmrecContrasena(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select vpregunta from mausuario WHERE usuario='" + frmlogin.sNombre + "'", cConectar.SqlConexion);
            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            lblPregunta.Text = DT_dat.Rows[0][0].ToString();
            cConectar.SqlConexion.Close();
        }

        private void fncRecuperarpass()
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select vpassword  from mausuario WHERE usuario='" + frmlogin.sNombre + "'", cConectar.SqlConexion);
            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            cConectar.SqlConexion.Close();
            Notificacion.mostrarVentana("Aceptado", "Respuesta Correcta\n Tú Password es: " + DT_dat.Rows[0][0].ToString(), Notificacion.Imagen.Llave, 5);


        }
    }
    }
