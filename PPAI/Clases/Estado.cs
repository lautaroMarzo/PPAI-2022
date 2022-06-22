using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Estado
    {
        private string ambito { get; set; }
        private string descripcion { get; set; }
        private string nombre { get; set; }

        public Estado(string _nombre, string _ambito, string _descripcion)
        {
            nombre = _nombre;
            ambito = _ambito;
            descripcion = _descripcion;
        }

        public bool sosBajaTecnicaODefinitiva()
        {
            return (nombre == "Baja Tecnica" || nombre == "Baja Definitiva") && ambito == "Recurso";
        }

        public string getNombre()
        {
            return nombre;
        }

        public bool estoyDisponible()
        {
            return nombre == "Disponible" && ambito == "Turno";
        }

        public bool esAmbitoTurno()
        {
            return ambito == "Turno";
        }

        public bool esReservado()
        {
            return nombre == "Reservado";
        }
    }
}
