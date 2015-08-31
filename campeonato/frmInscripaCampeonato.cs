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

namespace campeonato
{
    public partial class frmInscripaCampeonato : Form
    {
        public frmInscripaCampeonato()
        {
            InitializeComponent();
        }

        private void btnInscripcion_Load(object sender, EventArgs e)
        {
            fncCargacmb1();
            fncCargacmb2();
            //  fncCargagrid();
            //InitializeDataGridView();

        }


        private void fncCargagrid()
        {


            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                //cConectar.sqlData = new MySqlDataAdapter("SELECT *FROM trequipoencompetencia WHERE MaCOMPETENCIA_ncodcompetencia1 = "+ lblCodigoCompetencia.Text +";", cConectar.SqlConexion);
                cConectar.sqlData = new MySqlDataAdapter("Select vnombreequipo from maequipo where ncodequipo in ( SELECT MaEQUIPO_ncodequipo FROM trequipoencompetencia WHERE MaCOMPETENCIA_ncodcompetencia1 = " + lblCodigoCompetencia.Text + ");", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);
                this.dgvCampeonato.DataSource = DT_dat;


                cConectar.SqlConexion.Close();
            }
            catch
            {
                MessageBox.Show("Problema en BD, Equipo en competencia GRID");
            }

        }

        private void fncCargacmb1()
        {

            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from macompetencia", cConectar.SqlConexion);
                DataTable DT_box = new DataTable();
                cConectar.sqlData.Fill(DT_box);
                foreach (DataRow row in DT_box.Rows)
                {
                    string rowz = row.ItemArray.ToString();
                }
                cmbCompetencia.DataSource = DT_box;
                cmbCompetencia.DisplayMember = "vnomcompetencia";

                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD, Competencia");
            }

        }

        private void fncCargacmb2()
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select * from maequipo", cConectar.SqlConexion);
                DataTable DT_box = new DataTable();
                cConectar.sqlData.Fill(DT_box);
                foreach (DataRow row in DT_box.Rows)
                {
                    string rowz = row.ItemArray.ToString();
                }
                cmbEquipo.DataSource = DT_box;
                cmbEquipo.DisplayMember = "vnombreequipo";
                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD, Equipo");
            }


        }

        private void cmbCompetencia_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("SELECT ncodcompetencia FROM macompetencia WHERE vnomcompetencia = '" + cmbCompetencia.Text + "';", cConectar.SqlConexion);
                MySqlDataReader MyReader3;
                MyReader3 = cConectar.sqlCmd.ExecuteReader();

                while (MyReader3.Read())
                {
                    lblCodigoCompetencia.Text = MyReader3.GetInt32(0).ToString();
                    fncCargagrid();
                }
                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            //cConectar.cLocal();
            try
            {
                if (MessageBox.Show("¿Está seguro de inscribir a " + cmbEquipo.Text + "  Al siguiente campeonato: " + cmbCompetencia.Text + " ", "Confirmación de Inscripción", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cConectar.cLocal();
                    MySqlCommand cmd = new MySqlCommand("select *from trequipoencompetencia where MaCOMPETENCIA_ncodcompetencia1 = '" + lblCodigoCompetencia.Text + "' and MaEQUIPO_ncodequipo = '" + lblCodigoEquipo.Text + "';", cConectar.SqlConexion);
                    MySqlDataReader MyReader3;
                    MyReader3 = cmd.ExecuteReader();
                    if (!MyReader3.HasRows)
                    {
                        cConectar.SqlConexion.Close();
                        try
                        {
                            cConectar.cLocal();
                            cConectar.sqlCmd = new MySqlCommand("INSERT INTO trequipoencompetencia (njjugados, njganados, njperdidos, njempatados, ngolfavor, ngolcontra, npts, MaCOMPETENCIA_ncodcompetencia1, MaEQUIPO_ncodequipo) VALUES (0, 0, 0, 0, 0, 0, 0, " + lblCodigoCompetencia.Text + "," + lblCodigoEquipo.Text + ");", cConectar.SqlConexion);
                            MySqlDataReader MyReader1;
                            MyReader1 = cConectar.sqlCmd.ExecuteReader();
                            MessageBox.Show("Equipo inscrito exitosamente");
                            fncCargagrid();
                            while (MyReader1.Read())
                            {
                            }
                            cConectar.SqlConexion.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        cConectar.SqlConexion.Close();
                        MessageBox.Show("El equipo ya está inscrito");
                    }

                }
                else
                {
                    MessageBox.Show("Error en el mensaje de verificación");
                }
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }

        }

        private void cmbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("SELECT ncodequipo FROM maequipo WHERE vnombreequipo = '" + cmbEquipo.Text + "';", cConectar.SqlConexion);
                MySqlDataReader MyReader3;
                MyReader3 = cConectar.sqlCmd.ExecuteReader();
                while (MyReader3.Read())
                {
                    lblCodigoEquipo.Text = MyReader3.GetInt32(0).ToString();
                }
                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD");
            }
        }

        private void dgvCampeonato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
        private void InitializeDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dataGridView1.ColumnCount = 4;
            dataGridView1.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dataGridView1.Columns[0].Name = "Recipe";
            dataGridView1.Columns[1].Name = "Category";
            dataGridView1.Columns[2].Name = "Main Ingredients";
            dataGridView1.Columns[3].Name = "Rating";

            // Populate the rows.
            string[] row1 = new string[] { "Meatloaf", "Main Dish", "ground beef",
            "**" };
            string[] row2 = new string[] { "Key Lime Pie", "Dessert", 
            "lime juice, evaporated milk", "****" };
            string[] row3 = new string[] { "Orange-Salsa Pork Chops", "Main Dish", 
            "pork chops, salsa, orange juice", "****" };
            string[] row4 = new string[] { "Black Bean and Rice Salad", "Salad", 
            "black beans, brown rice", "****" };
            string[] row5 = new string[] { "Chocolate Cheesecake", "Dessert", 
            "cream cheese", "***" };
            string[] row6 = new string[] { "Black Bean Dip", "Appetizer", 
            "black beans, sour cream", "***" };
            object[] rows = new object[] { row1, row2, row3, row4, row5, row6 };

            foreach (string[] rowArray in rows)
            {
                dataGridView1.Rows.Add(rowArray);
            }
        }
        */
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
