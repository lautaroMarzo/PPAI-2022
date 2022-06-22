using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI.BD;
using PPAI.Interfaz;
using PPAI.Clases;

namespace PPAI.Gestor
{
    public class GestorRegistrarReserva
    {
        BD_Acceso_Datos _BD = new BD_Acceso_Datos();

        private List<CentroDeInvestigacion> centroInvestigacion = new List<CentroDeInvestigacion>();
        private List<TipoRecursoTecnologico> tiposRecursosTecnologicos = new List<TipoRecursoTecnologico>();
        private List<Estado> estados = new List<Estado>();
        private Estado estadoReservado { get; set; }
        private List<RecursoTecnologico> recursosTecnologicos;
        private InterfazRegistrarReserva interfazRegistrarReserva { get; set; }
        private Sesion sesionActual { get; set; }
        private Usuario usuarioActual { get; set; }
        private PersonalCientifico personalCientificoActual { get; set; }
        private DateTime horaActual { get; set; }
        private List<object[]> datosTurnos { get; set; }
        private List<Turno> turnos { get; set; }
        private CambioEstadoTurno cambioEstadoActual { get; set; }
        private Turno turnoSeleccionado { get; set; }
        private RecursoTecnologico recursoSeleccionado { get; set; }
        private CentroDeInvestigacion centroSeleccionado { get; set; }
        private List<OpcionNotificacion> opcionesNotificacion { get; set; }
        private string correoUsuario { get; set; }
        
        public void buscarTiposRT(InterfazRegistrarReserva interfaz)
        {
            crearObjetos();
            interfazRegistrarReserva = interfaz;
            List<object[]> tiposRecursos = new List<object[]>();
            foreach (var tipo in tiposRecursosTecnologicos)
            {
                tiposRecursos.Add(tipo.getDatos());
            }
            interfazRegistrarReserva.mostrarTiposRT(tiposRecursos);
        }

        public void tomarTiposRT(string nombre)
        {
            foreach (var tipo in tiposRecursosTecnologicos)
            {
                if (tipo.esTipoRT(nombre))
                {
                    buscarRT(tipo);
                }
            }
        }

        public void buscarRT(TipoRecursoTecnologico tipoSeleccionado)
        {
            List<object[]> recursos = new List<object[]>();
            List<RecursoTecnologico> _recursosTecnologicos = new List<RecursoTecnologico>();
            foreach (var centros in centroInvestigacion)
            {
                var auxRecuros = new List<RecursoTecnologico>();
                recursos.Concat(centros.buscarRT(tipoSeleccionado, out auxRecuros));
                _recursosTecnologicos.Concat(auxRecuros);
            }
            recursosTecnologicos = _recursosTecnologicos;
            interfazRegistrarReserva.mostrarRTPorColor(recursos);
        }

        public void tomarRT(long nroRT, CentroDeInvestigacion _centroSeleccionado)
        {
            foreach (var rt in recursosTecnologicos)
            {
                if (rt.sosRT(nroRT))
                {
                    buscarUsuarioActual(rt, _centroSeleccionado);
                }
            }
        }

        public void buscarUsuarioActual(RecursoTecnologico _recursoSeleccionado, CentroDeInvestigacion _centroSeleccionado)
        {
            recursoSeleccionado = _recursoSeleccionado;
            centroSeleccionado = _centroSeleccionado;
            usuarioActual = sesionActual.getUsuario();
            verificarCientifico(usuarioActual);
        }

        public void verificarCientifico(Usuario usuario)
        {
            var personal = new PersonalCientifico();
            bool estaVerificado = centroSeleccionado.verificarCientifico(usuario, out personal);
            personalCientificoActual = personal;
            if (estaVerificado)
            {
                obtenerTurnos();
            }
        }

        public void obtenerTurnos()
        {
            horaActual = getFechaHoraActual();
            var _turnos = new List<Turno>();
            datosTurnos = centroSeleccionado.obtenerTurnos(recursoSeleccionado, horaActual, out _turnos);
            turnos = _turnos;
            agruparOrdenarTurnos();
        }

        /// <summary>
        /// Método que obtiene la hora actual
        /// </summary>
        /// <returns></returns>
        public DateTime getFechaHoraActual()
        {
            return DateTime.Now;
        }

        public void agruparOrdenarTurnos()
        {
            for (int i = 0; i < datosTurnos.Count; i++)
            {
                for (int j = 0; j < datosTurnos.Count; j++)
                {
                    //algo ?
                }
            }
            interfazRegistrarReserva.mostrarTurnos(datosTurnos);
        }

