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
    public partial class frmnuevoequipo : Form
    {       

        public frmnuevoequipo()
        {
            InitializeComponent();
        }
        private MySqlDataAdapter sqlCmd;
        private MySqlCommand sqlConsulta;
        private MySqlConnection sqlConexion = new MySqlConnection();
        private String sCadena;
//Funcion para la carga de grid
        void fncCargaGrid()
        {
            try
            {
                string sConexion = "server = localhost; username = root; password = 12345; database = campeonato";
                MySqlConnection sqlConexion = new MySqlConnection();
                sqlConexion.ConnectionString = sConexion;
                sqlConexion.Open();
                MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from maequipo", sqlConexion);
                DataTable DT_dat = new DataTable();
                SQL_da.Fill(DT_dat);
                this.dgvEquipo.DataSource = DT_dat;
                sqlConexion.Close();
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }

         }
    
//Inserta datos en BD  
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Indique el Nombre del Equipo");
                    fncCargaGrid();
                }
                else
                {
                    sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
                    sqlConexion.ConnectionString = sCadena;
                    sqlConexion.Open();
                    sqlConsulta = new MySqlCommand("INSERT INTO maequipo (vnombreequipo) VALUES ('" + txtNombre.Text + "')", sqlConexion);
                    sqlConsulta.ExecuteNonQuery();
                    sqlConexion.Close();
                    fncCargaGrid();

                }

            }

            catch
            {
                MessageBox.Show("Problema al cargar BD");  
            }
            

        }

//Modifica datos en BD      
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("No puede dejar el Nombre en Blanco");
                }
                else
                {
                    sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
                    sqlConexion.ConnectionString = sCadena;
                    sqlConexion.Open();
                    //-------------------------------------------------------------------------------------------------
                    sqlConsulta = new MySqlCommand("UPDATE maequipo SET vnombreequipo='" + txtNombre.Text + "' WHERE ncodequipo ='" + txtId.Text + "'", this.sqlConexion);
                    sqlConsulta.ExecuteNonQuery();
                    sqlConexion.Close();
                    fncCargaGrid();
                }
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }
        }

        private void nuevoequipo_Load(object sender, EventArgs e)
        {
            fncCargaGrid();
        }
//Selecciona datos del grid
        private void dgvEquipo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNombre.Text = dgvEquipo[1, dgvEquipo.CurrentCell.RowIndex].Value.ToString();
                txtId.Text = dgvEquipo[0, dgvEquipo.CurrentCell.RowIndex].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }
        }
//Elimina datos de BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                    sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
                    sqlConexion.ConnectionString = sCadena;
                    sqlConexion.Open();
                    sqlConsulta = new MySqlCommand("DELETE FROM maequipo WHERE vnombreequipo ='" + txtNombre.Text + "'", sqlConexion);
                    sqlConsulta.ExecuteNonQuery();
                    sqlConexion.Close();
                    fncCargaGrid();
                
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }
        }

    }
}
