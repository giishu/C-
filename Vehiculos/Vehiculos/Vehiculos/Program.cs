using System;

namespace Vehiculos
{
    interface IVehiculos
    {
        int mover(int tiempo);
        void posicion();
        void reiniciarPosicion();
    }

    public class Bicicletas : IVehiculos
    {
        public const int limite = 10;
        public int pos_act = 0;

        public int mover(int tiempo)
        {
            pos_act += tiempo * limite;
            return tiempo * limite;
        }

        public void posicion()
        {
            Console.WriteLine(pos_act);
        }

        public void reiniciarPosicion()
        {
            pos_act = 0;
        }
    }

    public class Camiones : IVehiculos
    {
        public const int limite = 30;
        public int pos_act = 0;

        public int mover(int tiempo)
        {
            pos_act += tiempo * limite;
            return tiempo * limite;
        }

        public void posicion()
        {
            Console.WriteLine(pos_act);
        }

        public void reiniciarPosicion()
        {
            pos_act = 0;
        }
    }

    public class Auto : IVehiculos
    {
        public int pos_act = 0;
        public int limite;

        public Auto(int v_max)
        {
            limite = v_max;
        }

        public int mover(int tiempo)
        {
            pos_act += tiempo * limite;
            return tiempo * limite;
        }

        public void posicion()
        {
            Console.WriteLine(pos_act);
        }

        public void reiniciarPosicion()
        {
            pos_act = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

