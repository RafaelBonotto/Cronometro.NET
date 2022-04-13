using System;
using System.Threading;

namespace Cronometro
{
    public class Start
    {
        public void Iniciar(int tempo)
        {
            int currentTime = 0;
            while (currentTime != tempo)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Tools tools = new();
            tools.Menu();
        }
    }
}
