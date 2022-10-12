using System;
using System.Text;

namespace CSharp73_novidades
{
    class DeInstanciaOuEstatico
    {
        public void TestaSobreCarga()
        {
            this.EscreveMensagem(null);
            DeInstanciaOuEstatico.EscreveMensagem(null);
        }

        public void EscreveMensagem(StringBuilder stringBuilder)
        {
            Console.WriteLine(stringBuilder);
        }

        public static void EscreveMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
