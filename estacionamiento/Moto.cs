using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento
{
    public class Moto: Vehiculo
    {
        public Moto() : base("Moto", "Moto", 600) { }
        public override (double subtotal, double ahorro) CalcularCosto(int duracionMin)
        {
            int horas = duracionMin / 60;
            int minutosRestantes = duracionMin % 60;
            if (minutosRestantes > 0) {
                horas++;
            }
            double subtotal = horas * TarifaHora;
            return (subtotal, 0);
        }
    }
}
