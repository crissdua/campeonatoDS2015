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
    public partial class frmnuevocampeonato : Form
    {
        public frmnuevocampeonato()
        {
            InitializeComponent();
        }

        private MySqlCommand SQL_cmd;
        private MySqlConnection SQL_conexion = new MySqlConnection();
        private String S_cadena;
        

        private void botCategoria_Click(object sender, EventArgs e)
        {
            
            frmCategorias frmncategoria = new frmCategorias();
            frmncategoria.Show();
        }

        private void nuevocampeonato_Load(object sender, EventArgs e)
        {
            fncCargagrid();
            

        }

        private void bot1_Click(object sender, EventArgs e)
        {

            try
            {
                S_cadena = "server = localhost; username = root; password = 12345; database = campeonato";
                SQL_conexion.ConnectionString = S_cadena;
                SQL_conexion.Open();                                                   
                SQL_cmd = new MySqlCommand("INSERT INTO macompetencia (vnomcompetencia, vdescripcion, vtipocompetencia,  dfechainicio, dfechafin, MaCATEGORIA_codcategoria) VALUES ('"+ txtNombre.Text +"' , '"+ txtDescripcion.Text +"' , '" +cmbTipoCompetencia.Text+"' , '"+dateInicio.Text+"' , '"+dateFinal.Text+"' , "+ txtCategoria.Text +" ); ", SQL_conexion);


                MySqlDataReader MyReader2;
                MyReader2 = SQL_cmd.ExecuteReader();
                MessageBox.Show("Datos Insertados");
                while (MyReader2.Read())
                {
                }
                SQL_conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void bot2_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = cmbCategoria.Text;

        }


        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                S_cadena = "server = localhost; username = root; password = 12345; database = campeonato";
                SQL_conexion.ConnectionString = S_cadena;
                SQL_conexion.Open();

                SQL_cmd = new MySqlCommand("SELECT codcategoria FROM macategoria WHERE vnombrecategoria = '" + cmbCategoria.Text + "';", SQL_conexion);



                MySqlDataReader MyReader2;
                MyReader2 = SQL_cmd.ExecuteReader();
                while (MyReader2.Read())
                {
                    txtCategoria.Text = MyReader2.GetInt32(0).ToString();
                }
                SQL_conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fncCargagrid()
        {
            string sConexion = "server = localhost; username = root; password = 12345; database = campeonato";
            MySqlConnection SQL_conexion = new MySqlConnection();
            SQL_conexion.ConnectionString = sConexion;
            SQL_conexion.Open();
            MySqlDataAdapter SQL_da = new MySqlDataAdapter("Select * from macompetencia", SQL_conexion);
            DataTable DT_dat = new DataTable();
            SQL_da.Fill(DT_dat);
            this.dgvCampeonato.DataSource = DT_dat;
            SQL_conexion.Close();
        }
    }
}
