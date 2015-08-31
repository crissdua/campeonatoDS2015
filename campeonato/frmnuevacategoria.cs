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
    public partial class frmnuevacategoria : Form
    {
        public frmnuevacategoria()
        {
            InitializeComponent();
        }

        private MySqlCommand SQL_cmd;
        private MySqlConnection SQL_conexion = new MySqlConnection();
        private String S_cadena;
       

        private void btnRegreso_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                S_cadena = "server = localhost; username = root; password = 12345; database = campeonato";
                SQL_conexion.ConnectionString = S_cadena;
                SQL_conexion.Open();
                SQL_cmd = new MySqlCommand("INSERT INTO macategoria (vnombrecategoria, nedadcategoria, vgenerocategoria, vobsecategoria) VALUES ('" + txtNombreCampeonato.Text + "', "+ lstEdad.Text + " ,'" +  cmbGenero.Text + "', ' " + txtObervaciones.Text +"');" , SQL_conexion );

                MySqlDataReader MyReader2;
                MyReader2 = SQL_cmd.ExecuteReader();
                MessageBox.Show("Datos Insertados");
                    while(MyReader2.Read())
                    {
                    }
                SQL_conexion.Close();
            }  
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
