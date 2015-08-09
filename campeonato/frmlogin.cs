//Cristhiam Noe Duarte Herrera
//Fecha de Asignacion:
//Fecha de Entrega: 10/08/15

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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {InitializeComponent();}

        private MySqlCommand SQL_cmd;
        private MySqlConnection SQL_Conexion = new MySqlConnection();
        private String sCadena;
        public static String sNombre;

//Clase Conexion, inicia la conexion a BD campeonato
        private void clasConexion()
        {
            sCadena = "server=localhost;user id=root;database=campeonato";
            SQL_Conexion.ConnectionString = sCadena;
            SQL_Conexion.Open();
        }

// btnloguin conexion y logueo de usuario
        private void btnloguin_Click(object sender, EventArgs e)
        {
            try
            {
                clasConexion();
                SQL_cmd = new MySqlCommand("Select vnombre from mausuario WHERE vnombre='" + txtNombre.Text + "'And vpassword ='" + txtContrasena.Text + "'", SQL_Conexion);

                Object obj = SQL_cmd.ExecuteScalar();
                if (obj == null)
                {
                    Notificacion.mostrarVentana("Login", "Error: Ingrese un usuario y contraseña validos", Notificacion.Imagen.Error, 5);
                    txtNombre.Text = "";
                    txtContrasena.Text = "";
                    SQL_Conexion.Close();
                }
                else
                {
                    sNombre = txtNombre.Text;
                    Notificacion.mostrarVentana("Loguin", "Inicio de Sesion Correcto ", Notificacion.Imagen.Llave, 5);
                    SQL_Conexion.Close();
                    this.Hide();
                    menuprincipal frmnmenu = new menuprincipal();
                    frmnmenu.Show();
                }
            }
            catch (MySqlException)
            {            }
        }
//btnrecuperar recupera password del usuario
        private void btnrecuperar(object sender, EventArgs e)
        {
            try
            {
                clasConexion();
                SQL_cmd = new MySqlCommand("Select vnombre from mausuario WHERE vnombre='" + txtNombre.Text + "'", SQL_Conexion);

                Object obj = SQL_cmd.ExecuteScalar();
                if (obj == null)
                {
                    Notificacion.mostrarVentana("Error", "Usuario NO EXISTE!!!", Notificacion.Imagen.Error, 5);
                }
                else
                {
                    frmreccontrasena F_ventanaP = new frmreccontrasena();
                    sNombre = txtNombre.Text;
                    F_ventanaP.Show();
                }
                SQL_Conexion.Close();
            }
            catch (MySqlException ep)
            {
            }
        }
    }
}
