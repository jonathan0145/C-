using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video1 /*agrupar en paquetes*/
{
    public class Cerveza/*que es internal*/
    {
        /*atributos*/
        public int Amargor {  get; set; }/*otorgar un valor obtener un valor ¿como usarlo correctamente?*/
        public decimal Alcohol {  get; set; }
        public int TiempoFermentacion { get; set; }

        /*creando mi constructor*/
        public Cerveza(int Amargor, decimal Alcohol, int TiempoFermentacion)
        {
            this.Amargor = Amargor; /*por que se hace esto*/
            this.Alcohol = Alcohol;
            this.TiempoFermentacion = TiempoFermentacion;
        }

        /*metodos*/
        public void Fermentacion()
        {
            for (int i = 0; i < TiempoFermentacion; i++)
            {
            Console.WriteLine("Se fermento con un amargor de: " + Amargor + " un porcentaje de alcohol del: " + Alcohol);              
            }
        }
    }
}
