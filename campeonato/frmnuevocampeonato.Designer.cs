namespace campeonato
{
    partial class frmnuevocampeonato
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnuevocampeonato));
            this.macompetenciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.macompetenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.bot3 = new System.Windows.Forms.Button();
            this.bot2 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCategoria1 = new System.Windows.Forms.Label();
            this.botCategoria = new System.Windows.Forms.Button();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateFinal = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoCompetencia = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateInicio = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.macategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campeonatoDataSet = new campeonato.campeonatoDataSet();
            this.macategoriaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.macategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvCampeonato = new System.Windows.Forms.DataGridView();
            this.macategoriaTableAdapter = new campeonato.campeonatoDataSetTableAdapters.macategoriaTableAdapter();
            this.lblCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.macompetenciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macompetenciaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).BeginInit();
            this.SuspendLayout();
            // 
            // macompetenciaBindingSource1
            // 
            this.macompetenciaBindingSource1.DataMember = "macompetencia";
            // 
            // macompetenciaBindingSource
            // 
            this.macompetenciaBindingSource.DataMember = "macompetencia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGuarda);
            this.groupBox2.Controls.Add(this.bot3);
            this.groupBox2.Controls.Add(this.bot2);
            this.groupBox2.Location = new System.Drawing.Point(559, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnGuarda
            // 
            this.btnGuarda.Image = ((System.Drawing.Image)(resources.GetObject("btnGuarda.Image")));
            this.btnGuarda.Location = new System.Drawing.Point(16, 18);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(75, 53);
            this.btnGuarda.TabIndex = 3;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // bot3
            // 
            this.bot3.Image = ((System.Drawing.Image)(resources.GetObject("bot3.Image")));
            this.bot3.Location = new System.Drawing.Point(178, 19);
            this.bot3.Name = "bot3";
            this.bot3.Size = new System.Drawing.Size(75, 53);
            this.bot3.TabIndex = 2;
            this.bot3.Text = "Modificar";
            this.bot3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bot3.UseVisualStyleBackColor = true;
            this.bot3.Click += new System.EventHandler(this.btnModificar);
            // 
            // bot2
            // 
            this.bot2.Image = ((System.Drawing.Image)(resources.GetObject("bot2.Image")));
            this.bot2.Location = new System.Drawing.Point(97, 19);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(75, 53);
            this.bot2.TabIndex = 1;
            this.bot2.Text = "Eliminar";
            this.bot2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bot2.UseVisualStyleBackColor = true;
            this.bot2.Click += new System.EventHandler(this.btnEliminar);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(127, 13);
            this.Nombre.TabIndex = 4;
            this.Nombre.Text = "Nombre del Campeonato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCategoria1);
            this.groupBox1.Controls.Add(this.botCategoria);
            this.groupBox1.Controls.Add(this.txtCategoria);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateFinal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbTipoCompetencia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateInicio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // lblCategoria1
            // 
            this.lblCategoria1.AutoSize = true;
            this.lblCategoria1.Location = new System.Drawing.Point(410, 75);
            this.lblCategoria1.Name = "lblCategoria1";
            this.lblCategoria1.Size = new System.Drawing.Size(35, 13);
            this.lblCategoria1.TabIndex = 19;
            this.lblCategoria1.Text = "label4";
            // 
            // botCategoria
            // 
            this.botCategoria.Location = new System.Drawing.Point(279, 45);
            this.botCategoria.Name = "botCategoria";
            this.botCategoria.Size = new System.Drawing.Size(118, 21);
            this.botCategoria.TabIndex = 7;
            this.botCategoria.Text = "Verificar Categorias";
            this.botCategoria.UseVisualStyleBackColor = true;
            this.botCategoria.Click += new System.EventHandler(this.botCategoria_Click);
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(403, 45);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtCategoria.TabIndex = 18;
            this.txtCategoria.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(144, 176);
            this.txtDescripcion.MaxLength = 300;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(301, 60);
            this.txtDescripcion.TabIndex = 17;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(140, 45);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 16;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Categoría:";
            // 
            // dateFinal
            // 
            this.dateFinal.Location = new System.Drawing.Point(140, 138);
            this.dateFinal.Name = "dateFinal";
            this.dateFinal.Size = new System.Drawing.Size(200, 20);
            this.dateFinal.TabIndex = 14;
            this.dateFinal.Value = new System.DateTime(2015, 8, 10, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripción / Justificación";
            // 
            // cmbTipoCompetencia
            // 
            this.cmbTipoCompetencia.FormattingEnabled = true;
            this.cmbTipoCompetencia.Items.AddRange(new object[] {
            "Ida y Vuelta",
            "Eliminación Directa"});
            this.cmbTipoCompetencia.Location = new System.Drawing.Point(140, 72);
            this.cmbTipoCompetencia.Name = "cmbTipoCompetencia";
            this.cmbTipoCompetencia.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCompetencia.TabIndex = 10;
            this.cmbTipoCompetencia.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCompetencia_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo de Competencia:";
            // 
            // dateInicio
            // 
            this.dateInicio.CustomFormat = "0000/00/00";
            this.dateInicio.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateInicio.Location = new System.Drawing.Point(140, 109);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Size = new System.Drawing.Size(200, 20);
            this.dateInicio.TabIndex = 7;
            this.dateInicio.Value = new System.DateTime(2015, 8, 10, 0, 0, 0, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 19);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // macategoriaBindingSource
            // 
            this.macategoriaBindingSource.DataMember = "macategoria";
            this.macategoriaBindingSource.DataSource = this.campeonatoDataSet;
            // 
            // campeonatoDataSet
            // 
            this.campeonatoDataSet.DataSetName = "campeonatoDataSet";
            this.campeonatoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // macategoriaBindingSource2
            // 
            this.macategoriaBindingSource2.DataMember = "macategoria";
            // 
            // macategoriaBindingSource1
            // 
            this.macategoriaBindingSource1.DataMember = "macategoria";
            // 
            // dgvCampeonato
            // 
            this.dgvCampeonato.AllowUserToAddRows = false;
            this.dgvCampeonato.AllowUserToDeleteRows = false;
            this.dgvCampeonato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampeonato.Location = new System.Drawing.Point(36, 312);
            this.dgvCampeonato.Name = "dgvCampeonato";
            this.dgvCampeonato.ReadOnly = true;
            this.dgvCampeonato.Size = new System.Drawing.Size(776, 193);
            this.dgvCampeonato.TabIndex = 7;
            this.dgvCampeonato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampeonato_CellContentClick);
            // 
            // macategoriaTableAdapter
            // 
            this.macategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(559, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(35, 13);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "label4";
            // 
            // frmnuevocampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 545);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.dgvCampeonato);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmnuevocampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campeonato";
            this.Load += new System.EventHandler(this.nuevocampeonato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.macompetenciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macompetenciaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeonato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bot3;
        private System.Windows.Forms.Button bot2;
       // private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateInicio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoCompetencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.BindingSource macompetenciaBindingSource;
        private System.Windows.Forms.BindingSource macategoriaBindingSource1;
        private System.Windows.Forms.BindingSource macompetenciaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncodcompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnomcompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vdescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vtipocompetenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dfechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCATEGORIAcodcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource macategoriaBindingSource2;
        private System.Windows.Forms.DataGridView dgvCampeonato;
        private campeonatoDataSet campeonatoDataSet;
        private System.Windows.Forms.BindingSource macategoriaBindingSource;
        private campeonatoDataSetTableAdapters.macategoriaTableAdapter macategoriaTableAdapter;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCategoria1;
        private System.Windows.Forms.Button btnGuarda;
    }
}