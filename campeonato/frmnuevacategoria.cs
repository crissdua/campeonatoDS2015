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
    public partial class frmnuevacategoria : Form
    {
        public frmnuevacategoria()
        {
            InitializeComponent();
        }


        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("INSERT INTO macategoria (vnombrecategoria, nedadcategoria, vgenerocategoria, vobsecategoria) VALUES ('" + txtNombreCampeonato.Text + "', " + lstEdad.Text + " ,'" + cmbGenero.Text + "', ' " + txtObervaciones.Text + "');", cConectar.SqlConexion);
                MySqlDataReader MyReader2;
                MyReader2 = cConectar.sqlCmd.ExecuteReader();
                MessageBox.Show("Datos Insertados");
                fncCargagrid();
                clsBloquear();
                limpiar();
                    while(MyReader2.Read())
                    {
                    }
                    cConectar.SqlConexion.Close();

            }  
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmnuevacategoria_Load(object sender, EventArgs e)
        {
            fncCargagrid();
            clsBloquear();
            

        }
        private void clsBloquear()
        {
            txtNombreCampeonato.Enabled = false;
            lstEdad.Enabled = false;
            cmbGenero.Enabled = false;
            txtObervaciones.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;

        }

        private void clsDesbloquear()
        {
            txtNombreCampeonato.Enabled =true;
            lstEdad.Enabled = true;
            cmbGenero.Enabled = true;
            txtObervaciones.Enabled = true;

        }
        private void fncCargagrid()
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from macategoria", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);
                this.dgvCategoria.DataSource = DT_dat;
                cConectar.SqlConexion.Close();

            }
            catch
            {
                MessageBox.Show("Problema en BD");
            }

        }

        private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblCodigo.Text = dgvCategoria[0, dgvCategoria.CurrentCell.RowIndex].Value.ToString();
                txtNombreCampeonato.Text = dgvCategoria[1, dgvCategoria.CurrentCell.RowIndex].Value.ToString();
                lstEdad.Text = dgvCategoria[2, dgvCategoria.CurrentCell.RowIndex].Value.ToString();
                cmbGenero.Text = dgvCategoria[3, dgvCategoria.CurrentCell.RowIndex].Value.ToString();
                txtObervaciones.Text = dgvCategoria[4, dgvCategoria.CurrentCell.RowIndex].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }
        }


        private void limpiar()
        {
            txtNombreCampeonato.Clear();       
            txtObervaciones.Clear();
            lstEdad.Text = "";
            cmbGenero.Text = "";
        }

        // *******************************************************************
        //--------------------------.MODIFICAR.------------------------------
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("¿Está seguro Modificar este registro? Categoría: " + txtNombreCampeonato.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                    cConectar.cLocal();
                    cConectar.sqlCmd = new MySqlCommand("UPDATE macategoria SET vnombrecategoria = '" + txtNombreCampeonato.Text + "', nedadcategoria = " + lstEdad.Text + " , vgenerocategoria= '" + cmbGenero.Text + "' ,  vobsecategoria = '" + txtObervaciones.Text + "' WHERE codcategoria = " + lblCodigo.Text + ";", cConectar.SqlConexion);                
                    cConectar.sqlCmd.ExecuteNonQuery();
                    cConectar.SqlConexion.Close();
                    fncCargagrid();
                    MessageBox.Show("Registro Modificado");
                    limpiar();
                    clsBloquear();

       
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de Eliminar este registro? Categoría: " + txtNombreCampeonato.Text, "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                    cConectar.cLocal();
                    cConectar.sqlCmd = new MySqlCommand("DELETE FROM macategoria where codcategoria = " + lblCodigo.Text + ";", cConectar.SqlConexion);
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

        private void btnModificar2_Click(object sender, EventArgs e)
        {
            clsDesbloquear();
            btnModificar.Enabled = true;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            clsDesbloquear();
            btnGuardar.Enabled = true;
        }

    }
}
