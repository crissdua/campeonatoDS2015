namespace campeonato
{
    partial class nuevocampeonato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nuevocampeonato));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bot3 = new System.Windows.Forms.Button();
            this.bot2 = new System.Windows.Forms.Button();
            this.bot1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bot3);
            this.groupBox2.Controls.Add(this.bot2);
            this.groupBox2.Controls.Add(this.bot1);
            this.groupBox2.Location = new System.Drawing.Point(109, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 84);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
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
            // 
            // bot1
            // 
            this.bot1.Image = ((System.Drawing.Image)(resources.GetObject("bot1.Image")));
            this.bot1.Location = new System.Drawing.Point(16, 19);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(75, 53);
            this.bot1.TabIndex = 0;
            this.bot1.Text = "Guardar";
            this.bot1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bot1.UseVisualStyleBackColor = true;
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
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 80);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 6;
            // 
            // nuevocampeonato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nuevocampeonato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "campeonato";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bot3;
        private System.Windows.Forms.Button bot2;
        private System.Windows.Forms.Button bot1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
    }
}