using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace campeonato
{
    public partial class frmnuevocampeonato : Form
    {
        public frmnuevocampeonato()
        {
            InitializeComponent();
        }     

        private void botCategoria_Click(object sender, EventArgs e)
        {

            frmnuevacategoria frmncategoria = new frmnuevacategoria();
            frmncategoria.Show();
        }

        private void nuevocampeonato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'campeonatoDataSet.macategoria' Puede moverla o quitarla según sea necesario.
            this.macategoriaTableAdapter.Fill(this.campeonatoDataSet.macategoria);
            fncCargagrid();
        
        }


        private void limpiar()
        {
            txtNombre.Clear();
            txtCategoria.Clear();
            txtDescripcion.Clear();
            cmbCategoria.Text = "";
            cmbTipoCompetencia.Text = "";
        }

        /*
         * ELIMINACION DE DE DATOS CON CONFIRMACION DE OPERACION
         * Dennys Choy
         * 
         */
        private void btnEliminar(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de Eliminar este registro? Nombre del Empleado: " + txtNombre.Text, "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("DELETE FROM macompetencia where ncodcompetencia = " + lblCodigo.Text + ";", cConectar.SqlConexion);
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

        /*
        * Carga txtCategoria el codigo de categoria según seleccion de cmbCategoria
        * Dennys Choy
        * 
        */
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("SELECT codcategoria FROM macategoria WHERE vnombrecategoria = '" + cmbCategoria.Text + "';", cConectar.SqlConexion);
                MySqlDataReader MyReader3;
                MyReader3 = cConectar.sqlCmd.ExecuteReader();
                while (MyReader3.Read())
                {
                    txtCategoria.Text = MyReader3.GetInt32(0).ToString();
                    lblCategoria1.Text = MyReader3.GetInt32(0).ToString();
                }
                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }

        }

        private void fncCargagrid()
        {
            try { 
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from macompetencia", cConectar.SqlConexion);
            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.dgvCampeonato.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
            
            //Carga datos al combobox según categoría
         
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("select *FROM macategoria", cConectar.SqlConexion);
            DataTable DT_box = new DataTable();
            cConectar.sqlData.Fill(DT_box);
            foreach (DataRow row in DT_box.Rows)
            {
                string rowz = row.ItemArray.ToString();
            }
            cmbCategoria.DataSource = DT_box;
            //cboxTipo.DataSource = DT_box;
            //cboxTipo.DisplayMember = "ncodpuesto";
            cmbCategoria.DisplayMember = "vnombrecategoria";
            cConectar.SqlConexion.Close();



            }
            catch
            {
                MessageBox.Show("Problema en BD");
            }

        }

        /*
        *Carga datos según seleccion del grid
        * Dennys Choy
        * 
        */

        private void dgvCampeonato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
                lblCodigo.Text = dgvCampeonato[0, dgvCampeonato.CurrentCell.RowIndex].Value.ToString();
                txtNombre.Text = dgvCampeonato[1, dgvCampeonato.CurrentCell.RowIndex].Value.ToString(); 
                //cmbCategoria.Text = dgvCampeonato[6, dgvCampeonato.CurrentCell.RowIndex].Value.ToString();
                cmbTipoCompetencia.Text = dgvCampeonato[3, dgvCampeonato.CurrentCell.RowIndex].Value.ToString();
                dateInicio.Text = dgvCampeonato[4, dgvCampeonato.CurrentCell.RowIndex].Value.ToString();
                dateFinal.Text = dgvCampeonato[5, dgvCampeonato.CurrentCell.RowIndex].Value.ToString();
                txtDescripcion.Text = dgvCampeonato[2, dgvCampeonato.CurrentCell.RowIndex].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Problema al cargar BD");
            }
        }
        /*
        * "UDPDATE" DE DE DATOS CON CONFIRMACION DE OPERACION
        * Dennys Choy
        * 
        */
        private void btnModificar(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro Modificar este registro? Nombre del Empleado: " + txtNombre.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("UPDATE macompetencia SET vnomcompetencia = '"+ txtNombre.Text+ "', vdescripcion = '" + txtDescripcion.Text + "' , vtipocompetencia = '"+ cmbTipoCompetencia.Text +"' ,  dfechainicio = '"+ dateInicio.Text +"', dfechafin = '"+ dateFinal.Text + "' , MaCATEGORIA_codcategoria = "+ txtCategoria.Text +" WHERE ncodcompetencia = "+lblCodigo.Text+";" , cConectar.SqlConexion);
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
        //INSERTAR DATOS A LA TABLA CAMPEONATO
        private void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("INSERT INTO macompetencia (vnomcompetencia, vdescripcion, vtipocompetencia,  dfechainicio, dfechafin, MaCATEGORIA_codcategoria) VALUES ('" + txtNombre.Text + "' , '" + txtDescripcion.Text + "' , '" + cmbTipoCompetencia.Text + "' , '" + dateInicio.Text + "' , '" + dateFinal.Text + "' , " + lblCategoria1.Text + " ); ", cConectar.SqlConexion);
                MySqlDataReader MyReader2;
                MyReader2 = cConectar.sqlCmd.ExecuteReader();
                MessageBox.Show("Datos Insertados");
                cConectar.SqlConexion.Close();
                fncCargagrid();
            }
            catch
            {
                MessageBox.Show("Error en BD");
            } 
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select * from macompetencia where ndpijugador like ('" + txtNombre.Text + "%') ", cConectar.SqlConexion);

            DataTable DT_dat = new DataTable();
            cConectar.sqlData.Fill(DT_dat);
            this.dgvCampeonato.DataSource = DT_dat;
            cConectar.SqlConexion.Close();
        }

        private void cmbTipoCompetencia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
