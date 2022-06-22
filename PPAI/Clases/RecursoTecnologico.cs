using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class RecursoTecnologico
    {
        private DateTime fechaAlta { get; set; }
        private double fraccionHorarioTurnos { get; set; }
        private CambioEstadoRT[] cambioEstadoRT { get; set; }
        private TipoRecursoTecnologico tipoDeRT { get; set; }
        private Turno[] turnos { get; set; }
        private Modelo modeloDelRT { get; set; }
        private long numeroRt { get; set; }

        public bool sosBajaTecnicaODefinitiva()
        {
            foreach (var cambioEstado in cambioEstadoRT)
            {
                if (cambioEstado.sosEstadoActual())
                {
                    return cambioEstado.sosBajaTecnicaODefinitiva();
                }
            }
            return false;
        }

        public bool sosRT(long nroRT)
        {
            return numeroRt == nroRT;
        }

        public bool sosTipoSelec(TipoRecursoTecnologico tipo)
        {
            return tipoDeRT == tipo;
        }

        public long getNroRT()
        {
            return numeroRt;
        }

        public object[] buscarMarcaYModelo()
        {
            object[] nombreYMarca = new object[2];
            nombreYMarca[0] = modeloDelRT.getNombre();
            nombreYMarca[1] = modeloDelRT.buscarMarca();
            return nombreYMarca;
        }

        public string ObtenerEstado()
        {
            foreach (var cambioEstado in cambioEstadoRT)
            {
                if (cambioEstado.sosEstadoActual())
                {
                    return cambioEstado.obtenerEstado();
                }
            }
            return null;
        }

        public List<object[]> obtenerTurnos(DateTime fechaHoraActual, out List<Turno> _turnos)
        {
            _turnos = new List<Turno>();
            List<object[]> listaTurnosActualesActivos = new List<object[]>();
            foreach (var turno in turnos)
            {
                if (turno.esPosteriorFechaHoraActual(fechaHoraActual))
                {
                    if (turno.estoyDisponible())
                    {
                        var datosTurno = turno.getDatos();
                        _turnos.Add(turno);
                        listaTurnosActualesActivos.Add(datosTurno);
                    }
                }
            }
            return listaTurnosActualesActivos;
        }

        public void registrarReserva(Turno turno, DateTime _fechaHoraDesde, Estado _estadoReservado)
        {
            turno.registrarReserva(_fechaHoraDesde, _estadoReservado);
        }

    }
}
