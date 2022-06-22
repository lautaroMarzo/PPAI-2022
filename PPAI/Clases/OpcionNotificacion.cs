using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class OpcionNotificacion
    {
        private long id {get; set;}
        private string descripcion { get; set; }

        public OpcionNotificacion(long _id, string _descripcion)
        {
            id = _id;
            descripcion = _descripcion;
        }

    }
}
