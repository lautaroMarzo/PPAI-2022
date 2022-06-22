using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class CambioEstadoTurno
    {
        private DateTime fechaHoraDesde { get; set; }
        private DateTime fechaHoraHasta { get; set; }
        private Estado estado { get; set; }
        public CambioEstadoTurno(DateTime _fechaHoraDesde, Estado _estado)
        {
            fechaHoraDesde = _fechaHoraDesde;
            estado = _estado;
        }

        public bool esActual()
        {
            return fechaHoraHasta == null;
        }

        public bool estaDisponible()
        {
            return estado.estoyDisponible();
        }

        public string getNombreEstado()
        {
            return estado.getNombre();
        }

        public void setFechaHoraHasta(DateTime _fechaHoraHasta)
        {
            fechaHoraHasta = _fechaHoraHasta;
        }
    }
}
