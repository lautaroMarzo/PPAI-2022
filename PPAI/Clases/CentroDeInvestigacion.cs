using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class CentroDeInvestigacion
    {
        private RecursoTecnologico[] recursosTecnologicos { get; set; }
        private AsignacionCientificoDeICI[] cientificos { get; set; }


        /// <summary>
        /// Busca los recursos tencologicos que no se encuentren en estado baja tecnica
        /// </summary>
        /// <returns>Centro de investigación, Nro RT, Marca y modelo, estado </returns>
        public List<object[]> buscarRT(TipoRecursoTecnologico tipoSeleccionado, out List<RecursoTecnologico> recursos)
        {
            List<object[]> resultado = new List<object[]>();

            List<RecursoTecnologico> recursosFiltrados = new List<RecursoTecnologico>();
            List<RecursoTecnologico> arrayAuxiliar = new List<RecursoTecnologico>();
            recursos = new List<RecursoTecnologico>();

            foreach (var recurso in recursosTecnologicos)
            {
                if (recurso.sosTipoSelec(tipoSeleccionado))
                {
                    recursosFiltrados.Add(recurso);
                }
            }

            arrayAuxiliar = recursosFiltrados;
            recursosFiltrados = new List<RecursoTecnologico>();

            foreach (var recurso in arrayAuxiliar)
            {
                if (recurso.sosBajaTecnicaODefinitiva())
                {
                    recursosFiltrados.Add(recurso);
                }
            }

            foreach (var recurso in recursosFiltrados)
            {
                object[] filtrado = new object[4];
                filtrado[0] = this;
                filtrado[1] = recurso.getNroRT();
                filtrado[2] = recurso.buscarMarcaYModelo();
                filtrado[3] = recurso.ObtenerEstado();
                recursos.Add(recurso);
                resultado.Add(filtrado);
            }
            return resultado;
        }

        /// <summary>
        /// Metodo que devuelve si el cientifico se encuentra activo y trabajando en el centro
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public bool verificarCientifico(Usuario usuario, out PersonalCientifico personal)
        {
            List<AsignacionCientificoDeICI> cientificosActivos = new List<AsignacionCientificoDeICI>();
            foreach (var cientifico in cientificos)
            {
                if (cientifico.esCientificoActivo())
                {
                    if (cientifico.sosPersonalLogueado(usuario, out personal))
                    {
                        return true;
                    }
                }
            }
            personal = null;
            return false;
        }

        /// <summary>
        /// Obtiene los turnos con su estado, para el recurso tecnologico
        /// </summary>
        /// <param name="recursoTecnologico"></param>
        /// <param name="horaActual"></param>
        /// <returns></returns>
        public List<object[]> obtenerTurnos(RecursoTecnologico recursoTecnologico, DateTime horaActual, out List<Turno> turnos)
        {
            return recursoTecnologico.obtenerTurnos(horaActual, out turnos);
        }

        public void registrarReservaTurno(RecursoTecnologico _recursoSeleccionado, Turno _turnoSeleccionado, DateTime _fechaHoraDesde, Estado _estadoReservado)
        {
            _recursoSeleccionado.registrarReserva(_turnoSeleccionado, _fechaHoraDesde, _estadoReservado);
        }

    }
}
