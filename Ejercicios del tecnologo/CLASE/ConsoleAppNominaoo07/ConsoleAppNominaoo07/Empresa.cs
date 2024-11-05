using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNominaoo07
{
    internal class Empresa
    {
        public static string Nit;
        public string Nombre {  get; private set; }
        public string Direccion {  get; private set; }

        private EmpleadoSueldoFijo[] empleados1;
        private EmpleadoXHora[] empleados2;
        private EmpleadoXComision[] empleados3;
        private int numeroEmpleados1 {  get; set; }
        private int numeroEmpleados2 { get; set; }
        private int numeroEmpleados3 {  get; set; }

        public Empresa(string nit, string nombre, string direccion)
        {
            Empresa.Nit = nit;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.empleados1 = new EmpleadoSueldoFijo[50];
            this.empleados2 = new EmpleadoXHora[50];
            this.empleados3 = new EmpleadoXComision[50];
            this.numeroEmpleados1 = 0;
            this.numeroEmpleados2 = 0;
            this.numeroEmpleados3 = 0;
        }

        public void adicionarEmpleadoSueldoFijo( string identificacion, string nombre, double sueldoFijo)
        {
            empleados1[numeroEmpleados1] = new EmpleadoSueldoFijo(identificacion, nombre, sueldoFijo);
            numeroEmpleados1++;
        }

        public void adicionarEmpleadoSueldoXHora(string identificacion, string nombre, double horasTrabajadas, double sueldoXHora )
        {
            empleados2[numeroEmpleados2] = new EmpleadoXHora(identificacion,nombre,horasTrabajadas, sueldoXHora);
            numeroEmpleados2++;
        }

        public void adicionarEmpleadoSueldoXComision(string identificacion, string nombre, double sueldoBasico, double porcentaje, double ventasTotales)
        {
            empleados3[numeroEmpleados3] = new EmpleadoXComision(identificacion, nombre, sueldoBasico, porcentaje, ventasTotales);
            numeroEmpleados3++;
        }

        public double calcularNominaTotal()
        {
            double total = 0;
            for (int i = 0; i < numeroEmpleados1; i++)
            {
                total = total + empleados1[i].CalcularSalario();

            }
            for (int i = 0; i < numeroEmpleados2; i++)
            {
                total = total + empleados2[i].CalcularSalario();
            }
            for (int i = 0; i < numeroEmpleados3; i++)
            {
                total = total + empleados3[i].CalcularSalario();
            }
            return total;
        }

    }
}
