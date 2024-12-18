﻿using Microsoft.AspNetCore.Mvc;
using MVC.Models.Carros;

namespace MVC.Controllers
{
    public class CarrosController : Controller
    {
        static List<CarroModel> _Carros = new List<CarroModel>()
        {   new CarroModel(){id =1, Nome="corsa", Ano= 2000, Placa="abc123" },
            new CarroModel(){id =2, Nome="corsa", Ano= 2000, Placa="abc123" },
            new CarroModel(){id =3, Nome="corsa", Ano= 2000, Placa="abc123" },
            new CarroModel(){id =4, Nome="corsa", Ano= 2000, Placa="abc123" }

        };
        public IActionResult Index()
        {var model = new CarrosModel() { Carros = _Carros};
            return View(model);
        }
        public IActionResult Record(long id)
        {

            var carroAtual = _Carros.FirstOrDefault(carro => carro.id == id);

            return View(carroAtual);
        }
        [HttpPost]
        public IActionResult Salvar(CarroModel model)
        {
            var carros = _Carros.FirstOrDefault(i => i.id == model.id);
            carros.Nome = model.Nome;
            carros.Ano = model.Ano;
            carros.Placa = model.Placa;
            return RedirectToAction("Index");
        }

    }
}

