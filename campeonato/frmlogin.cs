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

// Variables
        public static string sNombre;
        public static String sUsuario;
        public static String sPrivilegio;

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
                        dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                        cConectar.cLocal();
                        cConectar.sqlCmd = new MySqlCommand("Select usuario, vprivilegio from mausuario WHERE usuario='" + txtNombre.Text + "'And vpassword ='" + txtContrasena.Text + "'", cConectar.SqlConexion);
                        Object obj = cConectar.sqlCmd.ExecuteScalar();
                        if (obj == null)
                        {
                            Notificacion.mostrarVentana("Login", "Error: Ingrese un usuario y contraseña validos", Notificacion.Imagen.Error, 5);
                            txtNombre.Text = "";
                            txtContrasena.Text = "";
                            cConectar.SqlConexion.Close();
                        }
                        else
                        {
                            sNombre = txtNombre.Text;
                            Notificacion.mostrarVentana("Loguin", "Inicio de Sesion Correcto ", Notificacion.Imagen.Llave, 5);
                            cConectar.SqlConexion.Close();
                            this.Hide();
                            fncTomaPrivilegio();
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

        public void fncTomaPrivilegio()
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select  usuario, vprivilegio from mausuario where usuario ='" + txtNombre.Text + "'", cConectar.SqlConexion);
            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            cConectar.SqlConexion.Close();
            sUsuario = DT_dat.Rows[0][0].ToString();
            sPrivilegio = DT_dat.Rows[0][1].ToString();
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
                        dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                        cConectar.cLocal();
                        cConectar.sqlCmd = new MySqlCommand("Select usuario from mausuario WHERE usuario='" + txtNombre.Text + "'", cConectar.SqlConexion);
                        Object obj = cConectar.sqlCmd.ExecuteScalar();
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
                        cConectar.SqlConexion.Close();
                    }
            }
            catch
            {
                MessageBox.Show("Problema con la BD");
            }
        }
    }
}
