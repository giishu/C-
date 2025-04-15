using System;

namespace JugadorCansado
{
    interface IJugador
    {
        bool correr(int minutos);
        bool cansado();
        void descansar(int minutos);
    }

    class Profesional : IJugador
    {
        public int minutos_corridos = 0;
        public const int limite = 40;

        public bool correr(int minutos)
        {
            if (minutos_corridos + minutos > limite)           
                return false;
            else
            {
                minutos_corridos += minutos;
                return true;
            }
        }
        public bool cansado()
        {
            return minutos_corridos >= limite;
        }
        public void descansar(int minutos)
        {
            if (minutos_corridos - minutos < 0)
                minutos_corridos = 0;
            else
                minutos_corridos -= minutos;
        }
    }

    class Amateur : IJugador
    {
        public int minutos_corridos = 0;
        public const int limite = 20;
        public bool correr(int minutos)
        {
            if (minutos_corridos + minutos > limite)
                return false;
            else
            {
                minutos_corridos += minutos;
                return true;
            }
        }
        public bool cansado()
        {
            return minutos_corridos >= limite;
        }
        public void descansar(int minutos)
        {
            if (minutos_corridos - minutos < 0)
                minutos_corridos = 0;
            else
                minutos_corridos -= minutos;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IJugador jugador1 = new Profesional();
            IJugador jugador2 = new Amateur();
        }
    }
}
