namespace campeonato
{
    partial class frmreportejugador
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
            this.components = new System.ComponentModel.Container();
            this.majugadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campeonatoDataSet1 = new campeonato.campeonatoDataSet1();
            this.majugadorTableAdapter = new campeonato.campeonatoDataSet1TableAdapters.majugadorTableAdapter();
            this.dgvReporteJugador = new System.Windows.Forms.DataGridView();
            this.cbmEquipo = new System.Windows.Forms.ComboBox();
            this.lblCodigoEquipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.majugadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // majugadorBindingSource
            // 
            this.majugadorBindingSource.DataMember = "majugador";
            this.majugadorBindingSource.DataSource = this.campeonatoDataSet1;
            // 
            // campeonatoDataSet1
            // 
            this.campeonatoDataSet1.DataSetName = "campeonatoDataSet1";
            this.campeonatoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // majugadorTableAdapter
            // 
            this.majugadorTableAdapter.ClearBeforeFill = true;
            // 
            // dgvReporteJugador
            // 
            this.dgvReporteJugador.AllowUserToAddRows = false;
            this.dgvReporteJugador.AllowUserToDeleteRows = false;
            this.dgvReporteJugador.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReporteJugador.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteJugador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteJugador.Location = new System.Drawing.Point(45, 127);
            this.dgvReporteJugador.Name = "dgvReporteJugador";
            this.dgvReporteJugador.ReadOnly = true;
            this.dgvReporteJugador.Size = new System.Drawing.Size(625, 293);
            this.dgvReporteJugador.TabIndex = 0;
            this.dgvReporteJugador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReporteJugador_CellContentClick);
            // 
            // cbmEquipo
            // 
            this.cbmEquipo.FormattingEnabled = true;
            this.cbmEquipo.Location = new System.Drawing.Point(239, 80);
            this.cbmEquipo.Name = "cbmEquipo";
            this.cbmEquipo.Size = new System.Drawing.Size(210, 21);
            this.cbmEquipo.TabIndex = 1;
            this.cbmEquipo.SelectedIndexChanged += new System.EventHandler(this.cbmEquipo_SelectedIndexChanged);
            // 
            // lblCodigoEquipo
            // 
            this.lblCodigoEquipo.AutoSize = true;
            this.lblCodigoEquipo.Location = new System.Drawing.Point(468, 83);
            this.lblCodigoEquipo.Name = "lblCodigoEquipo";
            this.lblCodigoEquipo.Size = new System.Drawing.Size(10, 13);
            this.lblCodigoEquipo.TabIndex = 2;
            this.lblCodigoEquipo.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elija el nombre del equipo:";
            // 
            // frmreportejugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodigoEquipo);
            this.Controls.Add(this.cbmEquipo);
            this.Controls.Add(this.dgvReporteJugador);
            this.Name = "frmreportejugador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmreportejugador";
            this.Load += new System.EventHandler(this.frmreportejugador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.majugadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource majugadorBindingSource;
        private campeonatoDataSet1 campeonatoDataSet1;
        private campeonatoDataSet1TableAdapters.majugadorTableAdapter majugadorTableAdapter;
        private System.Windows.Forms.DataGridView dgvReporteJugador;
        private System.Windows.Forms.ComboBox cbmEquipo;
        private System.Windows.Forms.Label lblCodigoEquipo;
        private System.Windows.Forms.Label label1;
    }
}