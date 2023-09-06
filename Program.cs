using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem03_Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string categoria;
            int dias;
            double monto, precio1, precio2;

            Console.WriteLine("\tAgencia turística 'Volemos juntos'");
            Console.WriteLine("\t++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("Categoría\t\tClave\n");
            Console.WriteLine("Tres estrellas..........(tres)");
            Console.WriteLine("Cinco estrellas.........(cinco)\n");
            Console.Write("Inserte la clave de su preferencia:");
            categoria = Console.ReadLine();
            Console.Write("¿Cuántos días se hospedará?: ");
            dias = int.Parse(Console.ReadLine());

            if (dias > 0)
            {
                if (dias <= 5)
                {
                    precio1 = 100;
                    precio2 = 300;
                }
                else if (dias <= 10)
                {
                    precio1 = 85;
                    precio2 = 270;
                }
                else 
                {
                    precio1 = 70;
                    precio2 = 250;
                }
            }
            else
            {
                Console.WriteLine("¡Error! Debe ingresar una cantidad de días válida (mayor a cero)");
                Console.ReadKey();
                return;
            }
            switch (categoria.ToLower())
            {
                case "tres":
                    monto = dias * precio1;
                    break;
                case "cinco":
                    monto = dias * precio2;
                    break;
                default:
                    {
                        Console.WriteLine("¡Error! Debe colocar una clave del menú");
                        Console.ReadKey();
                    }
                    return;
            }
            monto = dias * 7 + monto;

            Console.WriteLine("Por hospedarse {0} días debe pagar: S/. {1}", dias, monto.ToString("N2"));
            Console.ReadKey();
        }
    }
}
