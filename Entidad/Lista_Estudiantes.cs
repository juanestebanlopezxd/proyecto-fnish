using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public  class Lista_Estudiantes
    {

        private List<Estudiante> col_estudiantes = new List<Estudiante>();


        public void agg_estudiante(Estudiante estudiante)
        {
            col_estudiantes.Add(estudiante);
        }

        public List<Estudiante> coleccion_estudiantes()
        {
            return col_estudiantes;

        }

        public void actualizar_estudiante(Estudiante estudiante)
        {

            Estudiante estudiante1 = col_estudiantes.Where(d => d.Id == estudiante.Id).FirstOrDefault();
            estudiante1.Id = estudiante.Id;
            estudiante1.Nombre = estudiante.Nombre;
            estudiante1.Telefono = estudiante.Telefono;
        }

        public void eliminar_estudiante(string IDentificacion)
        {

            Estudiante estudiante1 = col_estudiantes.Where(d => d.Id == IDentificacion).FirstOrDefault();
            col_estudiantes.Remove(estudiante1);


        }
    }
}
