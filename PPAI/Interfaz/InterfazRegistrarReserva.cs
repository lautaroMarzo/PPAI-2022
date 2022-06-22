using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Clases;
using PPAI.Gestor;

namespace PPAI
{
    public partial class InterfazRegistrarReserva : Form
    {
        private List<object[]> tiposRT { get; set; }
        private GestorRegistrarReserva gestorRegistrarReserva = new GestorRegistrarReserva();
        public InterfazRegistrarReserva()
        {
            InitializeComponent();
            gestorRegistrarReserva.buscarTiposRT(this);
        }

        public void mostrarTiposRT(List<object[]> tipos)
        {
            tiposRT = tipos;
            for (int i = 0; i < tipos.Count; i++)
            {
                comboTipoRecursoTecnologico.Items.Add(tipos[i][0]);
            }
        }

        public void selecTipoRT(string nombreTipo)
        {
            //string nombreTipo = "";
            gestorRegistrarReserva.tomarTiposRT(nombreTipo);
        }

        public void mostrarRTPorColor(List<object[]> recursos)
        {
            grillaRecursoTecnologico.DataSource = recursos.ToList();
        }
        
        public void selecRT()
        {
            long nroRT = 0;
            CentroDeInvestigacion ci = new CentroDeInvestigacion();
            gestorRegistrarReserva.tomarRT(nroRT, ci);
        }

        public void mostrarTurnos(List<object[]> turnos)
        {

        }

        public void selecTurno()
        {
            string diaSemana = "";
            DateTime fechaHoraDesde = DateTime.Now;
            DateTime fechaHoraHasta = DateTime.Now;
            gestorRegistrarReserva.tomarTurno(diaSemana, fechaHoraDesde, fechaHoraHasta);
        }
         
        public void mostrarOpcionesNotificacion(List<OpcionNotificacion> opcionesNotificacion)
        {

        }

        public void tomarConfirmacion()
        {
            bool respuesta = true;
            gestorRegistrarReserva.tomarConfirmacion(respuesta);
        }

        private void btnReservarTurno_Click(object sender, EventArgs e)
        {

        }

        private void comboTipoRecursoTecnologico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreTipo = "";
            nombreTipo = comboTipoRecursoTecnologico.SelectedItem.ToString();
            selecTipoRT(nombreTipo);
        }
    }
}
