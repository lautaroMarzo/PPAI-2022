using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class AsignacionCientificoDeICI
    {
        private DateTime fechaDesde { get; set; }
        private DateTime fechaHasta { get; set; }
        private PersonalCientifico personalCientifico { get; set; }

        public bool esCientificoActivo()
        {
            return fechaHasta == null;
        }

        public bool sosPersonalLogueado(Usuario usuario, out PersonalCientifico personal)
        {
            personal = personalCientifico;
            return personalCientifico.esTuUsuario(usuario);
        }
    }
}
