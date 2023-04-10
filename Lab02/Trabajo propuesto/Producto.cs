using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.Trabajo_propuesto
{
    using System;

    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public DateTime FechaVenci { get; set; }
        public string Descrip { get; set; }

        public bool EstaVencido()
        {
            return DateTime.Now < FechaVenci;
        }

        public double PrecioVenta()
        {
            double igv = Precio * 0.18;
            return Precio + igv;
        }
        public void DevolverNombresCompletos()
        {
            Console.WriteLine("\nNombre de Producto:  " + Nombre + "\nDescripción:  " + Descrip + "\n"  );
        }
    }
}
