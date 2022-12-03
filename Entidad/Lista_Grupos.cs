using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Lista_Grupos
    {
        private List<Grupo> col_grupos= new List<Grupo>();


        public void agg_grupo(Grupo grupo)
        {
            col_grupos.Add(grupo);
        }

        public List<Grupo> coleccion_grupos()
        {
            return col_grupos;

        }

        //public void actualizar_docente(Docente docente)
        //{

        //    Docente docente1 = col_docentes.Where(d => d.Id == docente.Id).FirstOrDefault();
        //    docente1.Id = docente.Id;
        //    docente1.Nombre = docente.Nombre;
        //    docente1.Telefono = docente.Telefono;
        //}

        public void eliminar_grupo(string IDentificacion)
        {

            Grupo grupo1 = col_grupos.Where(d => d.Id == IDentificacion).FirstOrDefault();
            col_grupos.Remove(grupo1);


        }
    }
}
