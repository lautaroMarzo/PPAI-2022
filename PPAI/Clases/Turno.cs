using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Turno
    {
        private string diaSemana { get; set; }
        private DateTime fechaHoraInicio { get; set; }
        private DateTime fechaHoraFin { get; set; }
        private List<CambioEstadoTurno> cambioEstadoTurnos { get; set; }

        public Turno(string _diaSemana, DateTime _fechaInicio, DateTime _fechaFin, List<CambioEstadoTurno> _cambioEstados)
        {
            diaSemana = _diaSemana;
            fechaHoraInicio = _fechaInicio;
            fechaHoraFin = _fechaFin;
            cambioEstadoTurnos = _cambioEstados;
        }

        public bool esPosteriorFechaHoraActual(DateTime fechaHoraActual)
        {
            return fechaHoraActual > fechaHoraInicio;
        }

        public bool esTurno(string _diaSemana, DateTime _fechaHoraDesde, DateTime _fechaHoraHasta)
        {
            return diaSemana == _diaSemana && fechaHoraInicio == _fechaHoraDesde && fechaHoraFin == _fechaHoraHasta;
        }

        public bool estoyDisponible()
        {
            foreach (var cambioEstado in cambioEstadoTurnos)
            {
                if (cambioEstado.esActual())
                {
                    if (cambioEstado.estaDisponible())
                        return true;
                    else
                        return false;
                }   
            }
            return false;
        }

        public object[] getDatos()
        {
            object[] datosTurno = new object[5];
            datosTurno[0] = diaSemana;
            datosTurno[1] = fechaHoraInicio;
            datosTurno[2] = fechaHoraFin;
            foreach (var cambioEstado in cambioEstadoTurnos)
            {
                if (cambioEstado.esActual())
                {
                    datosTurno[3] = cambioEstado.getNombreEstado();
                    return datosTurno;
                }
            }
            datosTurno[3] = "No se encontro";
            return datosTurno;
        }

        public void registrarReserva(DateTime _fechaHoraDesde, Estado _estadoReservado)
        {
            CambioEstadoTurno _cambioEstadoTurnoActual;
            foreach (var estado in cambioEstadoTurnos)
            {
                if (estado.esActual())
                {
                    _cambioEstadoTurnoActual = estado;
                    _cambioEstadoTurnoActual.setFechaHoraHasta(_fechaHoraDesde);
                    var cambioEstado = new CambioEstadoTurno(_fechaHoraDesde, _estadoReservado);
                    this.cambioEstadoTurnos.Add(cambioEstado);
                }
            }

        }


    }
}
