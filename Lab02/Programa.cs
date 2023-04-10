using Lab02.Trabajo_propuesto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Programa
    {
        static void Main(string[] args)
        {


            Producto Lista = new Producto();
            Lista.Nombre = "Queso Parmesano";
            Lista.Precio = 100;
            Lista.FechaVenci = new DateTime(1999, 7, 12);
            Lista.Descrip = "1 kilo traido desde Italia";

            /* EJERCICIO PROPUESTO
             
             
                if (Lista.EstaVencido())
            {
                Console.WriteLine("El producto no está vencido");

                double precioVenta = Lista.PrecioVenta();
                Lista.DevolverNombresCompletos();
                Console.WriteLine("El precio de venta del producto es: " + precioVenta);
            }
            else
            {
                Console.WriteLine("El producto está vencido"+"\n"+"Venta no Permitida");
            }*/


            Console.Write("Coordenada del punto X 1: ");

            double X1 = double.Parse(Console.ReadLine());

            Console.Write("Coordenada del punto Y 1: ");

            double Y1 = double.Parse(Console.ReadLine());

            Console.Write("Coordenada del punto X 2: ");

            double X2 = double.Parse(Console.ReadLine());

            Console.Write("Coordenada del punto Y 2: ");

            double Y2 = double.Parse(Console.ReadLine());

            /* Ancho y la altura del rectángulo */
            double basex = Math.Abs(X2 - X1);
            double altura = Math.Abs(Y2 - Y1);

            /*Calcular el area y perimetro del Rectangulo */
            double perimetro = 2 * (basex + altura);
            double area = basex * altura;

            Console.WriteLine("\n"+"La base del rectángulo: " + basex + "\n");
            Console.WriteLine("La altura del rectángulo: " + altura + "\n" );


            Console.WriteLine("El perímetro del rectángulo es: " + perimetro + "\n");
            Console.WriteLine("El área del rectángulo es: " + area + "\n");




        }
    }
}