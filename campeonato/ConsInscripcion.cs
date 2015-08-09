using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace campeonato
{
    public partial class ConsInscripcion : Form
    {
        public ConsInscripcion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ConsInscripcion_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Cedula");
            comboBox1.Items.Add("Campeonato");
            comboBox1.Items.Add("Nombre");
        }
    }
}
