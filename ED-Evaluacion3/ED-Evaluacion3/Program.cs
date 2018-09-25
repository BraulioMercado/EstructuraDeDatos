using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            do
            {
                try
                {
                    int contador = 0;
                    int Nnum = 0;
                    double OcMayor = 0;
                    int Posicion = 0;

                    Console.Write("¿Cuantos numeros desea ingresar? ");
                    Nnum = Convert.ToInt32(Console.ReadLine());
                    double[] valores = new double[Nnum];

                    for (contador = 0; contador < Nnum; contador++)
                    {
                        Console.Write("Ingrese valor {0}: ", (contador + 1));
                        valores[contador] = Convert.ToDouble(Console.ReadLine());
                    }
                    OcMayor = valores.Max();
                    Posicion = valores.ToList().LastIndexOf(valores.Max());
                    Console.WriteLine("El valor de la ultima ocurrencia mayor es {0} y su posicion es {1}.", OcMayor, Posicion + 1);
                    ban = false;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Valor no valido" + e.Message);
                } 
            } while (ban==true);
            Console.ReadKey();
        }
    }
}
