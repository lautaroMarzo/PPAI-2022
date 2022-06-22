using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class TipoRecursoTecnologico
    {
        private string nombre { get; set; }
        private string descripcion { get; set; }
        public TipoRecursoTecnologico(string _nombre, string _descripcion)
        {
            nombre = _nombre;
            descripcion = _descripcion;
        }

        public bool esTipoRT(string _nombre)
        {
            return nombre == _nombre;
        }

        public object[] getDatos()
        {
            object[] datos = new object[2];
            datos[0] = nombre;
            datos[1] = descripcion;
            return datos;
        }
    }
}
