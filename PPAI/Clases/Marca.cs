using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Marca
    {
        private string nombre { get; set; }
        private Modelo[] modelos { get; set; }

        public string getNombre()
        {
            return nombre;
        }

        public bool esTuModelo(Modelo modeloConsultado)
        {
            foreach (var modelo in modelos)
            {
                if (modelo.Equals(modeloConsultado))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
