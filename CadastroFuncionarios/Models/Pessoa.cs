using Microsoft.Extensions.Primitives;

namespace CadastroFuncionarios.Models
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Esexo Sexo { get; set; }

    }
    public enum Esexo 
    {
        Masculino = 1, 
        Feminino = 2,
    }

}
