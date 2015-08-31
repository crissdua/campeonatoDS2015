namespace campeonato
{
    partial class frmIniciaPartido
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
            this.cbxLocal = new System.Windows.Forms.ComboBox();
            this.cbxVisitante = new System.Windows.Forms.ComboBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmCampeonato = new System.Windows.Forms.ComboBox();
            this.lblCompetencia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Equipos que Jugaran:";
            // 
            // cbxLocal
            // 
            this.cbxLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocal.FormattingEnabled = true;
            this.cbxLocal.Location = new System.Drawing.Point(47, 114);
            this.cbxLocal.Name = "cbxLocal";
            this.cbxLocal.Size = new System.Drawing.Size(211, 21);
            this.cbxLocal.TabIndex = 1;
            this.cbxLocal.SelectedIndexChanged += new System.EventHandler(this.cbxLocal_SelectedIndexChanged);
            // 
            // cbxVisitante
            // 
            this.cbxVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVisitante.FormattingEnabled = true;
            this.cbxVisitante.Location = new System.Drawing.Point(330, 114);
            this.cbxVisitante.Name = "cbxVisitante";
            this.cbxVisitante.Size = new System.Drawing.Size(211, 21);
            this.cbxVisitante.TabIndex = 2;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(257, 151);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 3;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleccione Campeonato:";
            // 
            // cbmCampeonato
            // 
            this.cbmCampeonato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmCampeonato.FormattingEnabled = true;
            this.cbmCampeonato.Location = new System.Drawing.Point(184, 41);
            this.cbmCampeonato.Name = "cbmCampeonato";
            this.cbmCampeonato.Size = new System.Drawing.Size(214, 21);
            this.cbmCampeonato.TabIndex = 5;
            this.cbmCampeonato.SelectedIndexChanged += new System.EventHandler(this.cbmCampeonato_SelectedIndexChanged);
            // 
            // lblCompetencia
            // 
            this.lblCompetencia.AutoSize = true;
            this.lblCompetencia.Location = new System.Drawing.Point(287, 65);
            this.lblCompetencia.Name = "lblCompetencia";
            this.lblCompetencia.Size = new System.Drawing.Size(10, 13);
            this.lblCompetencia.TabIndex = 6;
            this.lblCompetencia.Text = ".";
            // 
            // frmIniciaPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 189);
            this.Controls.Add(this.lblCompetencia);
            this.Controls.Add(this.cbmCampeonato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.cbxVisitante);
            this.Controls.Add(this.cbxLocal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIniciaPartido";
            this.Text = "frmIniciaPartido";
            this.Load += new System.EventHandler(this.frmIniciaPartido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLocal;
        private System.Windows.Forms.ComboBox cbxVisitante;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmCampeonato;
        private System.Windows.Forms.Label lblCompetencia;
    }
}