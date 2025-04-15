using System;

namespace Cronómetro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cronometro cronometro = new Cronometro();
            for(int i = 0; i < 10; i++)
            {
                cronometro.incrementar_Tiempo();
            }
            cronometro.mostrar_Tiempo();
        }
    }

    public class Cronometro
    {
        public int segundos = 0;
        public int minutos = 0;

        public void incrementar_Tiempo()
        {
            segundos++;
            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }   
        }
        public void reiniciar_Tiempo()
        {
            segundos = 0;
            minutos = 0;
        }
        public void mostrar_Tiempo()
        {
            Console.WriteLine("Tiempo: " + minutos + ":" + segundos);
        }
    }
}
