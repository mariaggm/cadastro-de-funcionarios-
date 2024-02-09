namespace CadastroFuncionarios.Models
{
    public class Cliente : Pessoa 
    {
        public int ClienteId { get; set; }
        public string Estado { get; set; }
        public string Cidade  { get; set;}
    }
}
