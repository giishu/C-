using System;

namespace Figura
{
    interface IFigura
    {
        float calcularArea();
        float calcularPerimetro();
    }

    public class Rectangulo : IFigura
    {
        public float baseRect;
        public float altura;

        public Rectangulo(float a, float b)
        {
            baseRect = a;
            altura = b;
        }

        public float calcularArea()
        {
            return baseRect * altura;
        }

        public float calcularPerimetro()
        {
            return (baseRect * 2) + (altura * 2);
        }
    }

    public class Cuadrado : IFigura
    {
        public float lado;

        public Cuadrado(float l)
        {
            lado = l;
        }

        public float calcularArea()
        {
            return lado * lado;
        }

        public float calcularPerimetro()
        {
            return lado * 4;
        }
    }

    public class Triangulo : IFigura // ✔️ ahora implementa IFigura
    {
        public float basa;
        public float altura;
        public float lado2;
        public float lado3;

        public Triangulo(float b, float a, float l2, float l3)
        {
            basa = b;
            altura = a;
            lado2 = l2;
            lado3 = l3;
        }

        public float calcularArea()
        {
            return (basa * altura) / 2;
        }

        public float calcularPerimetro()
        {
            return basa + lado2 + lado3;
        }
    }

    public class Circulo : IFigura
    {
        public static readonly float pi = 3.14159f;
        public float radio;

        public Circulo(float r)
        {
            radio = r;
        }

        public float calcularArea()
        {
            return pi * radio * radio;
        }

        public float calcularPerimetro()
        {
            return 2 * pi * radio;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuras = new IFigura[4];

            figuras[0] = new Rectangulo(9, 12);
            figuras[1] = new Cuadrado(9);
            figuras[2] = new Triangulo(19, 74, 20, 13);
            figuras[3] = new Circulo(9);

            for (int i = 0; i < figuras.Length; i++)
            {
                Console.WriteLine($"Figura {i + 1}:");
                Console.WriteLine($"Área: {figuras[i].calcularArea()}");
                Console.WriteLine($"Perímetro: {figuras[i].calcularPerimetro()}");
                Console.WriteLine();
            }
        }
    }
}
