using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Sesion
    {
        private DateTime fechaHoraIni { get; set; }
        private DateTime fechaHoraFin { get; set; }
        private Usuario usuario { get; set; }

        public Usuario getUsuario()
        {
            return usuario;
        }
    }
}
