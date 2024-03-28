using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos las variables

            Console.Write("Ingrese el tamaño del paso (h): "); // Tamaño de los pasos
            double h = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor inicial de x (x0): "); // Valor inicial de x
            double x0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el valor inicial de y (y0): "); // Valor inicial de y
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el número de iteraciones: "); // Valor de la interacion
            int numIteraciones = Convert.ToInt32(Console.ReadLine());

            double x = x0; //valor de x con x0

            double y = y0; //valor de y con y0

            for (int i = 0; i < numIteraciones; i++) 
            {
                // Calcula el valor de k1 usando la función y el valor de y
                double k1 = h * Funcion(x, y);

                // Calcula el valor de k2 usando la función y el valor de y estimado con k1
                double k2 = h * Funcion(x + h, y + k1);

                // Calcula el nuevo valor de y usando k1 y k2
                y = y + (k1 + k2) / 2;

                // Incrementar el valor de x en h
                x = x + h;

                // muestra el valor de x y el valor de y con la iteración proporcionada
                Console.WriteLine($"x = {x}, y = {y}");
            }
        }
        //Función que describe la ecuación diferencial 
        static double Funcion(double x, double y)
        {
            // Aquí regresa la función f(x, y) ya definida
            return x + y; 
        }
     
    }
} 
// Juan Carlos Salazar Valenzuela
// I302020047
