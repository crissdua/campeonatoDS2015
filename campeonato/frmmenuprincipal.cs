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
            frmnempleado.MdiParent = this;
           // frmnempleado.WindowState = FormWindowState.Maximized;
            frmnempleado.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevojugador frmnjugador = new frmnuevojugador();
            frmnjugador.MdiParent = this;
            //frmnjugador.WindowState = FormWindowState.Maximized;
            frmnjugador.Show();
        }

        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevoequipo frmnequipo = new frmnuevoequipo();
            frmnequipo.MdiParent = this;
           // frmnequipo.WindowState = FormWindowState.Maximized;
            frmnequipo.Show();
        }

        private void jugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevocampeonato frmncampeonato = new frmnuevocampeonato();
            frmncampeonato.MdiParent = this;
           // frmncampeonato.WindowState = FormWindowState.Maximized;
            frmncampeonato.Show();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            frmnuevoempleado frmnempleado = new frmnuevoempleado();
            frmnempleado.MdiParent = this;
            //frmnempleado.WindowState = FormWindowState.Maximized;
            frmnempleado.Show();


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevojugador frmnjugador = new frmnuevojugador();
            frmnjugador.MdiParent = this;
            //frmnjugador.WindowState = FormWindowState.Maximized;
            frmnjugador.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevoequipo frmnequipo = new frmnuevoequipo();
            frmnequipo.MdiParent = this;
           // frmnequipo.WindowState = FormWindowState.Maximized;
            frmnequipo.Show();
        }

        private void campeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnuevocampeonato frmncampeonato = new frmnuevocampeonato();
            frmncampeonato.MdiParent = this;
            //frmncampeonato.WindowState = FormWindowState.Maximized;
            frmncampeonato.Show();
        }

        private void inscripcionDeJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscJugador frmnInscJugador = new frmInscJugador();
            frmnInscJugador.MdiParent = this;
           // frmnInscJugador.WindowState = FormWindowState.Maximized;
            frmnInscJugador.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsInscripcion frmnConsInscripcion = new ConsInscripcion();
            frmnConsInscripcion.MdiParent = this;
            //frmnConsInscripcion.WindowState = FormWindowState.Maximized;
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
            frmIniciaPartido frmnNuevoPartido = new frmIniciaPartido();
            frmnNuevoPartido.MdiParent = this;
            frmnNuevoPartido.Show();
        }

        private void inscripciónDeEquiposACampeonatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripaCampeonato frmInscripaCampeonato = new frmInscripaCampeonato();
            frmInscripaCampeonato.MdiParent = this;
            //frmInscripaCampeonato.WindowState = FormWindowState.Maximized;
            frmInscripaCampeonato.Show();
        }

        private void frmmenuprincipal_Load(object sender, EventArgs e)
        {

            stripPrivilegio.Text = frmlogin.sPrivilegio;
            stripUsuario.Text = frmlogin.sUsuario;
            if (stripPrivilegio.Text == "Usuario")
            {
                stripRegistro.Visible = false;
                stripProcesos.Visible = false;
                stripMantenimiento.Visible = false;


            }

        }

        private void stripRegistro_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmlogin frmlogin = new frmlogin();
            frmlogin.Show();

        }


    }
}
