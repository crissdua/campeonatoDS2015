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
    public partial class frmIniciaPartido : Form
    {
        public frmIniciaPartido()
        {
            InitializeComponent();
        }
        public static string sEquipoLocal;
        public static string sEquipoVisitante;
        public static string sidLocal;
        public static string sidVisitante;

        private void frmIniciaPartido_Load(object sender, EventArgs e)
        {
            try { 
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select vnombreequipo, ncodequipo from maequipo", cConectar.SqlConexion);
            DataTable DT_box = new DataTable();
            cConectar.sqlData.Fill(DT_box);
            foreach (DataRow row in DT_box.Rows)
            {
                string rowz = row.ItemArray.ToString();
            }
            DataTable DT_box2 = new DataTable();
            cConectar.sqlData.Fill(DT_box2);
            foreach (DataRow row in DT_box.Rows)
            {
                string rowy = row.ItemArray.ToString();
            }
            cbxLocal.DataSource = DT_box;
            cbxVisitante.DataSource = DT_box2;
            cbxLocal.DisplayMember = "vnombreequipo";
            cbxVisitante.DisplayMember = "vnombreequipo";
            cConectar.SqlConexion.Close();
            }

            catch (MySqlException)
            {
                MessageBox.Show("Error en BD");
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try { 
            if (cbxLocal.Text == cbxVisitante.Text){MessageBox.Show("Error No puede competir el mismo Equipo");}else{
                dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
                cConectar.cLocal();
                cConectar.sqlData = new MySqlDataAdapter("Select ncodequipo from maequipo WHERE vnombreequipo='" + cbxLocal.Text + "'", cConectar.SqlConexion);
                DataTable DT_dat = new DataTable();
                cConectar.sqlData.Fill(DT_dat);
                sidLocal = DT_dat.Rows[0][0].ToString();
                cConectar.SqlConexion.Close();
                cConectar.sqlData = new MySqlDataAdapter("Select ncodequipo from maequipo WHERE vnombreequipo='" + cbxVisitante.Text + "'", cConectar.SqlConexion);
                DataTable DT_dat2 = new DataTable();
                cConectar.sqlData.Fill(DT_dat2);
                sidVisitante = DT_dat2.Rows[0][0].ToString();
                cConectar.SqlConexion.Close();
                frmPartido frmnNuevoPartidoenvivo = new frmPartido();
                //frmnNuevoPartidoenvivo.MdiParent = this;
                // frmnNuevoPartido.WindowState = FormWindowState.Maximized;
                sEquipoLocal = cbxLocal.Text;
                sEquipoVisitante = cbxVisitante.Text;
                frmPartido frmnPartido = new frmPartido();
                frmnPartido.MdiParent = frmmenuprincipal.ActiveForm;
                frmnPartido.Show();
                this.Close();
                }
            }

            catch (MySqlException)
            {
                MessageBox.Show("Error en BD");
            }
        }
    }
}
