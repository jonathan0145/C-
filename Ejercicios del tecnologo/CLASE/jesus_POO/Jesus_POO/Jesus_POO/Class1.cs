using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jesus_POO
{
    internal class Empleado
    {
        public string identificaciones{ get; set; }
        public string nombres { get; set; }
        public double horasTrabajadas { get; set; }
        public double salarioPorHora { get; set; }
        public double nominaMensual = 0;

        public double Formula()
        {
            nominaMensual = (horasTrabajadas * salarioPorHora);
            return nominaMensual;
        }
    }
}
