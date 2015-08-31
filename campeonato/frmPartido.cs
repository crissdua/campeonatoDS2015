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
    public partial class frmPartido : Form
    {
        public frmPartido()
        {
            InitializeComponent();
        }

        private void frmPartido_Load(object sender, EventArgs e)
        {
            idLocal.Text = frmIniciaPartido.sidLocal;
            idVisitante.Text = frmIniciaPartido.sidVisitante;
            eLocal.Text = frmIniciaPartido.sEquipoLocal;
            eVisitante.Text = frmIniciaPartido.sEquipoVisitante;
            cmbEquipoGol.Items.Add(eLocal.Text);
            cmbEquipoGol.Items.Add(eVisitante.Text);
            cmbEquipoTarjeta.Items.Add(eLocal.Text);
            cmbEquipoTarjeta.Items.Add(eVisitante.Text);
        }

        private void cmbEquipoGol_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (cmbEquipoGol.Text == eLocal.Text ){idGol.Text = idLocal.Text;}else{idGol.Text = idVisitante.Text;}
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select majugador.vnombrejugador from majugador INNER JOIN maequipo ON majugador.MaEQUIPO_ncodequipo = maequipo.ncodequipo WHERE maequipo.ncodequipo = '" + idGol.Text + "';", cConectar.SqlConexion);
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
            cbxJugadorGol.DataSource = DT_box;
            cbxJugadorGol.DisplayMember = "vnombrejugador";
            cConectar.SqlConexion.Close();
            }

            catch (MySqlException)
            {
                MessageBox.Show("Error en BD");
            }
        }

        private void cmbEquipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            if (cmbEquipoTarjeta.Text == eLocal.Text) { idTarjeta.Text = idLocal.Text; } else { idTarjeta.Text = idVisitante.Text; }
            dll_conexion.Conexion cConectar = new dll_conexion.Conexion();
            cConectar.cLocal();
            cConectar.sqlData = new MySqlDataAdapter("Select majugador.vnombrejugador from majugador INNER JOIN maequipo ON majugador.MaEQUIPO_ncodequipo = maequipo.ncodequipo WHERE maequipo.ncodequipo = '" + idTarjeta.Text + "';", cConectar.SqlConexion);
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
            cbxJugadorTarjeta.DataSource = DT_box;
            cbxJugadorTarjeta.DisplayMember = "vnombrejugador";
            cConectar.SqlConexion.Close();
            }

            catch (MySqlException)
            {
                MessageBox.Show("Error en BD");
            }
        }







    }
}
