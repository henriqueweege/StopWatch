using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch.Helpers
{
    public static class StopWatchHelpers
    {
        private static void Start(int time)
        {
            var currentTime = 0;
            while (currentTime != time)
            {

                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime.ToString());
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado.");
            Thread.Sleep(2500);
            Menu();
        }

        public static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("S = segundo => 10s = 10 segundos");
            Console.WriteLine("M = minuto => 1m = 1 minuto");
            Console.WriteLine("0 = sair");

            Console.WriteLine("Por quanto tempo devo contar?");



            var data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm') multiplier = 60;

            if(time == 0) System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        private static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!!");
            Thread.Sleep(2500);

            Start(time);
        }

    }
}
