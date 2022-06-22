using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class CambioEstadoRT
    {
        private DateTime fechaDesde { get; set; }
        private DateTime fechaHasta { get; set; }
        private Estado estado { get; set; }

        public CambioEstadoRT(DateTime _fechadDesde, DateTime _fechaHasta, Estado _estado)
        {
            fechaDesde = _fechadDesde;
            fechaHasta = _fechaHasta;
            estado = _estado;
        }

        public bool sosEstadoActual()
        {
            return fechaHasta == null;
        }

        public bool sosBajaTecnicaODefinitiva()
        {
            return estado.sosBajaTecnicaODefinitiva();
        }

        public string obtenerEstado()
        {
            return estado.getNombre();
        }

    }
}
