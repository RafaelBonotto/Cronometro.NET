using System;
using System.Threading;

namespace Cronometro
{
    public class PreStart
    {
        public void PreInicio(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);
            Start start = new();
            start.Iniciar(time);
        }
    }
}
