using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Logiica
{
    public  class Service_salon
    {
        public Salon Validar_Id(Salon salon, string id)
        {
            if (salon.Id == id)
            {
                return salon;
            }
            return null;
        }

        public Salon Validar_Nombre(List<Salon> salones, Salon salon)
        {
            foreach (var item in salones)
            {
                if (salon.Id == item.Id)
                {
                    return item;
                }
            }

            return null;
        }

    }
}
