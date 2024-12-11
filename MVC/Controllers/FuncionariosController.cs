using Microsoft.AspNetCore.Mvc;
using MVC.Models.Funcionarios;

namespace MVC.Controllers
{
    public class FuncionariosController : Controller
    {
        public List<FuncionarioModel> _Funcionario = new List<FuncionarioModel>()
        {
            new FuncionarioModel() { Id = 1, Nome = "Tiago", Cargo = "gerente", Salário = 1000.00 },
            new FuncionarioModel() { Id = 2, Nome = "Tiago", Cargo = "gerente", Salário = 1000.00 },
            new FuncionarioModel() { Id = 3, Nome = "Tiago", Cargo = "gerente", Salário = 1000.00 },
            new FuncionarioModel() { Id = 4, Nome = "Tiago", Cargo = "gerente", Salário = 1000.00 }
        };
        public IActionResult Index()
        {
            var model = new FuncionariosModel() { Funcionarios = _Funcionario };
            return View(model);
        }
        public IActionResult Record(long id)
        {

            var funcionarioAtual = _Funcionario.FirstOrDefault(funcionario => funcionario.Id == id);

            return View(funcionarioAtual);
        }

        [HttpPost]
        public IActionResult Salvar(FuncionarioModel model)
        {
            var func = _Funcionario.FirstOrDefault(i => i.Id == model.Id);
            func.Nome = model.Nome;
            func.Cargo = model.Cargo;
            func.Salário = model.Salário;
            return RedirectToAction("Index");
        }
    }
}


   

