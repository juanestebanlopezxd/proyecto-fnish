using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;

namespace Test3
{
    public partial class materias : Form
    {



        private Datos_Materias datos = new Datos_Materias();
        private Lista_Materias lista_materias;
        public materias()
        {
            InitializeComponent();
        }

        private void butonsavemate_Click(object sender, EventArgs e)
        {
            Materia mat = new Materia();
            string linea;
            linea = textBoxidmate.Text + ";" + textBoxnamemate.Text + ";" + textBoxnumcredi.Text;
            mat.Id = textBoxidmate.Text;
            mat.Nombre = textBoxnamemate.Text;
            mat.Creditos = textBoxnumcredi.Text;

            if (datos.GuardarMater(linea) == true)
            {
                datos.GuardarMaterSQL(mat);
                MessageBox.Show("Se guardo la materia correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar la materia");
            }
        }

        private void btnaggmat_Click(object sender, EventArgs e)
        {
            GPsavemateria.Visible = true;
            gpmodimaterias.Visible = false;
        }

        private void cargarmodimaterias_Click(object sender, EventArgs e)
        {
            dgvModimat.Rows.Clear();

            lista_materias = datos.leer_materias();
            var listaSQL = datos.ConsultarMateriaSQL();

            if (listaSQL  == null)
            {

                return;
            }
            foreach (Materia materia in listaSQL)
            {
                dgvModimat.Rows.Add(materia.Id, materia.Nombre, materia.Creditos);


            }
        }

        private void btnmodimate_Click(object sender, EventArgs e)
        {

            GPsavemateria.Visible = false;
            gpmodimaterias.Visible = true;
        }

        private void dgvModimat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dgvModimat.CurrentRow.Index;
            textboxmodid.Text = dgvModimat.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textboxmodinombre.Text = dgvModimat.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textboxmodicredi.Text = dgvModimat.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string upd;
            lista_materias = datos.leer_materias();
            Materia materia = new Materia();
            materia.Id = textboxmodid.Text;
            materia.Nombre = textboxmodinombre.Text;
            materia.Creditos = textboxmodicredi.Text;
            upd = textboxmodid.Text;
            datos.UpdateMateriaSQL(upd, textboxmodid.Text, textboxmodinombre.Text, textboxmodicredi.Text);
            lista_materias.actualizar_materia(materia);
            datos.eliminar_archivo_doc();
            string linea;

            foreach (Materia mat in lista_materias.coleccion_materias())
            {
                linea = mat.Id + ";" + mat.Nombre + ";" + mat.Creditos;
                datos.GuardarMater(linea);
            }
        }

        private void btnberdocentes_Click(object sender, EventArgs e)
        {
            dgvModimat.Rows.Clear();

            lista_materias = datos.leer_materias();
            var listaSQL = datos.ConsultarMateriaSQL();

            if (listaSQL == null)
            {

                return;
            }
            foreach (Materia materia in listaSQL)
            {
                dgvModimat.Rows.Add(materia.Id, materia.Nombre, materia.Creditos);


            }
        }

        private void dataGridDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dataGridDocentes.CurrentRow.Index;
            textboxmodid.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textboxmodinombre.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textboxmodicredi.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
