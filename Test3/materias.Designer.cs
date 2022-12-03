namespace Test3
{
    partial class materias
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
            this.submenumaterias = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmodimate = new System.Windows.Forms.Button();
            this.btnaggmat = new System.Windows.Forms.Button();
            this.GPsavemateria = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxnumcredi = new System.Windows.Forms.TextBox();
            this.butonsavemate = new System.Windows.Forms.Button();
            this.textBoxidmate = new System.Windows.Forms.TextBox();
            this.textBoxnamemate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpmodimaterias = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxmodinombre = new System.Windows.Forms.TextBox();
            this.textboxmodicredi = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.textboxmodid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cargarmodimaterias = new System.Windows.Forms.Button();
            this.dgvModimat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPdisposestu = new System.Windows.Forms.GroupBox();
            this.btndeletedocente = new System.Windows.Forms.Button();
            this.textboxeletedoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnberdocentes = new System.Windows.Forms.Button();
            this.dataGridDocentes = new System.Windows.Forms.DataGridView();
            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submenumaterias.SuspendLayout();
            this.GPsavemateria.SuspendLayout();
            this.gpmodimaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModimat)).BeginInit();
            this.GPdisposestu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocentes)).BeginInit();
            this.SuspendLayout();
            // 
            // submenumaterias
            // 
            this.submenumaterias.BackColor = System.Drawing.Color.ForestGreen;
            this.submenumaterias.Controls.Add(this.button1);
            this.submenumaterias.Controls.Add(this.btnmodimate);
            this.submenumaterias.Controls.Add(this.btnaggmat);
            this.submenumaterias.Location = new System.Drawing.Point(12, 12);
            this.submenumaterias.Name = "submenumaterias";
            this.submenumaterias.Size = new System.Drawing.Size(153, 143);
            this.submenumaterias.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 23;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmodimate
            // 
            this.btnmodimate.FlatAppearance.BorderSize = 0;
            this.btnmodimate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnmodimate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodimate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnmodimate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodimate.Location = new System.Drawing.Point(3, 38);
            this.btnmodimate.Name = "btnmodimate";
            this.btnmodimate.Size = new System.Drawing.Size(137, 55);
            this.btnmodimate.TabIndex = 22;
            this.btnmodimate.Text = "Modificar materias";
            this.btnmodimate.UseVisualStyleBackColor = true;
            this.btnmodimate.Click += new System.EventHandler(this.btnmodimate_Click);
            // 
            // btnaggmat
            // 
            this.btnaggmat.FlatAppearance.BorderSize = 0;
            this.btnaggmat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaggmat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaggmat.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaggmat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaggmat.Location = new System.Drawing.Point(3, 3);
            this.btnaggmat.Name = "btnaggmat";
            this.btnaggmat.Size = new System.Drawing.Size(131, 36);
            this.btnaggmat.TabIndex = 20;
            this.btnaggmat.Text = "Agregar materia";
            this.btnaggmat.UseVisualStyleBackColor = true;
            this.btnaggmat.Click += new System.EventHandler(this.btnaggmat_Click);
            // 
            // GPsavemateria
            // 
            this.GPsavemateria.BackColor = System.Drawing.Color.Green;
            this.GPsavemateria.Controls.Add(this.label3);
            this.GPsavemateria.Controls.Add(this.textBoxnumcredi);
            this.GPsavemateria.Controls.Add(this.butonsavemate);
            this.GPsavemateria.Controls.Add(this.textBoxidmate);
            this.GPsavemateria.Controls.Add(this.textBoxnamemate);
            this.GPsavemateria.Controls.Add(this.label2);
            this.GPsavemateria.Controls.Add(this.label1);
            this.GPsavemateria.Location = new System.Drawing.Point(187, 15);
            this.GPsavemateria.Name = "GPsavemateria";
            this.GPsavemateria.Size = new System.Drawing.Size(403, 427);
            this.GPsavemateria.TabIndex = 25;
            this.GPsavemateria.TabStop = false;
            this.GPsavemateria.Text = "groupBox1";
            this.GPsavemateria.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese numero de creditos";
            // 
            // textBoxnumcredi
            // 
            this.textBoxnumcredi.Location = new System.Drawing.Point(156, 232);
            this.textBoxnumcredi.Name = "textBoxnumcredi";
            this.textBoxnumcredi.Size = new System.Drawing.Size(100, 23);
            this.textBoxnumcredi.TabIndex = 7;
            // 
            // butonsavemate
            // 
            this.butonsavemate.Location = new System.Drawing.Point(170, 291);
            this.butonsavemate.Name = "butonsavemate";
            this.butonsavemate.Size = new System.Drawing.Size(75, 23);
            this.butonsavemate.TabIndex = 6;
            this.butonsavemate.Text = "Guardar";
            this.butonsavemate.UseVisualStyleBackColor = true;
            this.butonsavemate.Click += new System.EventHandler(this.butonsavemate_Click);
            // 
            // textBoxidmate
            // 
            this.textBoxidmate.Location = new System.Drawing.Point(156, 162);
            this.textBoxidmate.Name = "textBoxidmate";
            this.textBoxidmate.Size = new System.Drawing.Size(100, 23);
            this.textBoxidmate.TabIndex = 4;
            // 
            // textBoxnamemate
            // 
            this.textBoxnamemate.Location = new System.Drawing.Point(156, 95);
            this.textBoxnamemate.Name = "textBoxnamemate";
            this.textBoxnamemate.Size = new System.Drawing.Size(100, 23);
            this.textBoxnamemate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Id de la materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre de la materia";
            // 
            // gpmodimaterias
            // 
            this.gpmodimaterias.Controls.Add(this.label9);
            this.gpmodimaterias.Controls.Add(this.label8);
            this.gpmodimaterias.Controls.Add(this.textboxmodinombre);
            this.gpmodimaterias.Controls.Add(this.textboxmodicredi);
            this.gpmodimaterias.Controls.Add(this.btnmodificar);
            this.gpmodimaterias.Controls.Add(this.textboxmodid);
            this.gpmodimaterias.Controls.Add(this.label7);
            this.gpmodimaterias.Controls.Add(this.cargarmodimaterias);
            this.gpmodimaterias.Controls.Add(this.dgvModimat);
            this.gpmodimaterias.Location = new System.Drawing.Point(171, 37);
            this.gpmodimaterias.Name = "gpmodimaterias";
            this.gpmodimaterias.Size = new System.Drawing.Size(488, 375);
            this.gpmodimaterias.TabIndex = 28;
            this.gpmodimaterias.TabStop = false;
            this.gpmodimaterias.Text = "gpmodimaterias";
            this.gpmodimaterias.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ingrese nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ingrese creditos";
            // 
            // textboxmodinombre
            // 
            this.textboxmodinombre.Location = new System.Drawing.Point(25, 284);
            this.textboxmodinombre.Name = "textboxmodinombre";
            this.textboxmodinombre.Size = new System.Drawing.Size(123, 23);
            this.textboxmodinombre.TabIndex = 28;
            // 
            // textboxmodicredi
            // 
            this.textboxmodicredi.Location = new System.Drawing.Point(168, 284);
            this.textboxmodicredi.Name = "textboxmodicredi";
            this.textboxmodicredi.Size = new System.Drawing.Size(123, 23);
            this.textboxmodicredi.TabIndex = 27;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(316, 272);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(92, 23);
            this.btnmodificar.TabIndex = 26;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // textboxmodid
            // 
            this.textboxmodid.Location = new System.Drawing.Point(27, 242);
            this.textboxmodid.Name = "textboxmodid";
            this.textboxmodid.Size = new System.Drawing.Size(123, 23);
            this.textboxmodid.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ingrese ID ";
            // 
            // cargarmodimaterias
            // 
            this.cargarmodimaterias.Location = new System.Drawing.Point(191, 199);
            this.cargarmodimaterias.Name = "cargarmodimaterias";
            this.cargarmodimaterias.Size = new System.Drawing.Size(75, 23);
            this.cargarmodimaterias.TabIndex = 23;
            this.cargarmodimaterias.Text = "Cargar";
            this.cargarmodimaterias.UseVisualStyleBackColor = true;
            this.cargarmodimaterias.Click += new System.EventHandler(this.cargarmodimaterias_Click);
            // 
            // dgvModimat
            // 
            this.dgvModimat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModimat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvModimat.Location = new System.Drawing.Point(65, 13);
            this.dgvModimat.Name = "dgvModimat";
            this.dgvModimat.RowTemplate.Height = 25;
            this.dgvModimat.Size = new System.Drawing.Size(343, 173);
            this.dgvModimat.TabIndex = 22;
            this.dgvModimat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModimat_CellClick);
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
            this.dataGridViewTextBoxColumn3.HeaderText = "Creditos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // GPdisposestu
            // 
            this.GPdisposestu.Controls.Add(this.btndeletedocente);
            this.GPdisposestu.Controls.Add(this.textboxeletedoc);
            this.GPdisposestu.Controls.Add(this.label6);
            this.GPdisposestu.Controls.Add(this.btnberdocentes);
            this.GPdisposestu.Controls.Add(this.dataGridDocentes);
            this.GPdisposestu.Location = new System.Drawing.Point(35, 340);
            this.GPdisposestu.Name = "GPdisposestu";
            this.GPdisposestu.Size = new System.Drawing.Size(482, 533);
            this.GPdisposestu.TabIndex = 29;
            this.GPdisposestu.TabStop = false;
            this.GPdisposestu.Visible = false;
            // 
            // btndeletedocente
            // 
            this.btndeletedocente.Location = new System.Drawing.Point(189, 285);
            this.btndeletedocente.Name = "btndeletedocente";
            this.btndeletedocente.Size = new System.Drawing.Size(92, 23);
            this.btndeletedocente.TabIndex = 26;
            this.btndeletedocente.Text = "Eliminar";
            this.btndeletedocente.UseVisualStyleBackColor = true;
            // 
            // textboxeletedoc
            // 
            this.textboxeletedoc.Location = new System.Drawing.Point(167, 256);
            this.textboxeletedoc.Name = "textboxeletedoc";
            this.textboxeletedoc.Size = new System.Drawing.Size(123, 23);
            this.textboxeletedoc.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ingrese ID a eliminar";
            // 
            // btnberdocentes
            // 
            this.btnberdocentes.Location = new System.Drawing.Point(191, 199);
            this.btnberdocentes.Name = "btnberdocentes";
            this.btnberdocentes.Size = new System.Drawing.Size(75, 23);
            this.btnberdocentes.TabIndex = 23;
            this.btnberdocentes.Text = "Cargar";
            this.btnberdocentes.UseVisualStyleBackColor = true;
            this.btnberdocentes.Click += new System.EventHandler(this.btnberdocentes_Click);
            // 
            // dataGridDocentes
            // 
            this.dataGridDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_id,
            this.colnom,
            this.colTel});
            this.dataGridDocentes.Location = new System.Drawing.Point(65, 13);
            this.dataGridDocentes.Name = "dataGridDocentes";
            this.dataGridDocentes.RowTemplate.Height = 25;
            this.dataGridDocentes.Size = new System.Drawing.Size(343, 173);
            this.dataGridDocentes.TabIndex = 22;
            this.dataGridDocentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDocentes_CellClick);
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
            this.colTel.HeaderText = "Creditos";
            this.colTel.Name = "colTel";
            // 
            // materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 545);
            this.Controls.Add(this.GPdisposestu);
            this.Controls.Add(this.gpmodimaterias);
            this.Controls.Add(this.submenumaterias);
            this.Controls.Add(this.GPsavemateria);
            this.Name = "materias";
            this.Text = "materias";
            this.submenumaterias.ResumeLayout(false);
            this.GPsavemateria.ResumeLayout(false);
            this.GPsavemateria.PerformLayout();
            this.gpmodimaterias.ResumeLayout(false);
            this.gpmodimaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModimat)).EndInit();
            this.GPdisposestu.ResumeLayout(false);
            this.GPdisposestu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDocentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel submenumaterias;
        private Button btnmodimate;
        private Button btnaggmat;
        private GroupBox GPsavemateria;
        private Label label3;
        private TextBox textBoxnumcredi;
        private Button butonsavemate;
        private TextBox textBoxidmate;
        private TextBox textBoxnamemate;
        private Label label2;
        private Label label1;
        private GroupBox gpmodimaterias;
        private Label label9;
        private Label label8;
        private TextBox textboxmodinombre;
        private TextBox textboxmodicredi;
        private Button btnmodificar;
        private TextBox textboxmodid;
        private Label label7;
        private Button cargarmodimaterias;
        private DataGridView dgvModimat;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupBox GPdisposestu;
        private Button btndeletedocente;
        private TextBox textboxeletedoc;
        private Label label6;
        private Button btnberdocentes;
        private DataGridView dataGridDocentes;
        private DataGridViewTextBoxColumn col_id;
        private DataGridViewTextBoxColumn colnom;
        private DataGridViewTextBoxColumn colTel;
        private Button button1;
    }
}