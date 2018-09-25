using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Evaluacion8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            do
            {
                int palindromo = 0;
                Console.Write("Ingrese numero de 5 digitos: ");
                palindromo = int.Parse(Console.ReadLine());
                if (palindromo >= 10000 && palindromo <= 99999)
                {
                    if(palindromo.ToString()[0]==palindromo.ToString()[4] && palindromo.ToString()[1]==palindromo.ToString()[3])
                    {
                        Console.Write("Es palindromo");
                    }
                    else
                    {
                        Console.Write("No es palindromo");
                    }
                    ban = false;

                }
                else
                {
                    Console.Write("No es un numero de 5 digitos.\n");
                }
            }
            while (ban == true);

            Console.ReadKey();
        }
    }
}
