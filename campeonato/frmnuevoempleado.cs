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
//Carga o actualiza grid
        void fncCargagrid()
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from madatopersonal", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);
                this.dgvEmpleado.DataSource = DT_dat;
                cConectar.SqlConexion.Close();
               
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from mapuestopersonal", cConectar.SqlConexion);
                DataTable DT_box = new DataTable();
                cConectar.sqlData.Fill(DT_box);
                foreach (DataRow row in DT_box.Rows)
                {
                    string rowz = row.ItemArray.ToString();
                }
                cboxTipo.DataSource = DT_box;
                cboxTipo.DisplayMember = "ncodpuesto";
                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }

        
        }
        
        private void nuevoempleado_Load(object sender, EventArgs e)
        {
            cbxSexo.Items.Add("Masculino");
            cbxSexo.Items.Add("Femenino");
            fncCargagrid();
        }
// Inserta datos en BD

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Llene el campo");
                    fncCargagrid();
                }
                else
                {
                    dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                    cConectar.cLocal();
                    cConectar.sqlCmd = new MySqlCommand("INSERT INTO madatopersonal (ndpipersonal, vnombrepersonal, vapepersonal, dfechanacimiento, vsexopersonal, vdireccionpersonal, ntelpersonal, MaPUESTOPERSONAL_ncodpuesto) VALUES ('" + txtDpi.Text + "' , '" + txtNombre.Text + "' , '" + txtApellido.Text + "' , '" + txtFechanacimiento.Text + "' , '" + cbxSexo.Text + "' , '" + txtDireccion.Text + "' , '" + txtTelefono.Text + "','" + cboxTipo.Text + "')", cConectar.SqlConexion);
                    cConectar.sqlCmd.ExecuteNonQuery();
                    cConectar.SqlConexion.Close();
                    MessageBox.Show("Datos Insertados");
                    fncCargagrid();
                }
            }

            catch (MySqlException)
            {
                MessageBox.Show("Error en BD");
            }
            

        }
// modifica datos en BD
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("¿Está seguro de Modificar este registro? Nombre del Empleado: " + txtNombre.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("UPDATE madatopersonal SET ndpipersonal='" + txtDpi.Text + "' , vnombrepersonal='" + txtNombre.Text + "', vapepersonal='" + txtApellido.Text + "', dfechanacimiento='" + txtFechanacimiento.Text + "',vsexopersonal='" + cbxSexo.Text + "' ,vdireccionpersonal='" + txtDireccion.Text + "' ,ntelpersonal='" + txtTelefono.Text + "' WHERE coddatopersonal ='" + label9.Text + "'", cConectar.SqlConexion);
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

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = dgvEmpleado[0, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtDpi.Text = dgvEmpleado[1, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtNombre.Text = dgvEmpleado[2, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtApellido.Text = dgvEmpleado[3, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtFechanacimiento.Text = dgvEmpleado[4, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            cbxSexo.Text = dgvEmpleado[5, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtDireccion.Text = dgvEmpleado[6, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
            txtTelefono.Text = dgvEmpleado[7, dgvEmpleado.CurrentCell.RowIndex].Value.ToString();
        }
        //borra datos de los text
        private void limpiar()
        {
            label9.Text = "";
            txtDpi.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtFechanacimiento.Clear();
            cbxSexo.Text = "";
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
// Elimina datos de BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("¿Está seguro de Eliminar este registro? Nombre del Empleado: " + txtNombre.Text, "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("DELETE FROM madatopersonal WHERE coddatopersonal='" + label9.Text + "'", cConectar.SqlConexion);
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

        private void txtDpi_TextChanged(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from madatopersonal where ndpipersonal like ('" + txtDpi.Text + "%') ", cConectar.SqlConexion);

            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.dgvEmpleado.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
        }

        private void cbxSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDpi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;

            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "abcdefghijklmnñopqrstuvwxyz " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtFechanacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890abcdefghijklmnñopqrstuvwxyz/ " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "123456789abcdefghijklmnñopqrstuvwxyz,.-" + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cadena = "1234567890, " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {

                e.Handled = true;

            }
        }    
    }
}