        public void tomarTurno(string diaSemana, DateTime fechaHoraDesde, DateTime fechaHoraHasta)
        {
            foreach (var turno in turnos)
            {
                if(turno.esTurno(diaSemana, fechaHoraDesde, fechaHoraHasta))
                {
                    turnoSeleccionado = turno;
                    obtenerOpcNotificacion();
                    break;
                }
            }
        }

        public void obtenerOpcNotificacion()
        {
            interfazRegistrarReserva.mostrarOpcionesNotificacion(opcionesNotificacion);
        }

        public void tomarConfirmacion(bool respuesta)
        {
            if (respuesta)
            {
                registrarReservaTurno();
            }
            else
            {
                //Rechazo..
            }
        }

        public void registrarReservaTurno()
        {
            foreach (var estado in estados)
            {
                if (estado.esAmbitoTurno())
                {
                    if (estado.esReservado())
                    {
                        centroSeleccionado.registrarReservaTurno(recursoSeleccionado, turnoSeleccionado, horaActual, estado); //falta turnoselec
                        break;
                    }
                }
            }
        }

        public void buscarEmailCientifico()
        {
            correoUsuario = personalCientificoActual.getCorreoElectronicoInstitucional();
            generarNotificacion();
        }

        public void generarNotificacion()
        {
            var datosTurno = turnoSeleccionado.getDatos();
            string mensaje = $"Se envio el mensaje al correo ${correoUsuario}, sobre el turno para el {recursoSeleccionado.getNroRT()} el dia {datosTurno[0]}, desde las {datosTurno[1]} hasta las {datosTurno[2]}";
            InterfazEmail interfazEmail = new InterfazEmail();
            interfazEmail.Show();
            interfazEmail.notificar(mensaje);
        }



        public void crearObjetos()
        {
            TipoRecursoTecnologico tipoRecurso1 = new TipoRecursoTecnologico("Balanza de precisión", "");
            TipoRecursoTecnologico tipoRecurso2 = new TipoRecursoTecnologico("Microscopio", "");
            TipoRecursoTecnologico tipoRecurso3 = new TipoRecursoTecnologico("Resonador magnetico", "");
            TipoRecursoTecnologico tipoRecurso4 = new TipoRecursoTecnologico("Equipamiento de cómputo de datos de alto rendimiento", "");
            TipoRecursoTecnologico tipoRecurso5 = new TipoRecursoTecnologico("Equipamiento de cómputo de datos de medio rendimiento", "");
            TipoRecursoTecnologico tipoRecurso6 = new TipoRecursoTecnologico("Equipamiento de cómputo de datos de bajo rendimiento", "");
            TipoRecursoTecnologico tipoRecurso7 = new TipoRecursoTecnologico("Balanza de precisión", "");
            tiposRecursosTecnologicos.Add(tipoRecurso1);
            tiposRecursosTecnologicos.Add(tipoRecurso2);
            tiposRecursosTecnologicos.Add(tipoRecurso3);
            tiposRecursosTecnologicos.Add(tipoRecurso4);
            tiposRecursosTecnologicos.Add(tipoRecurso5);
            tiposRecursosTecnologicos.Add(tipoRecurso6);
            tiposRecursosTecnologicos.Add(tipoRecurso7);
            //OpcionNotificacion opcionNotificacion1 = new OpcionNotificacion(1, "Mail");
            //OpcionNotificacion opcionNotificacion2 = new OpcionNotificacion(2, "Mensaje telefonico");
            //opcionesNotificacion.Add(opcionNotificacion1);
            //opcionesNotificacion.Add(opcionNotificacion2);
            Estado estadoTurno1 = new Estado("Reservado", "Turno", "El turno se encuentra reservado");
            Estado estadoTurno2 = new Estado("Disponible", "Turno", "El turno se encuentra disponible");
            Estado estadoTurno3 = new Estado("Cancelado", "Turno", "El turno se encuentra cancelad");
            Estado estadoRecurso1 = new Estado("Baja Tecnica", "Recurso", "El recurso se encuentra en baja tecnica");
            Estado estadoRecurso2 = new Estado("Baja Definitiva", "Recurso", "El recurso se encuentra en baja definitiva");
            Estado estadoRecurso3 = new Estado("Disponible", "Recurso", "El recurso se encuentra disponible");
            estados.Add(estadoTurno1);
            estados.Add(estadoTurno2);
            estados.Add(estadoTurno3);
            estados.Add(estadoRecurso1);
            estados.Add(estadoRecurso2);
            estados.Add(estadoRecurso3);

        }



        /// <summary>
        /// Modificar la función segun las sp que se llamen dentro de la base de datos
        /// </summary>
        public void Insertar()
        {
            string sql = "INSERT into Productos_x_Factura (codProducto, idFactura, monto, cantidad) VALUES ()";
            _BD.InicioTransaccion();
            _BD.Insertar(sql);
            _BD.FinalTransaccion();
        }
    }
}
