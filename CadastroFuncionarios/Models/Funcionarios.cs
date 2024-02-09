namespace CadastroFuncionarios.Models
{
    public class Funcionarios : Pessoa 
    {
         public int FuncionariosId { get; set; }
         public string Cargo { get; set; }
         public decimal Salario { get; set; }
         public EDepartamento Departamento { get; set; }

    }
    public enum EDepartamento
    {
        Publicidade = 1,
        TI = 2,
        Juritico = 3,
        Outros = 4,

    }
}
