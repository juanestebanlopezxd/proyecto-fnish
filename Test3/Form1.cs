using Datos;
using Entidad;

namespace Test3

{
    public partial class Form1 : Form
    {


        private Datos_Docentes datos = new Datos_Docentes();
        private Lista_Docentes lista_docentes;
        public Form1()
        {
            InitializeComponent();
        }



        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }







        private void cargar_docentes()
        {
            dataGridDocentes.Rows.Clear();
            var listaSQL = datos.ConsultarDocenteSQL();


            if (listaSQL == null)
            {

                return;
            }
            foreach (Docente docente in listaSQL)
            {
                dataGridDocentes.Rows.Add(docente.Id, docente.Nombre, docente.Telefono);


            }

        }
        private void cargar_docentesmodi()
        {
            dgvModidocentes.Rows.Clear();

            lista_docentes = datos.leer_docentes();
            var listaSQL = datos.ConsultarDocenteSQL();
            

            if (listaSQL == null)
            {

                return;
            }
            foreach (Docente docente in listaSQL)
            {
                dgvModidocentes.Rows.Add(docente.Id, docente.Nombre, docente.Telefono);


            }

            //foreach (Docente docente in lista_docentes.coleccion_docentes())
            //{   
            //    dgvModidocentes.Rows.Add(docente.Id, docente.Nombre, docente.Telefono);


            //}

        }
        private void guardar_docente()
        {


            Docente docente = new Docente();
            string linea;
            linea = textBoxIddoc.Text + ";" + textBoxnomdoc.Text + ";" + textBoxTeldoc.Text;
            docente.Id = textBoxIddoc.Text;
            docente.Nombre = textBoxnomdoc.Text;
            docente.Telefono = textBoxTeldoc.Text;

            
            if (datos.GuardarDocente(linea) == true)
            {
                datos.GuardarDocenteSQL(docente);
                MessageBox.Show("Se guardo el docente correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar el docente");
            }


        }



        private void bttondocen_Click(object sender, EventArgs e)
        {

        }

        private void btnaggdocen_Click(object sender, EventArgs e)
        {


        }

        private void butguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmenudocentes_Click(object sender, EventArgs e)
        {
            panelsubmenudoc.Visible = true;
        }

        private void Btnaggdocente_Click(object sender, EventArgs e)
        {
            GPsavedocente.Visible = true;
            panelsubmenudoc.Visible = false;
            GPModidocentes.Visible = false;
            GPverdocentes.Visible = false;
        }

        private void butonsave_Click(object sender, EventArgs e)
        {
            guardar_docente();
        }

        private void BtnVerdocentes_Click(object sender, EventArgs e)
        {
            GPverdocentes.Visible = true;
            panelsubmenudoc.Visible = false;
        }

        private void btnberdocentes_Click(object sender, EventArgs e)
        {
            cargar_docentes();
        }

        private void dataGridDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dataGridDocentes.CurrentRow.Index;
            textBoxIddoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textBoxnomdoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textBoxTeldoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }


        private void actualizar_docente()
        {
            string upd;
            Docente docente = new Docente();
            upd = textboxmodidocente.Text;
            datos.UpdateDocenteSQL(upd, textboxmodidocente.Text, textboxmodinombredoce.Text, textboxmoditeldoce.Text );
            lista_docentes.actualizar_docente(docente);
        }

        private void btnmodificardoce_Click(object sender, EventArgs e)
        {
            actualizar_docente();

        }

        private void btndeletedocente_Click(object sender, EventArgs e)

        {
            string upd;
            upd = textboxmodidocente.Text;
            datos.DisposeDocenteSQL(upd, textboxmodidocente.Text, textboxmodinombredoce.Text, textboxmoditeldoce.Text);
            string id = textboxeletedoc.Text;
            eliminar_docente(id);
        }

        private void dgvModidocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dgvModidocentes.CurrentRow.Index;
            textboxmodidocente.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textboxmodinombredoce.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textboxmoditeldoce.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }

        private void btnmodidocentes_Click(object sender, EventArgs e)
        {
            GPModidocentes.Visible = true;
            GPsavedocente.Visible = false;
            panelsubmenudoc.Visible = false;
            GPverdocentes.Visible = false;
        }

        private void cargarmodidocentes_Click(object sender, EventArgs e)
        {
            cargar_docentesmodi();
        }
        private void modificar_docente() {

            lista_docentes = datos.leer_docentes();
        }

        private void eliminar_docente(string id)
        {
            lista_docentes = datos.leer_docentes();
            lista_docentes.eliminar_docente(id);
            regrabar_archiv();

        }

        private void regrabar_archiv()
        {
            datos.eliminar_archivo_doc();
            string linea;

            foreach (Docente doc in lista_docentes.coleccion_docentes())
            {
                linea = doc.Id + ";" + doc.Nombre + ";" + doc.Telefono;
                datos.GuardarDocente(linea);
            }
        }

        private void btnsalones_Click(object sender, EventArgs e)
        {
            Form salones = new FormSalones();
            salones.Show();
            GPModidocentes.Visible = false;
            GPsavedocente.Visible = false;
        }

        private void btnaggsal_Click(object sender, EventArgs e)
        {
            
            
            //salones.GPsavebloque.Visible = true;
        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            Form materias = new materias();
            GPModidocentes.Visible = false;
            GPsavedocente.Visible = false;
            materias.Show();
        }

        private void btngrupos_Click(object sender, EventArgs e)
        {
            Form gps = new Grupos();
            gps.Show();
            GPModidocentes.Visible = false;
            GPsavedocente.Visible = false;
        }

        private void dataGridDocentes_CellBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void btnhorarios_Click(object sender, EventArgs e)
        {
            Form filtro = new Filtrado();
            filtro.Show();
            GPModidocentes.Visible = false;
            GPsavedocente.Visible = false;
        }

        private void btnhordoc_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonalum_Click(object sender, EventArgs e)
        {
            Form studiante = new Estudiantes();
            studiante.Show();
            GPModidocentes.Visible = false;
            GPsavedocente.Visible = false;
        }
    }
}
