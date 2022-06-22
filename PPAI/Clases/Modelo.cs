using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI.Clases
{
    public class Modelo
    {
        private string nombre { get; set; }

        public string getNombre()
        {
            return nombre;
        }
        public string buscarMarca()
        {
            Marca[] marcas = obtenerMarcas();
            foreach (var marca in marcas)
            {
                if (marca.esTuModelo(this)){
                    return marca.getNombre();
                }
            }
            return null;
        }

        public Marca[] obtenerMarcas()
        {
            return null;
        }

    }
}
