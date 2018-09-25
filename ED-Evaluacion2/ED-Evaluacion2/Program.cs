using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion2
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
                    int largo;

                    Console.Write("Ingrese numero de valores de la secuencia: ");
                    largo = Convert.ToInt32(Console.ReadLine());
                    string[] valores = new string[largo];

                    for (contador = 0; contador < largo; contador++)
                    {
                        Console.Write("Ingrese valor {0}: ", (contador + 1));
                        valores[contador] = Console.ReadLine();
                    }
                    Array.Reverse(valores);
                    Console.Write("La sucesion invertida es:");
                    for (contador = 0; contador < largo; contador++)
                    {
                        Console.Write(valores[contador]);
                    }
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
