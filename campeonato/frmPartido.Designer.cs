namespace campeonato
{
    partial class frmPartido
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
            this.cmbEstadoPartido = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idVisitante = new System.Windows.Forms.Label();
            this.idLocal = new System.Windows.Forms.Label();
            this.eVisitante = new System.Windows.Forms.Label();
            this.eLocal = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Gol = new System.Windows.Forms.TabPage();
            this.idGol = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.cbxJugadorGol = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbEquipoGol = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Tarjeta = new System.Windows.Forms.TabPage();
            this.idTarjeta = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.cbxJugadorTarjeta = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbEquipoTarjeta = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label20 = new System.Windows.Forms.Label();
            this.campeonatoDataSet = new campeonato.campeonatoDataSet();
            this.macategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.macategoriaTableAdapter = new campeonato.campeonatoDataSetTableAdapters.macategoriaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Gol.SuspendLayout();
            this.Tarjeta.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEstadoPartido
            // 
            this.cmbEstadoPartido.FormattingEnabled = true;
            this.cmbEstadoPartido.Items.AddRange(new object[] {
            "Iniciado",
            "Finalizado"});
            this.cmbEstadoPartido.Location = new System.Drawing.Point(15, 40);
            this.cmbEstadoPartido.Name = "cmbEstadoPartido";
            this.cmbEstadoPartido.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoPartido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado del Partido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(180, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jornada:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(420, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cancha No. :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(587, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.cmbEstadoPartido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 98);
            this.panel1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cod Partido";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.idVisitante);
            this.panel2.Controls.Add(this.idLocal);
            this.panel2.Controls.Add(this.eVisitante);
            this.panel2.Controls.Add(this.eLocal);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(34, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(720, 286);
            this.panel2.TabIndex = 9;
            // 
            // idVisitante
            // 
            this.idVisitante.AutoSize = true;
            this.idVisitante.Location = new System.Drawing.Point(568, 15);
            this.idVisitante.Name = "idVisitante";
            this.idVisitante.Size = new System.Drawing.Size(61, 13);
            this.idVisitante.TabIndex = 11;
            this.idVisitante.Text = "ID Visitante";
            this.idVisitante.Visible = false;
            // 
            // idLocal
            // 
            this.idLocal.AutoSize = true;
            this.idLocal.Location = new System.Drawing.Point(124, 15);
            this.idLocal.Name = "idLocal";
            this.idLocal.Size = new System.Drawing.Size(43, 13);
            this.idLocal.TabIndex = 10;
            this.idLocal.Text = "ID local";
            this.idLocal.Visible = false;
            // 
            // eVisitante
            // 
            this.eVisitante.AutoSize = true;
            this.eVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eVisitante.Location = new System.Drawing.Point(476, 39);
            this.eVisitante.Name = "eVisitante";
            this.eVisitante.Size = new System.Drawing.Size(162, 24);
            this.eVisitante.TabIndex = 9;
            this.eVisitante.Text = "Equipo Visitante";
            // 
            // eLocal
            // 
            this.eLocal.AutoSize = true;
            this.eLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eLocal.Location = new System.Drawing.Point(32, 39);
            this.eLocal.Name = "eLocal";
            this.eLocal.Size = new System.Drawing.Size(133, 24);
            this.eLocal.TabIndex = 8;
            this.eLocal.Text = "Equipo Local";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Gol);
            this.tabControl1.Controls.Add(this.Tarjeta);
            this.tabControl1.Location = new System.Drawing.Point(35, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(659, 201);
            this.tabControl1.TabIndex = 7;
            // 
            // Gol
            // 
            this.Gol.Controls.Add(this.idGol);
            this.Gol.Controls.Add(this.comboBox7);
            this.Gol.Controls.Add(this.button1);
            this.Gol.Controls.Add(this.textBox3);
            this.Gol.Controls.Add(this.comboBox8);
            this.Gol.Controls.Add(this.cbxJugadorGol);
            this.Gol.Controls.Add(this.label14);
            this.Gol.Controls.Add(this.cmbEquipoGol);
            this.Gol.Controls.Add(this.label13);
            this.Gol.Controls.Add(this.label12);
            this.Gol.Controls.Add(this.label11);
            this.Gol.Controls.Add(this.label10);
            this.Gol.Controls.Add(this.label9);
            this.Gol.Location = new System.Drawing.Point(4, 22);
            this.Gol.Name = "Gol";
            this.Gol.Padding = new System.Windows.Forms.Padding(3);
            this.Gol.Size = new System.Drawing.Size(651, 175);
            this.Gol.TabIndex = 0;
            this.Gol.Text = "Gol";
            this.Gol.UseVisualStyleBackColor = true;
            // 
            // idGol
            // 
            this.idGol.AutoSize = true;
            this.idGol.Location = new System.Drawing.Point(60, 15);
            this.idGol.Name = "idGol";
            this.idGol.Size = new System.Drawing.Size(37, 13);
            this.idGol.TabIndex = 22;
            this.idGol.Text = "ID Gol";
            this.idGol.Visible = false;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
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
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "90+"});
            this.comboBox7.Location = new System.Drawing.Point(164, 94);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(36, 21);
            this.comboBox7.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(360, 94);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 20);
            this.textBox3.TabIndex = 13;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "A favor",
            "Autogol",
            "Penal"});
            this.comboBox8.Location = new System.Drawing.Point(226, 93);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(102, 21);
            this.comboBox8.TabIndex = 12;
            // 
            // cbxJugadorGol
            // 
            this.cbxJugadorGol.FormattingEnabled = true;
            this.cbxJugadorGol.Location = new System.Drawing.Point(14, 92);
            this.cbxJugadorGol.Name = "cbxJugadorGol";
            this.cbxJugadorGol.Size = new System.Drawing.Size(121, 21);
            this.cbxJugadorGol.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Equipo:";
            // 
            // cmbEquipoGol
            // 
            this.cmbEquipoGol.FormattingEnabled = true;
            this.cmbEquipoGol.Location = new System.Drawing.Point(12, 31);
            this.cmbEquipoGol.Name = "cmbEquipoGol";
            this.cmbEquipoGol.Size = new System.Drawing.Size(216, 21);
            this.cmbEquipoGol.TabIndex = 8;
            this.cmbEquipoGol.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoGol_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Jugador";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Portero";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Descripcion:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Tipo de Gol:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Minuto";
            // 
            // Tarjeta
            // 
            this.Tarjeta.Controls.Add(this.idTarjeta);
            this.Tarjeta.Controls.Add(this.button2);
            this.Tarjeta.Controls.Add(this.textBox4);
            this.Tarjeta.Controls.Add(this.comboBox10);
            this.Tarjeta.Controls.Add(this.comboBox11);
            this.Tarjeta.Controls.Add(this.cbxJugadorTarjeta);
            this.Tarjeta.Controls.Add(this.label16);
            this.Tarjeta.Controls.Add(this.label17);
            this.Tarjeta.Controls.Add(this.label18);
            this.Tarjeta.Controls.Add(this.label19);
            this.Tarjeta.Controls.Add(this.label15);
            this.Tarjeta.Controls.Add(this.cmbEquipoTarjeta);
            this.Tarjeta.Location = new System.Drawing.Point(4, 22);
            this.Tarjeta.Name = "Tarjeta";
            this.Tarjeta.Padding = new System.Windows.Forms.Padding(3);
            this.Tarjeta.Size = new System.Drawing.Size(651, 175);
            this.Tarjeta.TabIndex = 1;
            this.Tarjeta.Text = "Tarjeta";
            this.Tarjeta.UseVisualStyleBackColor = true;
            // 
            // idTarjeta
            // 
            this.idTarjeta.AutoSize = true;
            this.idTarjeta.Location = new System.Drawing.Point(60, 14);
            this.idTarjeta.Name = "idTarjeta";
            this.idTarjeta.Size = new System.Drawing.Size(54, 13);
            this.idTarjeta.TabIndex = 24;
            this.idTarjeta.Text = "ID Tarjeta";
            this.idTarjeta.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(368, 91);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(160, 20);
            this.textBox4.TabIndex = 22;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "Amarilla ",
            "Roja"});
            this.comboBox10.Location = new System.Drawing.Point(234, 90);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(102, 21);
            this.comboBox10.TabIndex = 21;
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
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
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "90+"});
            this.comboBox11.Location = new System.Drawing.Point(172, 90);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(36, 21);
            this.comboBox11.TabIndex = 20;
            // 
            // cbxJugadorTarjeta
            // 
            this.cbxJugadorTarjeta.FormattingEnabled = true;
            this.cbxJugadorTarjeta.Location = new System.Drawing.Point(22, 89);
            this.cbxJugadorTarjeta.Name = "cbxJugadorTarjeta";
            this.cbxJugadorTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cbxJugadorTarjeta.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(19, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Jugador";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(365, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Descripcion:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(231, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "Tarjeta:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(169, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 15;
            this.label19.Text = "Minuto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Equipo:";
            // 
            // cmbEquipoTarjeta
            // 
            this.cmbEquipoTarjeta.FormattingEnabled = true;
            this.cmbEquipoTarjeta.Location = new System.Drawing.Point(20, 30);
            this.cmbEquipoTarjeta.Name = "cmbEquipoTarjeta";
            this.cmbEquipoTarjeta.Size = new System.Drawing.Size(216, 21);
            this.cmbEquipoTarjeta.TabIndex = 10;
            this.cmbEquipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.cmbEquipoTarjeta_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(362, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(32, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Marcador";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Equipo Visitante:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Equipo Local:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(784, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 397);
            this.panel3.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(146, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 277);
            this.listBox1.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(17, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Resumen Partido:";
            // 
            // campeonatoDataSet
            // 
            this.campeonatoDataSet.DataSetName = "campeonatoDataSet";
            this.campeonatoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // macategoriaBindingSource
            // 
            this.macategoriaBindingSource.DataMember = "macategoria";
            this.macategoriaBindingSource.DataSource = this.campeonatoDataSet;
            // 
            // macategoriaTableAdapter
            // 
            this.macategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // frmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 433);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPartido";
            this.Text = "frmPartido";
            this.Load += new System.EventHandler(this.frmPartido_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Gol.ResumeLayout(false);
            this.Gol.PerformLayout();
            this.Tarjeta.ResumeLayout(false);
            this.Tarjeta.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.campeonatoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.macategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEstadoPartido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Gol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox cbxJugadorGol;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbEquipoGol;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage Tarjeta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox cbxJugadorTarjeta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbEquipoTarjeta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label20;
        private campeonatoDataSet campeonatoDataSet;
        private System.Windows.Forms.BindingSource macategoriaBindingSource;
        private campeonatoDataSetTableAdapters.macategoriaTableAdapter macategoriaTableAdapter;
        private System.Windows.Forms.Label eVisitante;
        private System.Windows.Forms.Label eLocal;
        private System.Windows.Forms.Label idVisitante;
        private System.Windows.Forms.Label idLocal;
        private System.Windows.Forms.Label idGol;
        private System.Windows.Forms.Label idTarjeta;
    }
}