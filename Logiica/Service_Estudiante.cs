using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logiica
{
    public class Service_Estudiante
    {
        public Estudiante Validar_Id(Estudiante est, string id)
        {
            if (est.Id == id)
            {
                return est;
            }
            return null;
        }

    }
}
