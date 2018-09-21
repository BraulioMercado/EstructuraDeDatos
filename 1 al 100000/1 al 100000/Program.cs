using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_al_100000
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tiempo1 = DateTime.Now;

            int Cont = 0;
            double suma = 0;

            for (Cont = 1; Cont <= 1000000; Cont++)
            {
                suma = suma + Cont;
            }
            Console.WriteLine("la suma de los numeros es: " + suma);

            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("TIEMPO: " + total.ToString());
            Console.ReadKey();
        }
    }
}
