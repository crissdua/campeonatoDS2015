namespace campeonato
{
    partial class nuevoequipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevoequipo));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bo3 = new System.Windows.Forms.Button();
            this.bo2 = new System.Windows.Forms.Button();
            this.bo1 = new System.Windows.Forms.Button();
            this.mausuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.campeonatoDataSet = new campeonato.campeonatoDataSet();
            this.mausuarioTableAdapter = new campeonato.campeonatoDataSetTableAdapters.mausuarioTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mausuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Equipo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(85, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 20);
            this.textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bo3);
            this.groupBox2.Controls.Add(this.bo2);
            this.groupBox2.Controls.Add(this.bo1);
            this.groupBox2.Location = new System.Drawing.Point(108, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 84);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // bo3
            // 
            this.bo3.Image = ((System.Drawing.Image)(resources.GetObject("bo3.Image")));
            this.bo3.Location = new System.Drawing.Point(178, 19);
            this.bo3.Name = "bo3";
            this.bo3.Size = new System.Drawing.Size(75, 53);
            this.bo3.TabIndex = 2;
            this.bo3.Text = "Modificar";
            this.bo3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bo3.UseVisualStyleBackColor = true;
            // 
            // bo2
            // 
            this.bo2.Image = ((System.Drawing.Image)(resources.GetObject("bo2.Image")));
            this.bo2.Location = new System.Drawing.Point(97, 19);
            this.bo2.Name = "bo2";
            this.bo2.Size = new System.Drawing.Size(75, 53);
            this.bo2.TabIndex = 1;
            this.bo2.Text = "Eliminar";
            this.bo2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bo2.UseVisualStyleBackColor = true;
            // 
            // bo1
            // 
            this.bo1.Image = ((System.Drawing.Image)(resources.GetObject("bo1.Image")));
            this.bo1.Location = new System.Drawing.Point(16, 19);
            this.bo1.Name = "bo1";
            this.bo1.Size = new System.Drawing.Size(75, 53);
            this.bo1.TabIndex = 0;
            this.bo1.Text = "Guardar";
            this.bo1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bo1.UseVisualStyleBackColor = true;
            // 
            // mausuarioBindingSource
            // 
            this.mausuarioBindingSource.DataMember = "mausuario";
            this.mausuarioBindingSource.DataSource = this.campeonatoDataSet;
            // 
            // campeonatoDataSet
            // 
            this.campeonatoDataSet.DataSetName = "campeonatoDataSet";
            this.campeonatoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mausuarioTableAdapter
            // 
            this.mausuarioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // nuevoequipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nuevoequipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nuevoequipo";
            this.Load += new System.EventHandler(this.nuevoequipo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mausuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bo3;
        private System.Windows.Forms.Button bo2;
        private System.Windows.Forms.Button bo1;
        private campeonatoDataSet campeonatoDataSet;
        private System.Windows.Forms.BindingSource mausuarioBindingSource;
        private campeonatoDataSetTableAdapters.mausuarioTableAdapter mausuarioTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}