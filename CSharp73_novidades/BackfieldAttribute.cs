using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharp73_novidades
{
    [Serializable]
    public class FormularioCadastro
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        [field:NonSerialized]
        public string Senha { get; set; }
        
        //[NonSerialized]
        //private string _senha;

        //public string Senha
        //{
        //    get
        //    {
        //        return _senha;
        //    }

        //    set
        //    {
        //        _senha = value;
        //    }
        //}
    }

    class BackfieldAttribute
    {
        public static void Testa()
        {
            var novoCadastro = new FormularioCadastro
            {
                Nome = "Gui",
                Email = "gui@alura.com.br",
                Senha = "senha super dificil e complicada de lembrar"
            };

            using (var arquivo = File.Create("cadastro.bin"))
            {
                var formatador = new BinaryFormatter();
                formatador.Serialize(arquivo, novoCadastro);
            }
        }
    }
}
