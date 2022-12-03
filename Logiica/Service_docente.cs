using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logiica
{
    public class Service_docente
    {
        

        public Docente Validar_Id(Docente docente, string id)
        {
            if (docente.Id== id)
            {
                return docente;
            }
            return null;
        }


    }
}
