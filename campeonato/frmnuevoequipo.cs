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

//Funcion para la carga de grid
        void fncCargaGrid()
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from maequipo", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);
                this.dgvEquipo.DataSource = DT_dat;
                cConectar.SqlConexion.Close();
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
                    dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                    cConectar.cLocal();
                    cConectar.sqlCmd = new MySqlCommand("INSERT INTO maequipo (vnombreequipo,vdescripcion) VALUES ('" + txtNombre.Text + "','" + txtDescripcion.Text + "')", cConectar.SqlConexion);
                    cConectar.sqlCmd.ExecuteNonQuery();
                    cConectar.SqlConexion.Close();
                    fncCargaGrid();
                    MessageBox.Show("Datos Insertados");
                    limpiar();

                }

            }

            catch
            {
                MessageBox.Show("Problema en BD");  
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
                    if (MessageBox.Show("¿Está seguro Modificar este registro? Nombre del Empleado: " + txtNombre.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                    dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                    cConectar.cLocal();
                    cConectar.sqlCmd = new MySqlCommand("UPDATE maequipo SET vnombreequipo='" + txtNombre.Text + "', vdescripcion='" + txtDescripcion.Text + "' WHERE ncodequipo ='" + txtId.Text + "'", cConectar.SqlConexion);
                    cConectar.sqlCmd.ExecuteNonQuery();
                    cConectar.SqlConexion.Close();
                    fncCargaGrid();
                    MessageBox.Show("Registro Modificado");
                    limpiar();
                    }
                    else
                    {
                        limpiar();
                    }
                }
            }

            catch
            {
                MessageBox.Show("Problema en BD");
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
                txtDescripcion.Text = dgvEquipo[2, dgvEquipo.CurrentCell.RowIndex].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }
        }
        //Limpia datos
        private void limpiar()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }
//Elimina datos de BD
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de Eliminar este registro? Nombre del Empleado: " + txtNombre.Text, "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("DELETE FROM maequipo WHERE vnombreequipo ='" + txtNombre.Text + "'", cConectar.SqlConexion);
                cConectar.sqlCmd.ExecuteNonQuery();
                cConectar.SqlConexion.Close();
                fncCargaGrid();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from maequipo where ndpijugador like ('" + txtNombre.Text + "%') ", cConectar.SqlConexion);

            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.dgvEquipo.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
        }

    }
}
