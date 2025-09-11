using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento
{
    public abstract class Vehiculo
    {
        public String Tipo { get; }
        public String SubTipo { get; }
        public double TarifaHora { get; }

        public Vehiculo(string tipo, string subTipo, double tarifaHora)
        {
            Tipo = tipo;
            SubTipo = subTipo;
            TarifaHora = tarifaHora;
        }
        public abstract (double subtotal, double ahorro) CalcularCosto(int duracionMin);
    }
}
