using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Security.Permissions;
using System.Net.Mail;
using System.Net;
using System.Security.Principal;

namespace campeonato
{
    public partial class frmnuevoempleado : Form
    {
        public frmnuevoempleado()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter sqlCmd;
        private MySqlCommand sqlConsulta;
        private MySqlConnection sqlConexion = new MySqlConnection();
        private String sCadena;
//Carga o actualiza grid
        void clasCargagrid()
        {
            try
            {
                string S_Cconn = "server = localhost; username = root; password = 12345; database = campeonato";

                MySqlConnection SQL_conexion = new MySqlConnection();
                SQL_conexion.ConnectionString = S_Cconn;
                SQL_conexion.Open();
                MySqlDataAdapter sqlData = new MySqlDataAdapter("Select * from madatopersonal", SQL_conexion);
                DataTable DT_dat = new DataTable();
                sqlData.Fill(DT_dat);
                this.dgvEmpleado.DataSource = DT_dat;
                SQL_conexion.Close();
            }
            catch (MySqlException ex)
            { 
            }

        }
        
        private void nuevoempleado_Load(object sender, EventArgs e)
        {
            clasCargagrid();
        }
// Inserta datos en BD

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Llene el campo");
                    clasCargagrid();
                }
                else
                {
                    sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
                    sqlConexion.ConnectionString = sCadena;
                    sqlConexion.Open();
                    sqlConsulta = new MySqlCommand("INSERT INTO madatopersonal (ndpipersonal, vnombrepersonal, vapepersonal, dfechanacimiento, vsexopersonal, vdireccionpersonal, ntelpersonal, MaPUESTOPERSONAL_ncodpuesto) VALUES ('" + txtDpi.Text +"' , '" + txtNombre.Text + "' , '" + txtApellido.Text + "' , '" + txtFechanacimiento.Text + "' , '" + txtSexo.Text + "' , '" + txtDireccion.Text + "' , '" + txtTelefono.Text + "','" + cboxTipo.Text + "')", sqlConexion);
                    sqlConsulta.ExecuteNonQuery();
                    sqlConexion.Close();
                    clasCargagrid();
                }
            }

            catch (MySqlException)
            {
               
            }
            

        }
// modifica datos en BD
        private void btnModificar_Click(object sender, EventArgs e)
        {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            //-------------------------------------------------------------------------------------------------
            sqlConsulta = new MySqlCommand("UPDATE madatopersonal SET ndpipersonal='" + txtDpi.Text + "' , vnombrepersonal='" + txtNombre.Text + "', vapepersonal='" + txtApellido.Text + "', dfechanacimiento='" + txtFechanacimiento.Text + "',vsexopersonal='" + txtSexo.Text + "' ,vdireccionpersonal='" + txtDireccion.Text + "' ,ntelpersonal='"+txtTelefono.Text+"' WHERE coddatopersonal ='" + label9.Text + "'", this.sqlConexion);
            sqlConsulta.ExecuteNonQuery();
            sqlConexion.Close();
            clasCargagrid();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = dgvEmpleado[0, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtDpi.Text = dgvEmpleado[1, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtNombre.Text = dgvEmpleado[2, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtApellido.Text = dgvEmpleado[3, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtFechanacimiento.Text = dgvEmpleado[4, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtSexo.Text = dgvEmpleado[5, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtDireccion.Text = dgvEmpleado[6, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtTelefono.Text = dgvEmpleado[7, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
        }
// Elimina datos de BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            sqlConsulta = new MySqlCommand("DELETE FROM madatopersonal WHERE coddatopersonal='" + label9.Text + "'" , sqlConexion);
            sqlConsulta.ExecuteNonQuery();
            sqlConexion.Close();
            clasCargagrid();
        }    
    }
}
