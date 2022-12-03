using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Datos;
using Logiica;

namespace Test3
{
    public partial class Grupos : Form
    {
        private Datos_Grupos datos_gp = new Datos_Grupos();
        private Datos_Docentes datos_doc = new Datos_Docentes();
        private Datos_Materias datos_mat = new Datos_Materias();
        private Datos_Salones datos_sal = new Datos_Salones();
        private Datos_Estudiante datos_est = new Datos_Estudiante();
        private Lista_Docentes lst_doc;
        private Lista_Materias lst_mat;
        private Lista_Salones lst_salones;

        private Service_Estudiante logicest = new Service_Estudiante();
        private Service_docente logicdoc = new Service_docente();
        private Service_materia logicmat = new Service_materia();
        private Service_salon logicsal = new Service_salon();
        private Service_Grupo logicagp = new Service_Grupo();



        public Grupos()
        {
            InitializeComponent();
        }
        string id_doc, id_sal, id_mat, id_est, id_gp;
        private void Grupos_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btndetails_Click(object sender, EventArgs e)
        {

            var listasqlgp = datos_gp.ConsultarGrupoSQL();
            var lst_doc_sql = datos_doc.ConsultarDocenteSQL();
            var lst_sal_sql = datos_sal.ConsultarSalonSQL();
            var lst_mat_sql = datos_mat.ConsultarMateriaSQL();
            var listaSQL = datos_est.ConsultarInterSQL();
            var listasqlest = datos_est.ConsultarEstudianteSQL();


            if (listasqlgp == null)
            {

                return;
            }
            foreach (Grupo gp in listasqlgp)
            {
                if (logicagp.Validar_Id(gp, textBoxgp.Text) != null)
                {
                    id_doc = gp.Docente.Id;
                    id_mat = gp.Materia.Id;
                    id_sal = gp.Salon.Id;
                    id_gp = gp.Id;
                    label15.Text = gp.Horario;
                }
            }
            if (lst_doc_sql == null)
            {

                return;
            }
            foreach (Docente doc in lst_doc_sql)
            {
                if (logicdoc.Validar_Id(doc, id_doc) != null)
                {
                    label11.Text = doc.Nombre;
                    label16.Text = doc.Id;

                }
            }
            if (lst_sal_sql == null)
            {

                return;
            }
            foreach (Salon salon in lst_sal_sql)
            {
                if (logicsal.Validar_Id(salon, id_sal) != null)
                {
                    label13.Text = "# " + salon.Numsalon + "bloque :" + salon.bloque ; 

                }
            }
            if (lst_mat_sql == null)
            {

                return;
            }
            foreach (Materia materia in lst_mat_sql)
            {
                if (logicmat.Validar_Id(materia, id_mat) != null)
                {
                    label12.Text = materia.Nombre;

                }
            }

            dgvlstestudi.Rows.Clear();

           


            if (listaSQL == null)
            {

                return;
            }
            foreach (Estudiante est in listaSQL)
            {
                if (est.Grupo == id_gp)
                {
                    foreach (Estudiante estu in listasqlest)
                    {
                        if (estu.Id == est.Id)
                        {
                            dgvlstestudi.Rows.Add(estu.Id, estu.Nombre, estu.Telefono);
                        }
                    }
                }
                


            }
            panel4.Visible = true;
            panel3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridGrupos.Rows.Clear();
            var listaSQL = datos_gp.ConsultarGrupoSQL();


            if (listaSQL == null)
            {

                return;
            }
            foreach (Grupo gp in listaSQL)
            {
                dataGridGrupos.Rows.Add(gp.Id, gp.Nombre, gp.Horario, gp.Dsemana);


            }
        }

        private void dataGridGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnestudiagg_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = false;

        }

