using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamiento
{
    public class Factura
    {
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }
        public int DuracionMin { get; set; }
        public double Subtotal { get; set; }
        public double Ahorro { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }

        public Factura(Cliente cliente, Vehiculo vehiculo, DateTime horaEntrada, DateTime horaSalida)
        {
            Cliente = cliente;
            Vehiculo = vehiculo;
            HoraEntrada = horaEntrada;
            HoraSalida = horaSalida;

            DuracionMin= (int)(horaSalida-horaEntrada).TotalMinutes;
            if (DuracionMin < 0) {
                DuracionMin += 24 * 60;
            }
            (Subtotal, Ahorro) = vehiculo.CalcularCosto(DuracionMin);
            //Iva = Subtotal * 0.19;
            Total = Subtotal + (Subtotal * 0.19);

        }
        public void Imprimir()
        {
            Console.WriteLine("\n=== FACTURA ===");
            Console.WriteLine($"Cliente: {Cliente.Nombre}");
            Console.WriteLine($"Placa: {Cliente.Placa}");
            Console.WriteLine($"Vehículo: {Vehiculo.Tipo} - {Vehiculo.SubTipo}");
            Console.WriteLine($"Entrada: {HoraEntrada:HH:mm}");
            Console.WriteLine($"Salida: {HoraSalida:HH:mm}");
            Console.WriteLine($"Duración: {DuracionMin} min");
            Console.WriteLine($"Subtotal: ${Subtotal:0.00}");
            Console.WriteLine($"Ahorro: ${Ahorro:0.00}");
            Console.WriteLine($"IVA (19%): ${Iva:0.00}");
            Console.WriteLine($"TOTAL: ${Total:0.00}");

        }
    }
}
