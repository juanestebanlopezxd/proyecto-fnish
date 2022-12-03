using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logiica
{
    public class Service_Grupo
    {

        public Grupo Validar_Id(Grupo gp, string id)
        {
            if (gp.Id == id)
            {
                return gp;
            }
            return null;
        }

    }
}
