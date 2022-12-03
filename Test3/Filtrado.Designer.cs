namespace Test3
{
    partial class Filtrado
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
            this.txtidconsulta = new System.Windows.Forms.TextBox();
            this.btnhordoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtidconsulta
            // 
            this.txtidconsulta.Location = new System.Drawing.Point(288, 95);
            this.txtidconsulta.Name = "txtidconsulta";
            this.txtidconsulta.Size = new System.Drawing.Size(198, 23);
            this.txtidconsulta.TabIndex = 0;
            // 
            // btnhordoc
            // 
            this.btnhordoc.Location = new System.Drawing.Point(321, 147);
            this.btnhordoc.Name = "btnhordoc";
            this.btnhordoc.Size = new System.Drawing.Size(127, 41);
            this.btnhordoc.TabIndex = 1;
            this.btnhordoc.Text = "Mostrar Horario Docente";
            this.btnhordoc.UseVisualStyleBackColor = true;
            this.btnhordoc.Click += new System.EventHandler(this.btnhordoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILTRACION DE HORARIO POR MEDIO DE ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Filtrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhordoc);
            this.Controls.Add(this.txtidconsulta);
            this.Name = "Filtrado";
            this.Text = "Filtrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtidconsulta;
        private Button btnhordoc;
        private Label label1;
    }
}