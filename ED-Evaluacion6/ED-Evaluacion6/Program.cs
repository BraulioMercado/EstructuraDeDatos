using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion6
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

                    Console.Write("¿Cuantos numeros desea ingresar? ");
                    Nnum = Convert.ToInt32(Console.ReadLine());
                    double[] valores = new double[Nnum];

                    for (contador = 0; contador < Nnum; contador++)
                    {
                        Console.Write("Ingrese valor {0}: ", (contador + 1));
                        valores[contador] = Convert.ToDouble(Console.ReadLine());
                    }
                    if (contador==0)
                    {
                        Console.Write("\n\nEl orden es no decreciente por lo tanto el indice es de: {0}", contador);
                    }
                    else
                    {
                        Console.Write("\n\nEl indice del primer elemento mayor que su predecesor es: {0}", (contador + 1));
                    }
                    ban = false;
                }
                catch (Exception e)
                {

                    Console.WriteLine("Valor no valido" + e.Message);
                }
            } while (ban == true);
            Console.ReadKey();
        }
    }
}
