namespace Test3
{
    partial class FormSalones
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
            this.GPsavebloque = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxidsalon = new System.Windows.Forms.TextBox();
            this.butonsave = new System.Windows.Forms.Button();
            this.textBoxnumsal = new System.Windows.Forms.TextBox();
            this.textBoxbloque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpmodisalones = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxmodinum = new System.Windows.Forms.TextBox();
            this.textboxmodibloq = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.textboxmodid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cargarmodisal = new System.Windows.Forms.Button();
            this.dgvModisal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submenusalones = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnaggsal = new System.Windows.Forms.Button();
            this.GPsavebloque.SuspendLayout();
            this.gpmodisalones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModisal)).BeginInit();
            this.submenusalones.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPsavebloque
            // 
            this.GPsavebloque.BackColor = System.Drawing.Color.Green;
            this.GPsavebloque.Controls.Add(this.label3);
            this.GPsavebloque.Controls.Add(this.textBoxidsalon);
            this.GPsavebloque.Controls.Add(this.butonsave);
            this.GPsavebloque.Controls.Add(this.textBoxnumsal);
            this.GPsavebloque.Controls.Add(this.textBoxbloque);
            this.GPsavebloque.Controls.Add(this.label2);
            this.GPsavebloque.Controls.Add(this.label1);
            this.GPsavebloque.Location = new System.Drawing.Point(171, 12);
            this.GPsavebloque.Name = "GPsavebloque";
            this.GPsavebloque.Size = new System.Drawing.Size(450, 555);
            this.GPsavebloque.TabIndex = 21;
            this.GPsavebloque.TabStop = false;
            this.GPsavebloque.Text = "groupBox1";
            this.GPsavebloque.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese id del salon";
            // 
            // textBoxidsalon
            // 
            this.textBoxidsalon.Location = new System.Drawing.Point(214, 292);
            this.textBoxidsalon.Name = "textBoxidsalon";
            this.textBoxidsalon.Size = new System.Drawing.Size(100, 23);
            this.textBoxidsalon.TabIndex = 7;
            // 
            // butonsave
            // 
            this.butonsave.Location = new System.Drawing.Point(224, 321);
            this.butonsave.Name = "butonsave";
            this.butonsave.Size = new System.Drawing.Size(75, 23);
            this.butonsave.TabIndex = 6;
            this.butonsave.Text = "Guardar";
            this.butonsave.UseVisualStyleBackColor = true;
            this.butonsave.Click += new System.EventHandler(this.butonsave_Click);
            // 
            // textBoxnumsal
            // 
            this.textBoxnumsal.Location = new System.Drawing.Point(214, 239);
            this.textBoxnumsal.Name = "textBoxnumsal";
            this.textBoxnumsal.Size = new System.Drawing.Size(100, 23);
            this.textBoxnumsal.TabIndex = 4;
            // 
            // textBoxbloque
            // 
            this.textBoxbloque.Location = new System.Drawing.Point(224, 172);
            this.textBoxbloque.Name = "textBoxbloque";
            this.textBoxbloque.Size = new System.Drawing.Size(100, 23);
            this.textBoxbloque.TabIndex = 3;
            this.textBoxbloque.TextChanged += new System.EventHandler(this.textBoxbloque_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese numero del salon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese bloque";
            // 
            // gpmodisalones
            // 
            this.gpmodisalones.Controls.Add(this.label9);
            this.gpmodisalones.Controls.Add(this.label8);
            this.gpmodisalones.Controls.Add(this.textboxmodinum);
            this.gpmodisalones.Controls.Add(this.textboxmodibloq);
            this.gpmodisalones.Controls.Add(this.btnmodificar);
            this.gpmodisalones.Controls.Add(this.textboxmodid);
            this.gpmodisalones.Controls.Add(this.label7);
            this.gpmodisalones.Controls.Add(this.cargarmodisal);
            this.gpmodisalones.Controls.Add(this.dgvModisal);
            this.gpmodisalones.Location = new System.Drawing.Point(166, 107);
            this.gpmodisalones.Name = "gpmodisalones";
            this.gpmodisalones.Size = new System.Drawing.Size(455, 355);
            this.gpmodisalones.TabIndex = 29;
            this.gpmodisalones.TabStop = false;
            this.gpmodisalones.Text = "gpmodisalones";
            this.gpmodisalones.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(51, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Ingrese # de salon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ingrese Bloque";
            // 
            // textboxmodinum
            // 
            this.textboxmodinum.Location = new System.Drawing.Point(25, 284);
            this.textboxmodinum.Name = "textboxmodinum";
            this.textboxmodinum.Size = new System.Drawing.Size(123, 23);
            this.textboxmodinum.TabIndex = 28;
            // 
            // textboxmodibloq
            // 
            this.textboxmodibloq.Location = new System.Drawing.Point(168, 284);
            this.textboxmodibloq.Name = "textboxmodibloq";
            this.textboxmodibloq.Size = new System.Drawing.Size(123, 23);
            this.textboxmodibloq.TabIndex = 27;
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
            // cargarmodisal
            // 
            this.cargarmodisal.Location = new System.Drawing.Point(191, 199);
            this.cargarmodisal.Name = "cargarmodisal";
            this.cargarmodisal.Size = new System.Drawing.Size(75, 23);
            this.cargarmodisal.TabIndex = 23;
            this.cargarmodisal.Text = "Cargar";
            this.cargarmodisal.UseVisualStyleBackColor = true;
            this.cargarmodisal.Click += new System.EventHandler(this.cargarmodisal_Click);
            // 
            // dgvModisal
            // 
            this.dgvModisal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModisal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvModisal.Location = new System.Drawing.Point(65, 13);
            this.dgvModisal.Name = "dgvModisal";
            this.dgvModisal.RowTemplate.Height = 25;
            this.dgvModisal.Size = new System.Drawing.Size(343, 173);
            this.dgvModisal.TabIndex = 22;
            this.dgvModisal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModisal_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "# Salon";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Bloque";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // submenusalones
            // 
            this.submenusalones.BackColor = System.Drawing.Color.ForestGreen;
            this.submenusalones.Controls.Add(this.button3);
            this.submenusalones.Controls.Add(this.button1);
            this.submenusalones.Controls.Add(this.btnaggsal);
            this.submenusalones.Location = new System.Drawing.Point(12, 33);
            this.submenusalones.Name = "submenusalones";
            this.submenusalones.Size = new System.Drawing.Size(153, 148);
            this.submenusalones.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(11, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 55);
            this.button3.TabIndex = 23;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(11, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 55);
            this.button1.TabIndex = 22;
            this.button1.Text = "Modificar salones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnaggsal
            // 
            this.btnaggsal.FlatAppearance.BorderSize = 0;
            this.btnaggsal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnaggsal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaggsal.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnaggsal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaggsal.Location = new System.Drawing.Point(3, 3);
            this.btnaggsal.Name = "btnaggsal";
            this.btnaggsal.Size = new System.Drawing.Size(131, 36);
            this.btnaggsal.TabIndex = 20;
            this.btnaggsal.Text = "Agregar salon";
            this.btnaggsal.UseVisualStyleBackColor = true;
            this.btnaggsal.Click += new System.EventHandler(this.btnaggsal_Click);
            // 
            // FormSalones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 579);
            this.Controls.Add(this.gpmodisalones);
            this.Controls.Add(this.submenusalones);
            this.Controls.Add(this.GPsavebloque);
            this.Name = "FormSalones";
            this.Text = "Salones";
            this.GPsavebloque.ResumeLayout(false);
            this.GPsavebloque.PerformLayout();
            this.gpmodisalones.ResumeLayout(false);
            this.gpmodisalones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModisal)).EndInit();
            this.submenusalones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox GPsavebloque;
        private Button butonsave;
        private TextBox textBoxnumsal;
        private TextBox textBoxbloque;
        private Label label2;
        private Label label1;
        private Panel submenusalones;
        private Button button1;
        private Button btnaggsal;
        private Label label3;
        private TextBox textBoxidsalon;
        private GroupBox gpmodisalones;
        private Label label9;
        private Label label8;
        private TextBox textboxmodinum;
        private TextBox textboxmodibloq;
        private Button btnmodificar;
        private TextBox textboxmodid;
        private Label label7;
        private Button cargarmodisal;
        private DataGridView dgvModisal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button3;
    }
}