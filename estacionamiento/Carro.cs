using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento
{
    public class Carro:Vehiculo
    {
        public Carro(String subtipo, double tarifaHora) 
            : base("Carro", subtipo, tarifaHora) { }

        public override (double subtotal, double ahorro) CalcularCosto(int duracionMin)
        {
            int horas = duracionMin / 60;
            int minutosRestantes = duracionMin % 60;
            int cuartos = (int)Math.Ceiling(minutosRestantes / 15.0);

            if (horas == 0 && cuartos > 0) {
                horas = 1;
                cuartos = 0;
            }
            double subtotal = 0;
            double ahorro = 0;

            subtotal += TarifaHora;
            horas--;

            if (horas > 0 || cuartos > 0) {

                double tarifaDescuento = TarifaHora * 0.9;
                subtotal += horas * tarifaDescuento + cuartos*(tarifaDescuento/4);

                ahorro = horas * (TarifaHora * 0.1) + cuartos * (TarifaHora * 0.1 / 4);
            }
            return (subtotal, ahorro);
        }

    }
}
