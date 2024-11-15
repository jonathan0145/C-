using System;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ConsoleAppBD
{
    public interface IEmpleado
    {
        string Identificacion { get; }
        string Nombre { get; }
        double CalcularSalario();
    }

    public class Empleado : IEmpleado
    {
        public string Identificacion { get; private set; }
        public string Nombre { get; private set; }
        public double HorasTrabajadas { get; private set; }
        public double SalarioPorHora { get; private set; }

        public Empleado(string identificacion, string nombre, double horasTrabajadas, double salarioPorHora)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            HorasTrabajadas = horasTrabajadas;
            SalarioPorHora = salarioPorHora;
        }

        public double CalcularSalario()
        {
            return HorasTrabajadas * SalarioPorHora;
        }
    }

    public class Nomina
    {
        private string connectionString = "Server=localhost;Database=nomina_08;User ID=root;Password=3216417337;";

        // Método para agregar empleado a la base de datos
        public void AgregarEmpleado(IEmpleado empleado)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Empleado (identificacion, nombre, horasTrabajadas, salarioPorHora) VALUES (@identificacion, @nombre, @horasTrabajadas, @SalarioPorHora)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@identificacion", empleado.Identificacion);
                    command.Parameters.AddWithValue("@nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@horasTrabajadas", ((Empleado)empleado).HorasTrabajadas);
                    command.Parameters.AddWithValue("@SalarioPorHora", ((Empleado)empleado).SalarioPorHora);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para calcular la nómina total desde la base de datos
        public double CalcularNominaTotal()
        {
            double total = 0;

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT horasTrabajadas, salarioPorHora FROM Empleado";

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

    public class Programa
    {
        public static void Main(string[] args)
        {
            Nomina nomina = new Nomina();
            int numeroEmpleados;

            Console.WriteLine("Digite el número de empleados: ");
            numeroEmpleados = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < numeroEmpleados; i++)
            {
                Console.WriteLine("Digite la identificación del empleado: ");
                string identificacion = Console.ReadLine();
                Console.WriteLine("Digite el nombre del empleado: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Digite las horas trabajadas del empleado: ");
                double horas = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el salario por hora del empleado: ");
                double salario = Double.Parse(Console.ReadLine());

                IEmpleado empleado = new Empleado(identificacion, nombre, horas, salario);
                nomina.AgregarEmpleado(empleado);
            }

            Console.WriteLine("El valor de la nómina es: " + nomina.CalcularNominaTotal());
            Console.ReadKey(true);
        }
    }
}

