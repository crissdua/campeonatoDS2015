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
using System.Threading.Tasks;

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
            cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from maequipo", cConectar.SqlConexion);
                DataTable DT_box = new DataTable();
                cConectar.sqlData.Fill(DT_box);
                foreach (DataRow row in DT_box.Rows)
                {
                    string rowz = row.ItemArray.ToString();
                }
                comboBox1.DataSource = DT_box;
                comboBox1.DisplayMember = "vnombreequipo";
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
            cConectar.sqlCmd = new MySqlCommand("INSERT INTO majugador (ndpijugador,vnombrejugador,vapejugador,nfechanacimiento,vsexojugador,vdireccionjugador,vtelefonojugador,MaEQUIPO_ncodequipo,foto) VALUES (" + txtDpi.Text + ",'" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtEdad.Text + "','" + cbxSexo.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + label9.Text + "','"+textBox1.Text+"');", cConectar.SqlConexion);
            cConectar.sqlCmd.ExecuteNonQuery();
            cConectar.SqlConexion.Close();
            MessageBox.Show("Datos Insertados");
            fncCargagrid();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            comboBox1.Text = dgvJugadores[8, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
            textBox1.Text = dgvJugadores[9, dgvJugadores.CurrentCell.RowIndex].Value.ToString();
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
            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try { 
            if (MessageBox.Show("¿Está seguro Modificar este registro? Nombre del Empleado: " + txtNombre.Text, "Modificar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlCmd = new MySqlCommand("UPDATE majugador SET ndpijugador ='" + txtDpi.Text + "', vnombrejugador='" + txtNombre.Text + "',vapejugador='" + txtApellido.Text + "',nfechanacimiento='" + txtEdad.Text + "',vsexojugador='" + cbxSexo.Text + "',vdireccionjugador='" + txtDireccion.Text + "',vtelefonojugador='" + txtTelefono.Text + "',MaEQUIPO_ncodequipo='" + comboBox1.Text + "',foto='"+textBox1.Text+"' WHERE ncodjugador ='" + label7.Text + "'", cConectar.SqlConexion);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("SELECT ncodequipo FROM maequipo WHERE vnombreequipo = '" + comboBox1.Text + "';", cConectar.SqlConexion);
                MySqlDataReader MyReader3;
                MyReader3 = cConectar.sqlCmd.ExecuteReader();
                while (MyReader3.Read())
                {
                   
                    label9.Text = MyReader3.GetInt32(0).ToString();
                }
                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string imagen;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);
                }*/

                OpenFileDialog BuscarImagen = new OpenFileDialog(); BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
                //Aquí incluiremos los filtros que queramos.
                BuscarImagen.FileName = "";
                BuscarImagen.Title = "Titulo del Dialogo";
                BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.textBox1.Text;
                if (BuscarImagen.ShowDialog() == DialogResult.OK)
                {
                    /// Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                    this.textBox1.Text = BuscarImagen.FileName; String Direccion = BuscarImagen.FileName; this.pictureBox1.ImageLocation = Direccion;
                    //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                    //this.pictureBox1.ImageLocation = textBox1.Text;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }         


            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        private void txtnumero_dpi(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {

                e.Handled = true;

            }
        }

        private void txtletra_nombre(object sender, KeyPressEventArgs e)
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
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
          string cadena = "0123456789, " + (char)8;

            if (!cadena.Contains(e.KeyChar))
            {
                


                e.Handled = true;

            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        


    }
}
