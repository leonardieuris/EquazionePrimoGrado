using System;
using System.Linq;

namespace EquazionePrimoGrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var calcolo = new CalcoloEquazione();
            var result = calcolo.Esegui(14, 74, 3);

            if (!result.Any())
            {
                Console.WriteLine("Non ci sono soluzioni");
            }
            else
            {
                foreach (var elemento in result)
                {

                    Console.WriteLine($"Questa è una soluzione: {elemento}");
                
                }
            }

            Console.WriteLine("Fine");
            Console.ReadLine();
        }
    }
}
