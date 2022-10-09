using System;

namespace CSharp73_novidades
{
    static class TesteTuples
    {
        public static void TestaIgualdade()
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

        public static void TestaIgualdade2()
        {
            var origem = (rua: "Avenida Paulista", numero: 900, cidade: "São Paulo");
            var destino = (rua: "Avenida Paulista", numero: 900, cidade: "São Paulo");

            // Ao realizar a comparação é levado em consideração a ordem os valores da tupla
            // Caso o valor de rua não esteja na mesma posição da outra tupla, será retornado False na comparação

            // Caso o tipo dos valores da tupla esteja em uma ordem diferente, é exibido um aviso do compilador.

            Console.WriteLine(origem == destino);
        }

        public static void MaisAlgunsCasos()
        {
            var ehIgual = (nome: "Pedro", idade: 15) == (nome: "Maria", idade: 12);
            Console.WriteLine(ehIgual);

            (string, int) pedro = (nome: "Pedro", idade: 15);
            (object, int?) maria = (nome: "Maria", idade: null);
            Console.WriteLine(pedro == maria);
        }
    }
}
