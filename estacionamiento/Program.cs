using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace estacionamiento
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Vehiculo vehiculo = null;
            System.Console.WriteLine("===PARQUEADERO===\n");

            System.Console.Write("Nombre de cliente: ");
            String nombre= System.Console.ReadLine();
            System.Console.WriteLine("Placa: ");
            String placa= System.Console.ReadLine();


            do {
                System.Console.WriteLine("\n Tipo de vehiculo");
                System.Console.WriteLine("1. Taxi (3500)");
                System.Console.WriteLine("2. Automóvil (4000)");
                System.Console.WriteLine("3. Campero (4500)");
                System.Console.WriteLine("4. Camioneta (5000)");
                System.Console.WriteLine("5. Moto (600)");
                System.Console.WriteLine("0. Para salir");
                op=Int32.Parse(System.Console.ReadLine());


                switch (op) {

                    case 1:
                        vehiculo  = new Carro("Taxi", 3500);
                        break;
                    case 2:
                        vehiculo  = new Carro("Automóvil", 4000);
                        break;
                    case 3:
                        vehiculo= new Carro("Campero", 4500);
                        break;
                    case 4:
                        vehiculo  = new Carro("Camioneta", 5000);
                        break;
                    case 5:
                        vehiculo  = new Moto();
                    break;
                    case 0:
                        System.Console.WriteLine("saliendo del sistema...");
                    break;
                    default:
                        System.Console.WriteLine("Opcion no valida");
                        break;
                    
                }
                
            }while(vehiculo==null);
            System.Console.ReadKey();

            System.Console.Write("Hora de entrada (HH:MM) ");
            DateTime entrada = DateTime.Parse(System.Console.ReadLine());

            System.Console.Write("Hora de salida(HH:MM) ");
            DateTime salida= DateTime.Parse(System.Console.ReadLine());

            Cliente cliente = new Cliente(nombre, placa);
            Factura factura = new Factura(cliente,vehiculo,entrada,salida);

            factura.Imprimir();
        }
    }
}
