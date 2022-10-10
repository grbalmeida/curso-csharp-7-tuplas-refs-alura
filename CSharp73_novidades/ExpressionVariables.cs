using System;

namespace CSharp73_novidades
{
    class AplicacaoWeb
    {
        public static string Porta = "8080";

        public static bool EstaRodandoEmPortaAlta =
            int.TryParse(Porta, out int portaComoInt) && portaComoInt > 1024;
    }

    class ExpressionVariables
    {
        public static bool ValidaIdade(string idadeComoTexto) =>
            int.TryParse(idadeComoTexto, out int idade) && idade > 18;

        public static void TestaExpressionVariables()
        {
            var idadeComoTexto = "15";

            if (ValidaIdade(idadeComoTexto))
            {
                Console.WriteLine("Você pode entrar");
            }
        }
    }
}
