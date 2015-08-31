namespace campeonato
{
    partial class frmmenuprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenuprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campeonatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionDeJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripPartido = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosDisputadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresInscritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripPrivilegio = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripRegistro,
            this.stripProcesos,
            this.stripPartido,
            this.stripConsultas,
            this.stripReportes,
            this.stripMantenimiento,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 55);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // stripRegistro
            // 
            this.stripRegistro.AutoSize = false;
            this.stripRegistro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.campeonatosToolStripMenuItem});
            this.stripRegistro.Image = ((System.Drawing.Image)(resources.GetObject("stripRegistro.Image")));
            this.stripRegistro.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.stripRegistro.Name = "stripRegistro";
            this.stripRegistro.Size = new System.Drawing.Size(94, 51);
            this.stripRegistro.Text = "Registro";
            this.stripRegistro.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.stripRegistro.Click += new System.EventHandler(this.stripRegistro_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nuevoToolStripMenuItem.Text = "Empleado";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirToolStripMenuItem.Text = "Jugadores";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // campeonatosToolStripMenuItem
            // 
            this.campeonatosToolStripMenuItem.Name = "campeonatosToolStripMenuItem";
            this.campeonatosToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.campeonatosToolStripMenuItem.Text = "Campeonatos";
            this.campeonatosToolStripMenuItem.Click += new System.EventHandler(this.campeonatosToolStripMenuItem_Click);
            // 
            // stripProcesos
            // 
            this.stripProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionDeJugadoresToolStripMenuItem,
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem});
            this.stripProcesos.Image = ((System.Drawing.Image)(resources.GetObject("stripProcesos.Image")));
            this.stripProcesos.Name = "stripProcesos";
            this.stripProcesos.Size = new System.Drawing.Size(82, 51);
            this.stripProcesos.Text = "Procesos";
            // 
            // inscripcionDeJugadoresToolStripMenuItem
            // 
            this.inscripcionDeJugadoresToolStripMenuItem.Name = "inscripcionDeJugadoresToolStripMenuItem";
            this.inscripcionDeJugadoresToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.inscripcionDeJugadoresToolStripMenuItem.Text = "Inscripcion de Jugadores";
            this.inscripcionDeJugadoresToolStripMenuItem.Click += new System.EventHandler(this.inscripcionDeJugadoresToolStripMenuItem_Click);
            // 
            // inscripciónDeEquiposACampeonatosToolStripMenuItem
            // 
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem.Name = "inscripciónDeEquiposACampeonatosToolStripMenuItem";
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem.Text = "Inscripción de Equipos a Campeonatos";
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem.Click += new System.EventHandler(this.inscripciónDeEquiposACampeonatosToolStripMenuItem_Click);
            // 
            // stripPartido
            // 
            this.stripPartido.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPartidoToolStripMenuItem});
            this.stripPartido.Image = ((System.Drawing.Image)(resources.GetObject("stripPartido.Image")));
            this.stripPartido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripPartido.Name = "stripPartido";
            this.stripPartido.Size = new System.Drawing.Size(73, 51);
            this.stripPartido.Text = "Partido";
            // 
            // nuevoPartidoToolStripMenuItem
            // 
            this.nuevoPartidoToolStripMenuItem.Name = "nuevoPartidoToolStripMenuItem";
            this.nuevoPartidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoPartidoToolStripMenuItem.Text = "Nuevo Partido";
            this.nuevoPartidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPartidoToolStripMenuItem_Click);
            // 
            // stripConsultas
            // 
            this.stripConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionesToolStripMenuItem});
            this.stripConsultas.Image = ((System.Drawing.Image)(resources.GetObject("stripConsultas.Image")));
            this.stripConsultas.Name = "stripConsultas";
            this.stripConsultas.Size = new System.Drawing.Size(87, 51);
            this.stripConsultas.Text = "Consultas";
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // stripReportes
            // 
            this.stripReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidosDisputadosToolStripMenuItem,
            this.jugadoresInscritosToolStripMenuItem});
            this.stripReportes.Image = ((System.Drawing.Image)(resources.GetObject("stripReportes.Image")));
            this.stripReportes.Name = "stripReportes";
            this.stripReportes.Size = new System.Drawing.Size(81, 51);
            this.stripReportes.Text = "Reportes";
            // 
            // partidosDisputadosToolStripMenuItem
            // 
            this.partidosDisputadosToolStripMenuItem.Name = "partidosDisputadosToolStripMenuItem";
            this.partidosDisputadosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.partidosDisputadosToolStripMenuItem.Text = "Partidos Disputados";
            this.partidosDisputadosToolStripMenuItem.Click += new System.EventHandler(this.partidosDisputadosToolStripMenuItem_Click);
            // 
            // jugadoresInscritosToolStripMenuItem
            // 
            this.jugadoresInscritosToolStripMenuItem.Name = "jugadoresInscritosToolStripMenuItem";
            this.jugadoresInscritosToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.jugadoresInscritosToolStripMenuItem.Text = "Jugadores Inscritos";
            this.jugadoresInscritosToolStripMenuItem.Click += new System.EventHandler(this.jugadoresInscritosToolStripMenuItem_Click);
            // 
            // stripMantenimiento
            // 
            this.stripMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarBaseDeDatosToolStripMenuItem,
            this.restaurarBaseDeDatosToolStripMenuItem,
            this.cuentasDeUsuariosToolStripMenuItem});
            this.stripMantenimiento.Image = ((System.Drawing.Image)(resources.GetObject("stripMantenimiento.Image")));
            this.stripMantenimiento.Name = "stripMantenimiento";
            this.stripMantenimiento.Size = new System.Drawing.Size(117, 51);
            this.stripMantenimiento.Text = "Mantenimiento";
            // 
            // respaldarBaseDeDatosToolStripMenuItem
            // 
            this.respaldarBaseDeDatosToolStripMenuItem.Name = "respaldarBaseDeDatosToolStripMenuItem";
            this.respaldarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.respaldarBaseDeDatosToolStripMenuItem.Text = "Respaldar Base de Datos";
            // 
            // restaurarBaseDeDatosToolStripMenuItem
            // 
            this.restaurarBaseDeDatosToolStripMenuItem.Name = "restaurarBaseDeDatosToolStripMenuItem";
            this.restaurarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.restaurarBaseDeDatosToolStripMenuItem.Text = "Restaurar Base de Datos";
            // 
            // cuentasDeUsuariosToolStripMenuItem
            // 
            this.cuentasDeUsuariosToolStripMenuItem.Name = "cuentasDeUsuariosToolStripMenuItem";
            this.cuentasDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cuentasDeUsuariosToolStripMenuItem.Text = "Cuentas de Usuarios";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem2});
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(41, 51);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem2
            // 
            this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            this.salirToolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem2.Text = "Salir";
            this.salirToolStripMenuItem2.Click += new System.EventHandler(this.salirToolStripMenuItem2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripUsuario,
            this.stripPrivilegio});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(794, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripUsuario
            // 
            this.stripUsuario.Name = "stripUsuario";
            this.stripUsuario.Size = new System.Drawing.Size(118, 17);
            this.stripUsuario.Text = "toolStripStatusLabel1";
            // 
            // stripPrivilegio
            // 
            this.stripPrivilegio.Name = "stripPrivilegio";
            this.stripPrivilegio.Size = new System.Drawing.Size(118, 17);
            this.stripPrivilegio.Text = "toolStripStatusLabel1";
            // 
            // frmmenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenuprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmmenuprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripRegistro;
        private System.Windows.Forms.ToolStripMenuItem stripProcesos;
        private System.Windows.Forms.ToolStripMenuItem inscripcionDeJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campeonatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripPartido;
        private System.Windows.Forms.ToolStripMenuItem nuevoPartidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripConsultas;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripReportes;
        private System.Windows.Forms.ToolStripMenuItem partidosDisputadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresInscritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem respaldarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónDeEquiposACampeonatosToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripPrivilegio;
        private System.Windows.Forms.ToolStripStatusLabel stripUsuario;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;

    }
}