        private void btnestudidispose_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel3.Visible = false;
        }

        private void btnestudimodi_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel3.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel3.Visible = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var listasqlest = datos_est.ConsultarEstudianteSQL();
            var listasqlgp = datos_gp.ConsultarGrupoSQL();
            if (listasqlest == null)
            {
                MessageBox.Show("lista vacia");
                return; 
            }
            foreach (Estudiante est  in listasqlest)
            {

                if (logicest.Validar_Id(est, textBoxidalum.Text) != null)
                {
                    id_est = est.Id;
                }

            }
            if (listasqlgp == null)
            {
                MessageBox.Show("lista vacia");
                return;
            }
            foreach (Grupo gp in listasqlgp)
            {
                if (logicagp.Validar_Id(gp, textBoxidgp.Text) != null)
                {
                    id_gp = gp.Id;
                }

            }


            if (id_est != null && id_gp != null)
            {
                Estudiante est = new Estudiante();
                est.Id = id_est;
                est.Grupo = id_gp;
                datos_est.GuardarEstudianteinterSQL(est);
                MessageBox.Show("Asignado correctamente");
            }else
            {
                MessageBox.Show("error al asignar estudiante");
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncreargp_Click(object sender, EventArgs e)
        {
            lst_doc = datos_doc.leer_docentes();
            lst_mat = datos_mat.leer_materias();
            lst_salones = datos_sal.leer_salones();
            var lst_doc_sql = datos_doc.ConsultarDocenteSQL();
            var lst_sal_sql = datos_sal.ConsultarSalonSQL();
            var lst_mat_sql = datos_mat.ConsultarMateriaSQL();
            Grupo gp = new Grupo();


            if (datos_doc.leer_docentes() == null)
            {

                return;
            }
            foreach (Docente docente in lst_doc_sql)
            {

                if (logicdoc.Validar_Id(docente, textBoxiddocgp.Text) != null)
                {
                    id_doc = docente.Id;
                }
                
            }
            if (datos_sal.leer_salones() == null)
            {

                return;
            }
            foreach (Salon salon in lst_sal_sql)
            {
                if (logicsal.Validar_Id(salon, textBoxidsalongp.Text) != null)
                {
                    id_sal = salon.Id;
                }
                
            }
            if (datos_mat.leer_materias() == null)
            {

                return;
            }
            foreach (Materia materia in lst_mat_sql)
            {
                if (logicmat.Validar_Id(materia, textBoxidmateriagp.Text) != null)
                {
                    id_mat = materia.Id;
                }
                
            }



            if (id_sal != null & id_mat != null & id_doc != null)
            {
                string linea;
                linea = textBoxidmatgp.Text + ";" + textBoxiddocgp.Text + ";" + textBoxidsalongp.Text + ";" + textBoxidmateriagp.Text + ";" + comboBoxdiasem.Text + ";" + comboBoxhora.Text + ";" + textBoxnumgp.Text;
                gp.Id = textBoxidmatgp.Text;
                gp.Nombre = textBoxnumgp.Text;
                gp.Horario = comboBoxhora.Text;
                gp.Dsemana = comboBoxdiasem.Text;
                Salon salon = new Salon();
                salon.Id = textBoxidsalongp.Text;
                gp.Salon = salon;
                Docente docente = new Docente();
                docente.Id = textBoxiddocgp.Text;
                gp.Docente = docente;
                Materia materia = new Materia();
                materia.Id = textBoxidmateriagp.Text;
                gp.Materia = materia;
                datos_gp.GuardarGrupoSQL(gp);
                datos_gp.GuardarGrupo(linea);
                MessageBox.Show("se guardo el gp correctamente");
            }
            //string linea;
            //linea = textBoxidmatgp.Text + ";" + textBoxiddocgp.Text + ";" + textBoxidsalongp.Text + ";" + textBoxidmateriagp.Text + ";" + comboBoxdiasem.Text + ";" + comboBoxhora.Text + ";" + textBoxnumgp.Text;

            //if (datos_gp.GuardarGrupo(linea) == true)
            //{
            //    MessageBox.Show("Se guardo el grupo correctamente");
            //}
            //else
            //{
            //    MessageBox.Show("error al guardar el grupo");
            //}


        }
    }
}