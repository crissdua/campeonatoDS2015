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
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campeonatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionDeJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPartidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partidosDisputadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadoresInscritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.partidoToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 55);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.AutoSize = false;
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.campeonatosToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(94, 51);
            this.registroToolStripMenuItem.Text = "Registro";
            this.registroToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
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
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionDeJugadoresToolStripMenuItem,
            this.inscripciónDeEquiposACampeonatosToolStripMenuItem});
            this.procesosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("procesosToolStripMenuItem.Image")));
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(82, 51);
            this.procesosToolStripMenuItem.Text = "Procesos";
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
            // partidoToolStripMenuItem
            // 
            this.partidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPartidoToolStripMenuItem});
            this.partidoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("partidoToolStripMenuItem.Image")));
            this.partidoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.partidoToolStripMenuItem.Name = "partidoToolStripMenuItem";
            this.partidoToolStripMenuItem.Size = new System.Drawing.Size(73, 51);
            this.partidoToolStripMenuItem.Text = "Partido";
            // 
            // nuevoPartidoToolStripMenuItem
            // 
            this.nuevoPartidoToolStripMenuItem.Name = "nuevoPartidoToolStripMenuItem";
            this.nuevoPartidoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.nuevoPartidoToolStripMenuItem.Text = "Nuevo Partido";
            this.nuevoPartidoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPartidoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscripcionesToolStripMenuItem});
            this.consultasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasToolStripMenuItem.Image")));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(87, 51);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partidosDisputadosToolStripMenuItem,
            this.jugadoresInscritosToolStripMenuItem});
            this.reportesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportesToolStripMenuItem.Image")));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 51);
            this.reportesToolStripMenuItem.Text = "Reportes";
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
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.respaldarBaseDeDatosToolStripMenuItem,
            this.restaurarBaseDeDatosToolStripMenuItem,
            this.cuentasDeUsuariosToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(117, 51);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
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
            // frmmenuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(794, 572);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionDeJugadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campeonatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPartidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partidosDisputadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadoresInscritosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripciónDeEquiposACampeonatosToolStripMenuItem;

    }
}