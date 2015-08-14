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
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        private MySqlCommand SQL_cmd;
        private MySqlConnection SQL_conexion = new MySqlConnection();
        private String S_cadena;

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            frmnuevacategoria frmnnuevacategoria = new frmnuevacategoria();
            frmnnuevacategoria.Show();

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void fncCargagrid()
        {
            string sConexion = "server = localhost; username = root; password = 12345; database = campeonato";
            MySqlConnection SQL_conexion = new MySqlConnection();
            SQL_conexion.ConnectionString = sConexion;
            SQL_conexion.Open();
            MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from macategoria", SQL_conexion);
            DataTable DT_dat = new DataTable();
            SQL_da.Fill(DT_dat);
            this.dgvCategoria.DataSource = DT_dat;
            SQL_conexion.Close();
        }

        private void categorias_Load(object sender, EventArgs e)
        {

            fncCargagrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
