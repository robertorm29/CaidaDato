using CaidaDato.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CaidaDato.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalcularCaida(double valorInicial)
        {
            Random random = new Random();
            double porcentajeCaida = random.Next(5, 30); // Genera un porcentaje de caída entre 5% y 30%
            double valorFinal = valorInicial - (valorInicial * (porcentajeCaida / 100));
            int numeroAzar = random.Next(1, 100); // Genera un número aleatorio entre 1 y 100

            var model = new CaidaDatoModel
            {
                ValorInicial = valorInicial,
                ValorFinal = valorFinal,
                NumeroAzar = numeroAzar
            };

            return View("Resultado", model);
        }
    }
}