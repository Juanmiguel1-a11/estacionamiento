using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento
{
    public class Cliente
    {
        public String Nombre { get; set; }
        public String Placa { get; set; }

        public Cliente(string nombre, string placa)
        {
            Nombre = nombre;
            Placa = placa;
        }
    }
}
