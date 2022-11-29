using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEndProj.Classes
{
    public static class Utils
    {
        public static void barraCarregamento(string texto)
        {

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine(texto);
            Console.Write($"Tecle Enter para continuar....");

            for (int contador = 0; contador < 6; contador++)
            {
                Thread.Sleep(500);
                Console.Write($".");
            }

            Console.ResetColor();
        }
    }
}