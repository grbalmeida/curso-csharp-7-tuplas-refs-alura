using System;

namespace CSharp73_novidades
{
    class Program
    {
        static void Main(string[] args)
        {
            //TesteTuples.TestaIgualdade();
            //TesteTuples.TestaIgualdade2();
            //TesteTuples.MaisAlgunsCasos();
            //ExpressionVariables.TestaExpressionVariables();
            //ExpressionVariables.RegistroDeAlunos();
            //ReatribuicaoEmRefs.TestaRefs();
            //ReatribuicaoEmRefs.TestaRefsForEach();
            //BackfieldAttribute.Testa();
            //var deInstanciaOuEstatico = new DeInstanciaOuEstatico();
            //deInstanciaOuEstatico.TestaSobreCarga();
            //var melhoriaEmSobrecargaDeMetodoGenerico = new MelhoriaEmSobrecargaDeMetodoGenerico();
            //melhoriaEmSobrecargaDeMetodoGenerico.TestaMelhoria();
            var melhoriaEmSobrecargaDeDelegates = new MelhoriaEmSobrecargaDeDelegates();
            melhoriaEmSobrecargaDeDelegates.Teste();
        }
    }
}
