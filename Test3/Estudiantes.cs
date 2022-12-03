using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Datos;
using System.Windows.Forms;

namespace Test3
{
    public partial class Estudiantes : Form
    {
        private Datos_Estudiante datos = new Datos_Estudiante();
        private Lista_Estudiantes lista_estudiantes;
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void butonsave_Click(object sender, EventArgs e)
        {

            Estudiante est = new Estudiante();
            string linea;
            linea = textBoxId.Text + ";" + textBoxnom.Text + ";" + textBoxTel.Text;
            est.Id = textBoxId.Text;
            est.Nombre = textBoxnom.Text;
            est.Telefono = textBoxTel.Text;


            if (datos.GuardarEstudiante(linea) == true)
            {
                datos.GuardarEstudianteSQL(est);
                MessageBox.Show("Se guardo el estudiante correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar el Estudiante");
            }
        }

        private void btnestudiagg_Click(object sender, EventArgs e)
        {
            GPsaveestudi.Visible = true;
            GPModiestudiantes.Visible = false;
            GPdisposestu.Visible = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnestudidispose_Click(object sender, EventArgs e)
        {
            GPsaveestudi.Visible = false;
            GPModiestudiantes.Visible = false;
            GPdisposestu.Visible = true;
        }

        private void btnestudimodi_Click(object sender, EventArgs e)
        {
            GPsaveestudi.Visible = false;
            GPModiestudiantes.Visible = true;
            GPdisposestu.Visible = false;
        }

        private void btnmodificardoce_Click(object sender, EventArgs e)
        {
            string upd;
            upd = textboxmodidocente.Text;
            datos.UpdateEstudianteSQL(upd, textboxmodidocente.Text, textboxmodinombredoce.Text, textboxmoditeldoce.Text);
           
        }

        private void cargarmodidocentes_Click(object sender, EventArgs e)
        {
            dgvModidocentes.Rows.Clear();

            var ListaSQL = datos.ConsultarEstudianteSQL();


            if (ListaSQL == null)
            {

                return;
            }
            foreach (Estudiante est in ListaSQL)
            {
                dgvModidocentes.Rows.Add(est.Id, est.Nombre, est.Telefono);


            }
        }

        private void dgvModidocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dgvModidocentes.CurrentRow.Index;
            textboxmodidocente.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textboxmodinombredoce.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textboxmoditeldoce.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }

        private void btnberdocentes_Click(object sender, EventArgs e)
        {
            dataGridDocentes.Rows.Clear();
            var listaSQL = datos.ConsultarEstudianteSQL();


            if (listaSQL == null)
            {

                return;
            }
            foreach (Estudiante est in listaSQL)
            {
                dataGridDocentes.Rows.Add(est.Id, est.Nombre, est.Telefono);


            }
        }

        private void btndeletedocente_Click(object sender, EventArgs e)
        {
           
            datos.DisposeEstudianteSQL(textboxmodidocente.Text);
          
            
        }

        private void GPModiestudiantes_Enter(object sender, EventArgs e)
        {

        }
    }
}
