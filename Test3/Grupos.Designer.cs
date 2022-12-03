namespace Test3
{
    partial class Grupos
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
            this.comboBoxdiasem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxhora = new System.Windows.Forms.ComboBox();
            this.textBoxidmatgp = new System.Windows.Forms.TextBox();
            this.textBoxidsalongp = new System.Windows.Forms.TextBox();
            this.textBoxnumgp = new System.Windows.Forms.TextBox();
            this.textBoxiddocgp = new System.Windows.Forms.TextBox();
            this.textBoxidmateriagp = new System.Windows.Forms.TextBox();
            this.btncreargp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxgp = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btndetails = new System.Windows.Forms.Button();
            this.dataGridGrupos = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.btnestudimodi = new System.Windows.Forms.Button();
            this.btnestudidispose = new System.Windows.Forms.Button();
            this.btnestudiagg = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvlstestudi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnsave = new System.Windows.Forms.Button();
            this.textBoxidalum = new System.Windows.Forms.TextBox();
            this.textBoxidgp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlstestudi)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxdiasem
            // 
            this.comboBoxdiasem.FormattingEnabled = true;
            this.comboBoxdiasem.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.comboBoxdiasem.Location = new System.Drawing.Point(295, 110);
            this.comboBoxdiasem.Name = "comboBoxdiasem";
            this.comboBoxdiasem.Size = new System.Drawing.Size(121, 23);
            this.comboBoxdiasem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ingrese Id del salon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "ingrese numero del grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese Id del docente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "seleccione dia de la semana ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "seleccione hora";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ingrese Id de materia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "asigne id al grupo";
            // 
            // comboBoxhora
            // 
            this.comboBoxhora.FormattingEnabled = true;
            this.comboBoxhora.Items.AddRange(new object[] {
            "08:00-10:00",
            "10:00-12:00",
            "12:00-14:00",
            "14:00-16:00",
            "16:00-18:00"});
            this.comboBoxhora.Location = new System.Drawing.Point(70, 232);
            this.comboBoxhora.Name = "comboBoxhora";
            this.comboBoxhora.Size = new System.Drawing.Size(121, 23);
            this.comboBoxhora.TabIndex = 8;
            // 
            // textBoxidmatgp
            // 
            this.textBoxidmatgp.Location = new System.Drawing.Point(194, 398);
            this.textBoxidmatgp.Name = "textBoxidmatgp";
            this.textBoxidmatgp.Size = new System.Drawing.Size(100, 23);
            this.textBoxidmatgp.TabIndex = 9;
            // 
            // textBoxidsalongp
            // 
            this.textBoxidsalongp.Location = new System.Drawing.Point(295, 336);
            this.textBoxidsalongp.Name = "textBoxidsalongp";
            this.textBoxidsalongp.Size = new System.Drawing.Size(100, 23);
            this.textBoxidsalongp.TabIndex = 10;
            // 
            // textBoxnumgp
            // 
            this.textBoxnumgp.Location = new System.Drawing.Point(295, 232);
            this.textBoxnumgp.Name = "textBoxnumgp";
            this.textBoxnumgp.Size = new System.Drawing.Size(100, 23);
            this.textBoxnumgp.TabIndex = 11;
            // 
            // textBoxiddocgp
            // 
            this.textBoxiddocgp.Location = new System.Drawing.Point(79, 110);
            this.textBoxiddocgp.Name = "textBoxiddocgp";
            this.textBoxiddocgp.Size = new System.Drawing.Size(100, 23);
            this.textBoxiddocgp.TabIndex = 12;
            // 
            // textBoxidmateriagp
            // 
            this.textBoxidmateriagp.Location = new System.Drawing.Point(79, 336);
            this.textBoxidmateriagp.Name = "textBoxidmateriagp";
            this.textBoxidmateriagp.Size = new System.Drawing.Size(100, 23);
            this.textBoxidmateriagp.TabIndex = 13;
            // 
            // btncreargp
            // 
            this.btncreargp.Location = new System.Drawing.Point(174, 463);
            this.btncreargp.Name = "btncreargp";
            this.btncreargp.Size = new System.Drawing.Size(143, 23);
            this.btncreargp.TabIndex = 14;
            this.btncreargp.Text = "crear grupo";
            this.btncreargp.UseVisualStyleBackColor = true;
            this.btncreargp.Click += new System.EventHandler(this.btncreargp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxiddocgp);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btncreargp);
            this.panel1.Controls.Add(this.comboBoxdiasem);
            this.panel1.Controls.Add(this.textBoxidmateriagp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxnumgp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxidsalongp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxidmatgp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBoxhora);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(258, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 574);
            this.panel1.TabIndex = 15;
            this.panel1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxgp);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btndetails);
            this.panel3.Controls.Add(this.dataGridGrupos);
            this.panel3.Location = new System.Drawing.Point(223, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(593, 418);
            this.panel3.TabIndex = 26;
            this.panel3.Visible = false;
            // 
            // textBoxgp
            // 
            this.textBoxgp.Location = new System.Drawing.Point(254, 352);
            this.textBoxgp.Name = "textBoxgp";
            this.textBoxgp.Size = new System.Drawing.Size(111, 23);
            this.textBoxgp.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cargar grupos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndetails
            // 
            this.btndetails.Location = new System.Drawing.Point(271, 385);
            this.btndetails.Name = "btndetails";
            this.btndetails.Size = new System.Drawing.Size(75, 23);
            this.btndetails.TabIndex = 24;
            this.btndetails.Text = "Ver detalles";
            this.btndetails.UseVisualStyleBackColor = true;
            this.btndetails.Click += new System.EventHandler(this.btndetails_Click);
            // 
            // dataGridGrupos
            // 
            this.dataGridGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.colnom,
            this.colTel,
            this.Dia});
            this.dataGridGrupos.Location = new System.Drawing.Point(81, 44);
            this.dataGridGrupos.Name = "dataGridGrupos";
            this.dataGridGrupos.RowTemplate.Height = 25;
            this.dataGridGrupos.Size = new System.Drawing.Size(441, 302);
            this.dataGridGrupos.TabIndex = 23;
            this.dataGridGrupos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGrupos_CellClick);
            // 
            // col_id
            // 
            this.col_id.HeaderText = "ID";
            this.col_id.Name = "col_id";
            // 
            // colnom
            // 
            this.colnom.HeaderText = "Nombre";
            this.colnom.Name = "colnom";
            // 
            // colTel
            // 
            this.colTel.HeaderText = "Horario";
            this.colTel.Name = "colTel";
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Dia";
            this.Dia.Name = "Dia";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.btnback);
            this.panel2.Controls.Add(this.btnestudimodi);
            this.panel2.Controls.Add(this.btnestudidispose);
            this.panel2.Controls.Add(this.btnestudiagg);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 180);
            this.panel2.TabIndex = 25;
            // 
            // btnback
            // 
            this.btnback.FlatAppearance.BorderSize = 0;
            this.btnback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnback.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnback.Location = new System.Drawing.Point(18, 127);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(158, 42);
            this.btnback.TabIndex = 23;
            this.btnback.Text = "Volver";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnestudimodi
            // 
            this.btnestudimodi.FlatAppearance.BorderSize = 0;
            this.btnestudimodi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnestudimodi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudimodi.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnestudimodi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnestudimodi.Location = new System.Drawing.Point(18, 85);
            this.btnestudimodi.Name = "btnestudimodi";
            this.btnestudimodi.Size = new System.Drawing.Size(158, 42);
            this.btnestudimodi.TabIndex = 22;
            this.btnestudimodi.Text = "Ver Grupos";
            this.btnestudimodi.UseVisualStyleBackColor = true;
            this.btnestudimodi.Click += new System.EventHandler(this.btnestudimodi_Click);
            // 
            // btnestudidispose
            // 
            this.btnestudidispose.FlatAppearance.BorderSize = 0;
            this.btnestudidispose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnestudidispose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudidispose.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnestudidispose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnestudidispose.Location = new System.Drawing.Point(27, 52);
            this.btnestudidispose.Name = "btnestudidispose";
            this.btnestudidispose.Size = new System.Drawing.Size(149, 37);
            this.btnestudidispose.TabIndex = 21;
            this.btnestudidispose.Text = "Agregar Estudiante";
            this.btnestudidispose.UseVisualStyleBackColor = true;
            this.btnestudidispose.Click += new System.EventHandler(this.btnestudidispose_Click);
            // 
            // btnestudiagg
            // 
            this.btnestudiagg.FlatAppearance.BorderSize = 0;
            this.btnestudiagg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnestudiagg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnestudiagg.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnestudiagg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnestudiagg.Location = new System.Drawing.Point(18, 3);
            this.btnestudiagg.Name = "btnestudiagg";
            this.btnestudiagg.Size = new System.Drawing.Size(163, 43);
            this.btnestudiagg.TabIndex = 20;
            this.btnestudiagg.Text = "Agregar grupo";
            this.btnestudiagg.UseVisualStyleBackColor = true;
            this.btnestudiagg.Click += new System.EventHandler(this.btnestudiagg_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.dgvlstestudi);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(238, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(514, 503);
            this.panel4.TabIndex = 25;
            this.panel4.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvlstestudi
            // 
            this.dgvlstestudi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlstestudi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvlstestudi.Location = new System.Drawing.Point(82, 270);
            this.dgvlstestudi.Name = "dgvlstestudi";
            this.dgvlstestudi.RowTemplate.Height = 25;
            this.dgvlstestudi.Size = new System.Drawing.Size(344, 168);
            this.dgvlstestudi.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(224, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 15);
            this.label17.TabIndex = 9;
            this.label17.Text = "Estudiantes :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(67, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 15);
            this.label16.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(402, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 15);
            this.label15.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Horario :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 15);
            this.label13.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 15);
            this.label11.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Salon :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Materia :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Docente :";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnsave);
            this.panel5.Controls.Add(this.textBoxidalum);
            this.panel5.Controls.Add(this.textBoxidgp);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Location = new System.Drawing.Point(220, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 328);
            this.panel5.TabIndex = 26;
            this.panel5.Visible = false;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(244, 215);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 28;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textBoxidalum
            // 
            this.textBoxidalum.Location = new System.Drawing.Point(101, 137);
            this.textBoxidalum.Name = "textBoxidalum";
            this.textBoxidalum.Size = new System.Drawing.Size(100, 23);
            this.textBoxidalum.TabIndex = 3;
            this.textBoxidalum.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxidgp
            // 
            this.textBoxidgp.Location = new System.Drawing.Point(377, 137);
            this.textBoxidgp.Name = "textBoxidgp";
            this.textBoxidgp.Size = new System.Drawing.Size(100, 23);
            this.textBoxidgp.TabIndex = 2;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(309, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(202, 15);
            this.label19.TabIndex = 1;
            this.label19.Text = "Id de grupo al que asignar estudiante";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(69, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Id de alumno a registrar en grupo";
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 582);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrupos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlstestudi)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxdiasem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxhora;
        private TextBox textBoxidmatgp;
        private TextBox textBoxidsalongp;
        private TextBox textBoxnumgp;
        private TextBox textBoxiddocgp;
        private TextBox textBoxidmateriagp;
        private Button btncreargp;
        private Panel panel1;
        private Panel panel2;
        private Button btnback;
        private Button btnestudimodi;
        private Button btnestudidispose;
        private Button btnestudiagg;
        private Panel panel3;
        private Button btndetails;
        private DataGridView dataGridGrupos;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn colnom;
        private DataGridViewTextBoxColumn colTel;
        private DataGridViewTextBoxColumn Dia;
        private Panel panel4;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button1;
        private DataGridView dgvlstestudi;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Panel panel5;
        private TextBox textBoxidalum;
        private TextBox textBoxidgp;
        private Label label19;
        private Label label18;
        private Button btnsave;
        private Button button2;
        private TextBox textBoxgp;
    }
}