using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ConsoleAppNominaoo08
{
    public interface IInmueble
    {
        int Casa { get; }
        double PorcentajeGanancia { get; }
        double FormulaVenta();
    }

    public class Inmueble : IInmueble
    {
        public int Casa { get; private set; }
        public double AreaTerreno { get; private set; }
        public double CostoPorMetroCuadrado {  get; private set; }
        public double CostoInfraestructura {  get; private set; }
        public double PorcentajeGanancia { get; private set; }

        public Inmueble(int casa, double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentajeGanancia)
        {
            Casa = casa;
            AreaTerreno = areaTerreno;
            CostoPorMetroCuadrado = costoPorMetroCuadrado;
            CostoInfraestructura = costoInfraestructura;
            PorcentajeGanancia = porcentajeGanancia;
        }

        public double FormulaVenta()
        {
            double valorTerreno, valorTotal, ganancia, precioVenta;
            PorcentajeGanancia /= 100;
            valorTerreno = AreaTerreno * CostoPorMetroCuadrado;
            valorTotal = valorTerreno + CostoInfraestructura;
            ganancia = valorTotal * PorcentajeGanancia;
            precioVenta = valorTotal + ganancia;
            return precioVenta;
        }
    }

    public class CoordinadoVenta
    {
        private string connectionString = "Server=localhost;Database=bdnomina08;User ID=root;Password=3216417337;";

        // Método para agregar empleado a la base de datos
        public void AgregarInmueble(IInmueble inmueble)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO inmueble (casa, areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia) VALUES (@casa, @areaTerreno, @costoPorMetroCuadrado, @costoInfraestructura, @porcentajeGanancia)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@casa", inmueble.Casa);
                    command.Parameters.AddWithValue("@areaTerreno", ((Inmueble)inmueble).AreaTerreno);
                    command.Parameters.AddWithValue("@costoPorMetroCuadrado", ((Inmueble)inmueble).CostoPorMetroCuadrado);
                    command.Parameters.AddWithValue("@costoInfraestructura", ((Inmueble)inmueble).CostoInfraestructura);
                    command.Parameters.AddWithValue("@porcentajeGanancia", inmueble.PorcentajeGanancia);


                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para calcular la nómina total desde la base de datos
        public double FormulaVentaTotal()
        {
            double total = 0;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia FROM inmueble";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        double areaTerreno = reader.GetDouble("areaTerreno");
                        double costoPorMetroCuadrado = reader.GetDouble("costoPorMetroCuadrado");
                        double costoInfraestructura = reader.GetDouble("costoInfraestructura");
                        double porcentajeGanancia = reader.GetDouble("porcentajeGanancia");

                        double valorTerreno, valorTotal, ganancia, precioVenta;

                        porcentajeGanancia /= 100;
                        valorTerreno = areaTerreno * costoPorMetroCuadrado;
                        valorTotal = valorTerreno + costoInfraestructura;
                        ganancia = valorTotal * porcentajeGanancia;
                        precioVenta = valorTotal + ganancia;

                        total += precioVenta;
                    }
                }
            }
            return total;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            CoordinadoVenta coordinadoVenta = new CoordinadoVenta();
            int numeroInmuebles;
            int casa = 0;

            Console.WriteLine("Digite el número de Inmuebles: ");
            numeroInmuebles = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeroInmuebles; i++)
            {
                ++casa;
                Console.WriteLine("Digite el área del terreno: ");
                double areaTerreno = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el costo por metro cuadrado: ");
                double costoPorMetroCuadrado = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el costo de la infraestructura: ");
                double costoInfraestructura = double.Parse(Console.ReadLine());

                Console.WriteLine("Digite el porcentaje de ganancia en (%): ");
                double porcentajeGanancia = double.Parse(Console.ReadLine());

                IInmueble inmueble = new Inmueble(casa, areaTerreno, costoPorMetroCuadrado, costoInfraestructura, porcentajeGanancia);
                coordinadoVenta.AgregarInmueble(inmueble);
            }

            Console.WriteLine("El valor total de los inmuebles es: " + coordinadoVenta.FormulaVentaTotal());
            Console.ReadKey(true);
        }
    }
}
