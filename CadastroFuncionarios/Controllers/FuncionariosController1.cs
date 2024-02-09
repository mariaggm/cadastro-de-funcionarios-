using CadastroFuncionarios.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastroFuncionarios.Controllers
{
    public class FuncionariosController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListaFuncionarios() 
        { 
            return View(ListaDeFuncionarios());
        }
        private List<Funcionarios> ListaDeFuncionarios() 
        {
            Funcionarios funcionario = new Funcionarios();
            funcionario.Nome = "Ana";
            funcionario.Idade = 25;
            funcionario.Departamento = EDepartamento.TI;
            funcionario.Sexo = Esexo.Feminino;
            funcionario.Cargo = "secretaria";
            funcionario.PessoaID = 1;
            funcionario.FuncionariosId = 1;

            var list = new List<Funcionarios>();
            list.Add(funcionario);
            return list; 
        }

    }
}
