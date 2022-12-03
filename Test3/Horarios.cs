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
    public partial class Horarios : Form
    {
        string idcon;
        int tipe;
        private Datos_Docentes datosdoc = new Datos_Docentes();
        private Lista_Docentes lista_docentes;
        private Datos_Grupos datosgp = new Datos_Grupos();
        private Lista_Grupos lista_grupos;
        private Datos_Materias datosmat = new Datos_Materias();
        private Lista_Materias lista_materias;
        private Datos_Salones datosal = new Datos_Salones();
        private Lista_Salones lista_salones;
        private Service_materia servicemat;
        private Service_salon servicesal;
        public Horarios(string id,int tipo)
        {
            servicemat = new Service_materia();
            servicesal = new Service_salon();
            InitializeComponent();
            idcon = id;
            tipe = tipo;
            valHoraios();
        }

        public void valHoraios()
        {
            if (tipe == 1)
            {
                var listadocSQL = datosdoc.ConsultarDocenteSQL();
                var listagpSQL = datosgp.ConsultarGrupoSQL();
                var listamatSQL = datosmat.ConsultarMateriaSQL();
                var listasalSQL = datosal.ConsultarSalonSQL();
                
                if (listagpSQL == null)
                {

                    return;
                }
                foreach (Grupo gp in listagpSQL)
                {
                   if(gp.Docente.Id == idcon)
                    {
                        if (gp.Dsemana == "Lunes")
                        {
                            Salon sal = new Salon();
                            var namemat = servicemat.Validar_Nombre(listamatSQL, gp.Materia);
                            sal = servicesal.Validar_Nombre(listasalSQL, gp.Salon);
                            if (labelluneshorario.Text == "")
                            {
                                labelluneshorario.Text = gp.Horario;
                                labellunesmateria.Text = namemat;
                                labelunesalon.Text = sal.Numsalon + " Bloque:" + sal.bloque;

                            }
                            else if (labelunes2.Text == "")
                            {
                                labelunes2.Text = gp.Horario;
                                label9.Text = namemat;
                                label8.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label13.Text == "")
                            {
                                label13.Text = gp.Horario;
                                label12.Text = namemat;
                                label11.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label16.Text == "")
                            {
                                label16.Text = gp.Horario;
                                label15.Text = namemat;
                                label14.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label19.Text == "")
                            {
                                label19.Text = gp.Horario;
                                label18.Text = namemat;
                                label17.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }

                        }
                        else if (gp.Dsemana == "Martes")
                        {
                            Salon sal = new Salon();
                            var namemat = servicemat.Validar_Nombre(listamatSQL, gp.Materia);
                            sal = servicesal.Validar_Nombre(listasalSQL, gp.Salon);
                            if (label10.Text == "")
                            {
                                label10.Text = gp.Horario;
                                label2.Text = namemat;
                                label1.Text = sal.Numsalon + " Bloque:" + sal.bloque;

                            }
                            else if (label22.Text == "")
                            {
                                label22.Text = gp.Horario;
                                label21.Text = namemat;
                                label20.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label25.Text == "")
                            {
                                label25.Text = gp.Horario;
                                label24.Text = namemat;
                                label23.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label28.Text == "")
                            {
                                label28.Text = gp.Horario;
                                label27.Text = namemat;
                                label26.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label31.Text == "")
                            {
                                label31.Text = gp.Horario;
                                label30.Text = namemat;
                                label29.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                        }
                        else if (gp.Dsemana == "Miercoles")
                        {
                            Salon sal = new Salon();
                            var namemat = servicemat.Validar_Nombre(listamatSQL, gp.Materia);
                            sal = servicesal.Validar_Nombre(listasalSQL, gp.Salon);
                            if (label34.Text == "")
                            {
                                label34.Text = gp.Horario;
                                label33.Text = namemat;
                                label32.Text = sal.Numsalon + " Bloque:" + sal.bloque;

                            }
                            else if (label37.Text == "")
                            {
                                label37.Text = gp.Horario;
                                label36.Text = namemat;
                                label35.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label40.Text == "")
                            {
                                label40.Text = gp.Horario;
                                label39.Text = namemat;
                                label38.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label43.Text == "")
                            {
                                label43.Text = gp.Horario;
                                label42.Text = namemat;
                                label41.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label46.Text == "")
                            {
                                label46.Text = gp.Horario;
                                label45.Text = namemat;
                                label44.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                        }
                        else if (gp.Dsemana == "Jueves")
                        {
                            Salon sal = new Salon();
                            var namemat = servicemat.Validar_Nombre(listamatSQL, gp.Materia);
                            sal = servicesal.Validar_Nombre(listasalSQL, gp.Salon);
                            if (label48.Text == "")
                            {
                                label48.Text = gp.Horario;
                                label49.Text = namemat;
                                label47.Text = sal.Numsalon + " Bloque:" + sal.bloque;

                            }
                            else if (label51.Text == "")
                            {
                                label51.Text = gp.Horario;
                                label52.Text = namemat;
                                label50.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label54.Text == "")
                            {
                                label54.Text = gp.Horario;
                                label55.Text = namemat;
                                label53.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label57.Text == "")
                            {
                                label57.Text = gp.Horario;
                                label58.Text = namemat;
                                label56.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label60.Text == "")
                            {
                                label60.Text = gp.Horario;
                                label61.Text = namemat;
                                label59.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                        }
                        else if (gp.Dsemana == "Viernes")
                        {
                            Salon sal = new Salon();
                            var namemat = servicemat.Validar_Nombre(listamatSQL, gp.Materia);
                            sal = servicesal.Validar_Nombre(listasalSQL, gp.Salon);
                            if (label63.Text == "")
                            {
                                label63.Text = gp.Horario;
                                label64.Text = namemat;
                                label62.Text = sal.Numsalon + " Bloque:" + sal.bloque;

                            }
                            else if (label66.Text == "")
                            {
                                label66.Text = gp.Horario;
                                label67.Text = namemat;
                                label65.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label69.Text == "")
                            {
                                label69.Text = gp.Horario;
                                label70.Text = namemat;
                                label68.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label72.Text == "")
                            {
                                label72.Text = gp.Horario;
                                label73.Text = namemat;
                                label71.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                            else if (label75.Text == "")
                            {
                                label75.Text = gp.Horario;
                                label76.Text = namemat;
                                label74.Text = sal.Numsalon + " Bloque:" + sal.bloque;
                            }
                        }


                    }


                }


            }

        }

        private void labelluneshorario_Click(object sender, EventArgs e)
        {

        }

        private void lunes1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void miercoles3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viernes4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
