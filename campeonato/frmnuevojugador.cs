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
    public partial class frmnuevojugador : Form
    {
        private MySqlDataAdapter sqlCmd;
        private MySqlCommand sqlConsulta;
        private MySqlConnection sqlConexion = new MySqlConnection();
        private String sCadena;
        public frmnuevojugador()
        {
            InitializeComponent();
        }

        private void fncCargagrid()
    {
        string sConexion = "server = localhost; username = root; password = 12345; database = campeonato";
        MySqlConnection SQL_conexion = new MySqlConnection();
        SQL_conexion.ConnectionString = sConexion;
        SQL_conexion.Open();
        MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from majugador", SQL_conexion);
        DataTable DT_dat = new DataTable();
        SQL_da.Fill(DT_dat);
        this.dgvJugadores.DataSource = DT_dat;
        SQL_conexion.Close();
    }

        private void NuevoJugador_Load(object sender, EventArgs e)
        {
            fncCargagrid();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            sqlConsulta = new MySqlCommand("INSERT INTO majugador (ndpijugador,vnombrejugador,vapejugador,nfechanacimiento,vsexojugador,vdireccionjugador,vtelefonojugador,MaEQUIPO_ncodequipo) VALUES ('" + txtDpi.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEdad.Text + "','" + txtSexo.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtCodEquipo.Text + "')", sqlConexion);
            sqlConsulta.ExecuteNonQuery();
            sqlConexion.Close();
            fncCargagrid();
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dgvJugadores[0, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtDpi.Text = dgvJugadores[1, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtNombre.Text = dgvJugadores[2, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtApellido.Text = dgvJugadores[3, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtEdad.Text = dgvJugadores[4, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtSexo.Text = dgvJugadores[5, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtDireccion.Text = dgvJugadores[6, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtTelefono.Text = dgvJugadores[7, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtCodEquipo.Text = dgvJugadores[8, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
                sqlConexion.ConnectionString = sCadena;
                sqlConexion.Open();
                sqlConsulta = new MySqlCommand("DELETE FROM majugador WHERE ncodjugador ='" + label7.Text + "'", sqlConexion);
                sqlConsulta.ExecuteNonQuery();
                sqlConexion.Close();
                txtDpi.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtEdad.Clear();
                txtSexo.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtCodEquipo.Clear();
                fncCargagrid();
            }
            catch (MySqlException ep)
            {
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            sCadena = "server = localhost; username = root; password = 12345; database = campeonato";
            sqlConexion.ConnectionString = sCadena;
            sqlConexion.Open();
            sqlConsulta = new MySqlCommand("UPDATE majugador SET ndpijugador ='" + txtDpi.Text + "', vnombrejugador='" + txtNombre.Text + "',vapejugador='" + txtApellido.Text + "',nfechanacimiento='" + txtEdad.Text + "',vsexojugador='" + txtSexo.Text + "',vdireccionjugador='" + txtDireccion.Text + "',vtelefonojugador='" + txtTelefono.Text + "',MaEQUIPO_ncodequipo='" + txtCodEquipo.Text + "' WHERE ncodjugador ='" + label7.Text + "'", this.sqlConexion);
            sqlConsulta.ExecuteNonQuery();
            sqlConexion.Close();
            fncCargagrid();
        }

    }
}
