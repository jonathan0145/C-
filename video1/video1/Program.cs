using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            /*que nombre ponerle al objeto?*/
            Cerveza cerveza = new Cerveza(5, 6.5M, 10); /*nombre de la clase, nombre del objeto, new crear algo, constructor este lleva el nombre de tu clase este se puede crear tambien*/

            cerveza.Fermentacion();
        }
    }
}
