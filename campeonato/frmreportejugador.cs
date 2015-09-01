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
    public partial class frmreportejugador : Form
    {
        public frmreportejugador()
        {
            InitializeComponent();
        }

        private void frmreportejugador_Load(object sender, EventArgs e)
        {

            fncCargacmb1();
        }

        private void fncCargacmb1()
        {

            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select vnombreequipo from maequipo", cConectar.SqlConexion);
                DataTable DT_box = new DataTable();
                cConectar.sqlData.Fill(DT_box);
                foreach (DataRow row in DT_box.Rows)
                {
                    string rowz = row.ItemArray.ToString();
                }
                cbmEquipo.DataSource = DT_box;
                cbmEquipo.DisplayMember = "vnombreequipo";

                cConectar.SqlConexion.Close();
            }

            catch
            {
                MessageBox.Show("Problema en BD, Competencia");
            }

        }

        private void cbmEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlCmd = new MySqlCommand("Select ncodequipo from maequipo where vnombreequipo = '" + cbmEquipo.Text + "';", cConectar.SqlConexion);
                MySqlDataReader MyReader3;
                MyReader3 = cConectar.sqlCmd.ExecuteReader();

                while (MyReader3.Read())
                {
                    lblCodigoEquipo.Text = MyReader3.GetInt32(0).ToString();
                    fncCargagrid();
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


            try
            {
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                //cConectar.sqlData = new MySqlDataAdapter("SELECT *FROM trequipoencompetencia WHERE MaCOMPETENCIA_ncodcompetencia1 = "+ lblCodigoCompetencia.Text +";", cConectar.SqlConexion);
                cConectar.sqlData = new MySqlDataAdapter("select ndpijugador, vnombrejugador, vapejugador, nfechanacimiento, vsexojugador, vdireccionjugador, vtelefonojugador from majugador where maequipo_ncodequipo = '" +lblCodigoEquipo.Text + "';", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);

                this.dgvReporteJugador.DataSource = DT_dat;


                cConectar.SqlConexion.Close();
            }
            catch
            {
                MessageBox.Show("Problema en BD, Equipo en competencia GRID");
            }

        }

        private void dgvReporteJugador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
