using System;

namespace CSharp73_novidades
{
    static class TesteTuples
    {
        public static void TestaTuple()
        {
            var origem = ("Avenida Paulista", "900", "São Paulo");
            var destino = ("Avenida Paulista", "300", "São Paulo");

            // Comparação Tupla C# 7.2
            var mesmoLugar =
                origem.Item1 == destino.Item1 &&
                origem.Item2 == destino.Item2 &&
                origem.Item3 == destino.Item3;

            Console.WriteLine(mesmoLugar);

            // Comparação Tupla C# 7.3
            mesmoLugar = origem == destino;
            Console.WriteLine(mesmoLugar);
        }
    }
}
