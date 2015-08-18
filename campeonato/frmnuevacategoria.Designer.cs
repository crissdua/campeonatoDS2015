namespace campeonato
{
    partial class frmnuevacategoria
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCampeonato = new System.Windows.Forms.TextBox();
            this.lstEdad = new System.Windows.Forms.ListBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtObervaciones = new System.Windows.Forms.TextBox();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Limite de edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Observaciones";
            // 
            // txtNombreCampeonato
            // 
            this.txtNombreCampeonato.Location = new System.Drawing.Point(120, 36);
            this.txtNombreCampeonato.Name = "txtNombreCampeonato";
            this.txtNombreCampeonato.Size = new System.Drawing.Size(157, 20);
            this.txtNombreCampeonato.TabIndex = 4;
            // 
            // lstEdad
            // 
            this.lstEdad.FormattingEnabled = true;
            this.lstEdad.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.lstEdad.Location = new System.Drawing.Point(132, 69);
            this.lstEdad.Name = "lstEdad";
            this.lstEdad.Size = new System.Drawing.Size(76, 30);
            this.lstEdad.TabIndex = 5;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(120, 118);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(157, 21);
            this.cmbGenero.TabIndex = 6;
            // 
            // txtObervaciones
            // 
            this.txtObervaciones.Location = new System.Drawing.Point(132, 162);
            this.txtObervaciones.Multiline = true;
            this.txtObervaciones.Name = "txtObervaciones";
            this.txtObervaciones.Size = new System.Drawing.Size(145, 65);
            this.txtObervaciones.TabIndex = 7;
            // 
            // btnRegreso
            // 
            this.btnRegreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegreso.Location = new System.Drawing.Point(415, 138);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(142, 44);
            this.btnRegreso.TabIndex = 8;
            this.btnRegreso.Text = "Regresar";
            this.btnRegreso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(415, 69);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 44);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmnuevacategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 270);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.txtObervaciones);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.lstEdad);
            this.Controls.Add(this.txtNombreCampeonato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmnuevacategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "nuevacategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCampeonato;
        private System.Windows.Forms.ListBox lstEdad;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtObervaciones;
        private System.Windows.Forms.Button btnRegreso;
        private System.Windows.Forms.Button btnGuardar;
    }
}