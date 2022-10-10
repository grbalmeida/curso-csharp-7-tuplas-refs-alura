using System;

namespace CSharp73_novidades
{
    class ReatribuicaoEmRefs
    {
        public static void TestaRefs()
        {
            var numeros = new[] { 1, 3, 7, 15, 31, 1023, 63, 127, 255, 511 };
            EscreverNumeros(numeros);

            ref var maiorValor = ref ObterMaiorValor(numeros);
            Console.WriteLine($"Maior valor: {maiorValor}");

            maiorValor *= 2;
            Console.WriteLine($"Maior valor * 2: {maiorValor}");

            EscreverNumeros(numeros);
        }

        private static ref int ObterMaiorValor(int[] numeros)
        {
            ref var maior = ref numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maior)
                {
                    maior = ref numeros[i];
                }
            }

            return ref maior;
        }

        private static void EscreverNumeros(int[] numeros) =>
            Console.WriteLine(string.Join(",", numeros));
    }
}
