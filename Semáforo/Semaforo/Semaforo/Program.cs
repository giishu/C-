using System;

namespace Semaforo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Semaforo semaforo = new Semaforo("Rojo");

            for (int i = 0; i < 40; i++)
            {
                semaforo.paso_Del_Tiempo(1);
                Console.WriteLine($"Tiempo: {i + 1} segundos, Color: {semaforo.mostrar_Color()}");
            }
        }
    }

    public class Semaforo
    {
        public string color_actual;
        public int tiempo_actual;
        public bool intermitente;
        public bool amarillo_int;

        public Semaforo(string color_inicial)
        {
            color_actual = color_inicial;
            tiempo_actual = 0;
            intermitente = false;
            amarillo_int = true;
        }

        public void paso_Del_Tiempo(int segundos)
        {
            if (intermitente)
            {
                if (segundos > 0)
                {
                    amarillo_int = !amarillo_int;
                }
                return;
            }
            tiempo_actual += segundos;

            int tiempo = tiempo_actual % 54;

            if (tiempo < 30)
                color_actual = "Rojo";
            else if(tiempo < 32)
                color_actual = "Rojo-Amarillo";
            else if (tiempo < 52)
                color_actual = "Verde";
            else
                color_actual = "Amarillo";
        }

        public string mostrar_Color()
        {
            if (intermitente)
            {
                if(amarillo_int)
                    return "Amarillo Intermitente";
                else
                    return "Apagado";   
            }
            else
            {
                return color_actual;
            }   
        }
        public void poner_En_Intermitente()
        {
            intermitente = true;
        }
        public void quitar_Intermitente()
        {
            intermitente = false;
            color_actual = "Rojo";
            tiempo_actual = 0;
        }
    }
}
