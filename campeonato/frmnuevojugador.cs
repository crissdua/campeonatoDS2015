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

        public frmnuevojugador()
        {
            InitializeComponent();
        }

        private void fncCargagrid()
    {
        try {
        dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
        cConectar.cLocal();
        cConectar.sqlData = new MySqlDataAdapter("Select * from majugador", cConectar.SqlConexion);
        DataTable DT_dat = new DataTable();
        cConectar.sqlData.Fill(DT_dat);
        this.dgvJugadores.DataSource = DT_dat;
        cConectar.SqlConexion.Close();
        }

        catch
        {
            MessageBox.Show("Problema en BD");
        }
    }

        private void NuevoJugador_Load(object sender, EventArgs e)
        {
            fncCargagrid();
            cbxSexo.Items.Add("Masculino");
            cbxSexo.Items.Add("Femenino");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("INSERT INTO majugador (ndpijugador,vnombrejugador,vapejugador,nfechanacimiento,vsexojugador,vdireccionjugador,vtelefonojugador,MaEQUIPO_ncodequipo) VALUES ('" + txtDpi.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEdad.Text + "','" + cbxSexo.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtCodEquipo.Text + "')", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            MessageBox.Show("Datos Insertados");
            fncCargagrid();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dgvJugadores[0, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtDpi.Text = dgvJugadores[1, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtNombre.Text = dgvJugadores[2, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtApellido.Text = dgvJugadores[3, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtEdad.Text = dgvJugadores[4, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            cbxSexo.Text = dgvJugadores[5, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtDireccion.Text = dgvJugadores[6, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtTelefono.Text = dgvJugadores[7, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            txtCodEquipo.Text = dgvJugadores[8, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de Eliminar este registro? Nombre del Empleado: " + txtNombre.Text, "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("DELETE FROM majugador WHERE ncodjugador ='" + label7.Text + "'", cConectar.SqlConexion);
                cConectar.sqlCmd.ExecuteNonQuery();
                cConectar.SqlConexion.Close();
                fncCargagrid();
                MessageBox.Show("Registro Eliminado");
                limpiar();
                }
                else
                {
                    limpiar();
                }
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }
        }

        private void limpiar()
        {
            txtDpi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            cbxSexo.Text = "";
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCodEquipo.Clear();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("¿Está seguro Modificar este registro? Nombre del Empleado: " + txtNombre.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("UPDATE majugador SET ndpijugador ='" + txtDpi.Text + "', vnombrejugador='" + txtNombre.Text + "',vapejugador='" + txtApellido.Text + "',nfechanacimiento='" + txtEdad.Text + "',vsexojugador='" + cbxSexo.Text + "',vdireccionjugador='" + txtDireccion.Text + "',vtelefonojugador='" + txtTelefono.Text + "',MaEQUIPO_ncodequipo='" + txtCodEquipo.Text + "' WHERE ncodjugador ='" + label7.Text + "'", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            fncCargagrid();
            MessageBox.Show("Registro Modificado");
            limpiar();
                    }
            else
            {
                limpiar();
            }
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }
        }

        private void txtDpi_TextChanged(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from majugador where ndpijugador like ('" + txtDpi.Text + "%') ", cConectar.SqlConexion);

            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.dgvJugadores.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
