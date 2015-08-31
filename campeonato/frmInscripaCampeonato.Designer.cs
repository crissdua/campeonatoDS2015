namespace campeonato
{
    partial class frmInscripaCampeonato
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCodigoEquipo = new System.Windows.Forms.Label();
            this.lblCodigoCompetencia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.cmbCompetencia = new System.Windows.Forms.ComboBox();
            this.dgvCampeonato = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblComparacion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de competencia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Equipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lblComparacion);
            this.groupBox1.Controls.Add(this.lblCodigoEquipo);
            this.groupBox1.Controls.Add(this.lblCodigoCompetencia);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbEquipo);
            this.groupBox1.Controls.Add(this.cmbCompetencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(83, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscripción";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblCodigoEquipo
            // 
            this.lblCodigoEquipo.AutoSize = true;
            this.lblCodigoEquipo.Location = new System.Drawing.Point(474, 89);
            this.lblCodigoEquipo.Name = "lblCodigoEquipo";
            this.lblCodigoEquipo.Size = new System.Drawing.Size(35, 13);
            this.lblCodigoEquipo.TabIndex = 7;
            this.lblCodigoEquipo.Text = "label4";
            // 
            // lblCodigoCompetencia
            // 
            this.lblCodigoCompetencia.AutoSize = true;
            this.lblCodigoCompetencia.Location = new System.Drawing.Point(473, 46);
            this.lblCodigoCompetencia.Name = "lblCodigoCompetencia";
            this.lblCodigoCompetencia.Size = new System.Drawing.Size(35, 13);
            this.lblCodigoCompetencia.TabIndex = 6;
            this.lblCodigoCompetencia.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inscribir Equipo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(240, 89);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(227, 21);
            this.cmbEquipo.TabIndex = 4;
            this.cmbEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbEquipo_SelectedIndexChanged);
            // 
            // cmbCompetencia
            // 
            this.cmbCompetencia.FormattingEnabled = true;
            this.cmbCompetencia.Location = new System.Drawing.Point(240, 43);
            this.cmbCompetencia.Name = "cmbCompetencia";
            this.cmbCompetencia.Size = new System.Drawing.Size(227, 21);
            this.cmbCompetencia.TabIndex = 3;
            this.cmbCompetencia.SelectedIndexChanged += new System.EventHandler(this.cmbCompetencia_SelectedIndexChanged);
            // 
            // dgvCampeonato
            // 
            this.dgvCampeonato.AllowUserToAddRows = false;
            this.dgvCampeonato.AllowUserToDeleteRows = false;
            this.dgvCampeonato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCampeonato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCampeonato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampeonato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvCampeonato.Location = new System.Drawing.Point(12, 198);
            this.dgvCampeonato.Name = "dgvCampeonato";
            this.dgvCampeonato.ReadOnly = true;
            this.dgvCampeonato.Size = new System.Drawing.Size(776, 159);
            this.dgvCampeonato.TabIndex = 4;
            this.dgvCampeonato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampeonato_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lblComparacion
            // 
            this.lblComparacion.AutoSize = true;
            this.lblComparacion.Location = new System.Drawing.Point(473, 122);
            this.lblComparacion.Name = "lblComparacion";
            this.lblComparacion.Size = new System.Drawing.Size(35, 13);
            this.lblComparacion.TabIndex = 8;
            this.lblComparacion.Text = "label4";
            // 
            // frmInscripaCampeonato
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(846, 369);
            this.Controls.Add(this.dgvCampeonato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInscripaCampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripción de Equipos a Campeonatos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.btnInscripcion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.ComboBox cmbCompetencia;
        private System.Windows.Forms.DataGridView dgvCampeonato;
        private System.Windows.Forms.Label lblCodigoEquipo;
        private System.Windows.Forms.Label lblCodigoCompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblComparacion;
    }
}