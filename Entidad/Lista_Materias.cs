using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Lista_Materias
    {
        private List<Materia> col_materias = new List<Materia>();


        public void agg_materia(Materia materia)
        {
            col_materias.Add(materia);
        }

        public List<Materia> coleccion_materias()
        {
            return col_materias;

        }

        public void actualizar_materia(Materia materia)
        {

            Materia materia1 = col_materias.Where(d => d.Id == materia.Id).FirstOrDefault();
            materia1.Id = materia.Id;
            materia1.Nombre = materia.Nombre;
            materia1.Creditos = materia.Creditos;
        }

        public void eliminar_materia(string Idmate)
        {

            Materia materia1 = col_materias.Where(d => d.Id == Idmate).FirstOrDefault();
            col_materias.Remove(materia1);
        }

    }
}
