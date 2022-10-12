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

    class ImplementaIDisposable : IDisposable
    {
        public void Dispose()
        {
            
        }

        public override string ToString()
        {
            return "ImplementaIDisposable";
        }
    }

    class MelhoriaEmSobrecargaDeMetodoGenerico
    {
        public void TestaMelhoria()
        {
            short numero = 1;
            EscreveMensagem("Mensagem", numero);
            EscreveMensagem("Mensagem", 2);
            EscreveMensagem("Mensagem", 3);
            EscreveMensagem(new ImplementaIDisposable(), 10);
        }

        public void EscreveMensagem<T>(T objeto, short numero)
        {
            for (short i = 0; i < numero; i++)
            {
                Console.WriteLine(objeto);
            }
        }

        public void EscreveMensagem<T>(T objeto, int numero) where T : IDisposable
        {
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(objeto);
            }
        }

        public void EscreveMensagem<T>(T objeto, double numero)
        {
            for (double i = 0; i < numero; i++)
            {
                Console.WriteLine(objeto);
            }
        }
    }

    class MelhoriaEmSobrecargaDeDelegates
    {
        public void Teste()
        {
            TestaDelegate(int.Parse);
            TestaDelegate(EscreveMensagem);
        }

        public void TestaDelegate(Func<string, int> func) =>
            Console.WriteLine("Func<string, int>");

        public void TestaDelegate(Action<string> action) =>
            Console.WriteLine("Action<string>");

        public void EscreveMensagem(string a) => Console.WriteLine(a);
    }
}
