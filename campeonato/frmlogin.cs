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

        private MySqlCommand sqlCmd;
        private MySqlConnection SqlConexion = new MySqlConnection();
        private String sCadena;
        public static String sNombre;

//Clase Conexion, inicia la conexion a BD campeonato
        private void clasConexion()
        {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            SqlConexion.ConnectionString = sCadena;
            SqlConexion.Open();
        }

// btnloguin conexion y logueo de usuario
        private void btnloguin_Click(object sender, EventArgs e)
        {
            try
            {   
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese un Nombre de Usuario");
                }
                else
                    if (txtContrasena.Text == "")
                    {
                        MessageBox.Show("Porfavor Ingrese su Contraseña");
                    }
                    else
                    {
                        clasConexion();
                        sqlCmd = new MySqlCommand("Select usuario from mausuario WHERE usuario='" + txtNombre.Text + "'And vpassword ='" + txtContrasena.Text + "'", SqlConexion);

                        Object obj = sqlCmd.ExecuteScalar();
                        if (obj == null)
                        {
                            Notificacion.mostrarVentana("Login", "Error: Ingrese un usuario y contraseña validos", Notificacion.Imagen.Error, 5);
                            txtNombre.Text = "";
                            txtContrasena.Text = "";
                            SqlConexion.Close();
                        }
                        else
                        {
                            sNombre = txtNombre.Text;
                            Notificacion.mostrarVentana("Loguin", "Inicio de Sesion Correcto ", Notificacion.Imagen.Llave, 5);
                            SqlConexion.Close();
                            this.Hide();
                            frmmenuprincipal frmnmenu = new frmmenuprincipal();
                            frmnmenu.Show();
                        }
                    }
            }
            catch
            { 
                MessageBox.Show("Problema con la BD"); 
            }
        }
//btnrecuperar recupera password del usuario
        private void btnrecupera_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese un Nombre de Usuario");
                }
                    else
                    {
                        clasConexion();
                        sqlCmd = new MySqlCommand("Select usuario from mausuario WHERE usuario='" + txtNombre.Text + "'", SqlConexion);
                        Object obj = sqlCmd.ExecuteScalar();
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
                        SqlConexion.Close();
                    }
            }
            catch
            {
                MessageBox.Show("Problema con la BD");
            }
        }
    }
}
