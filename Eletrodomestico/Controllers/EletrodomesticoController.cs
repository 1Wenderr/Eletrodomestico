using Eletrodomestico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomestico.Controllers
{
    public class EletrodomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodomestico.Models.Eletrodomestico> eletrodomesticos = new List<Eletrodomestico.Models.Eletrodomestico>
            {
                new Geladeira {Marca = "Samsung", Modelo = "Side by Side", ConsumoEnergetico = 40, CapacidadeLitros = 500, TemFreezer = true },
                new Geladeira {Marca = "Brastemp", Modelo = "Frost Free", ConsumoEnergetico = 30, CapacidadeLitros = 435, TemFreezer = true },
                new Geladeira {Marca = "Consul", Modelo = "Frost Free", ConsumoEnergetico = 40, CapacidadeLitros = 443, TemFreezer = true },
                new Televisor {Marca = "Samsung", Modelo = "QLED Q60A", ConsumoEnergetico = 85, TamanhoTela = 50, EhSmart = true},
                new Televisor {Marca = "TCL", Modelo = "4K Smart TV", ConsumoEnergetico = 70, TamanhoTela = 43, EhSmart = true},
                new Televisor {Marca = "LG", Modelo = "OLED CX 4K Gaming", ConsumoEnergetico = 150, TamanhoTela = 55, EhSmart = false},
            };
            return View(eletrodomesticos);
        }
    }
}
