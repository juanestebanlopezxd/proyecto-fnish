using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logiica
{
    public class Service_materia
    {
        public Materia Validar_Id(Materia materia, string id)
        {
            if (materia.Id == id)
            {
                return materia;
            }
            return null;
        }

        public string Validar_Nombre(List<Materia> materias, Materia materia)
        {
            foreach (var item in materias)
            {
                if (materia.Id == item.Id)
                {
                    return item.Nombre;
                }
            }
            
            return " ";
        }
    }
}
