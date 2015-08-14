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
    public partial class frmmenuprincipal : Form
    {
        public frmmenuprincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void campeonatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevoempleado frmnempleado = new frmnuevoempleado();
            frmnempleado.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevojugador frmnjugador = new frmnuevojugador();
            frmnjugador.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevoequipo frmnequipo = new frmnuevoequipo();
            frmnequipo.Show();
        }

        private void jugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevocampeonato frmncampeonato = new frmnuevocampeonato();
            frmncampeonato.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevoempleado frmnempleado = new frmnuevoempleado();
            frmnempleado.Show();


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevojugador frmnjugador = new frmnuevojugador();
            frmnjugador.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevoequipo frmnequipo = new frmnuevoequipo();
            frmnequipo.Show();
        }

        private void campeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevocampeonato frmncampeonato = new frmnuevocampeonato();
            frmncampeonato.Show();
        }

        private void inscripcionDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscJugador frmnInscJugador = new frmInscJugador();
            frmnInscJugador.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsInscripcion frmnConsInscripcion = new ConsInscripcion();
            frmnConsInscripcion.Show();
        }

        private void jugadoresInscritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuacion se mostrara el reporte de jugadores inscritos");
        }

        private void partidosDisputadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuacion se mostrara el reporte de partidos disputados");
        }

        private void nuevoPartidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevoPartido frmnNuevoPartido = new frmNuevoPartido();
            frmnNuevoPartido.Show();
        }
    }
}
