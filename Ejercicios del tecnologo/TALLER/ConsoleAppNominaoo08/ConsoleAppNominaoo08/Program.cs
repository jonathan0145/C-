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
        public static int Casa { get; private set; }
        public double AreaTerreno { get; private set; }
        public double CostoPorMetroCuadrado {  get; private set; }
        public double CostoInfraestructura {  get; private set; }
        public double PorcentajeGanancia { get; private set; }

        public Inmueble(int casa, double areaTerreno, double costoPorMetroCuadrado, double costoInfraestructura, double porcentajeGanancia)
        {
            Inmueble.Casa = casa;
            AreaTerreno = areaTerreno;
            CostoPorMetroCuadrado = costoPorMetroCuadrado;
            CostoInfraestructura = costoInfraestructura;
            PorcentajeGanancia = porcentajeGanancia;
        }

        public double FormulaVenta()
        {
            double valorTerreno, valorTotal, ganancia, precioVenta;
            ++Casa;
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
                connection.Open();/*-----------------------------------------------------------------------aqui quede-------------------------------------------------------------*/
                string query = "SELECT horasTrabajadas, salarioPorHora FROM inmueble";

                using (var command = new MySqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        double horasTrabajadas = reader.GetDouble("horasTrabajadas");
                        double salarioPorHora = reader.GetDouble("salarioPorHora");
                        total += horasTrabajadas * salarioPorHora;
                    }
                }
            }
            return total;
        }
    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
