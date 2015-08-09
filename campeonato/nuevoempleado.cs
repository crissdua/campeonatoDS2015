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
    public partial class nuevoempleado : Form
    {
        public nuevoempleado()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nuevoempleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'campeonatoDataSet.maequipo' Puede moverla o quitarla según sea necesario.
            this.maequipoTableAdapter.Fill(this.campeonatoDataSet.maequipo);
            // TODO: esta línea de código carga datos en la tabla 'campeonatoDataSet.mausuario' Puede moverla o quitarla según sea necesario.
            this.mausuarioTableAdapter.Fill(this.campeonatoDataSet.mausuario);

        }
    }
}
