namespace campeonato
{
    partial class frmCategorias
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
            this.macategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.macategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnNuevaCategoria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // macategoriaBindingSource1
            // 
            this.macategoriaBindingSource1.DataMember = "macategoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorías Disponibles";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(154, 267);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(176, 41);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnNuevaCategoria
            // 
            this.btnNuevaCategoria.Location = new System.Drawing.Point(436, 267);
            this.btnNuevaCategoria.Name = "btnNuevaCategoria";
            this.btnNuevaCategoria.Size = new System.Drawing.Size(143, 41);
            this.btnNuevaCategoria.TabIndex = 3;
            this.btnNuevaCategoria.Text = "Nueva Categoría";
            this.btnNuevaCategoria.UseVisualStyleBackColor = true;
            this.btnNuevaCategoria.Click += new System.EventHandler(this.btnNuevaCategoria_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvCategoria);
            this.panel1.Location = new System.Drawing.Point(60, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 200);
            this.panel1.TabIndex = 4;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(3, 3);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(633, 194);
            this.dgvCategoria.TabIndex = 0;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 320);
            this.Controls.Add(this.btnNuevaCategoria);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCategorias";
            this.Text = "categorias";
            this.Load += new System.EventHandler(this.categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnNuevaCategoria;
       // private campeonatoDataSet campeonatoDataSet;
        private System.Windows.Forms.BindingSource macategoriaBindingSource;
        //private campeonatoDataSetTableAdapters.macategoriaTableAdapter macategoriaTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnombrecategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedadcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vgenerocategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vobsecategoriaDataGridViewTextBoxColumn;
        //private campeonatoDataSet2 campeonatoDataSet2;
        private System.Windows.Forms.BindingSource macategoriaBindingSource1;
        private System.Windows.Forms.DataGridView dgvCategoria;
        //private campeonatoDataSet2TableAdapters.macategoriaTableAdapter macategoriaTableAdapter1;
    }
}