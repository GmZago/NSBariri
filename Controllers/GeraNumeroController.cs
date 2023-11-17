using Adivinha.Models;
using Microsoft.AspNetCore.Mvc;

namespace Adivinha.Controllers
{
    public class GeraNumeroController : Controller
    {
        private GeraNumero _model;

        public GeraNumeroController()
        {
            _model = new GeraNumero();
            _model.GenerateSecretNumber();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GeraNumero(int numerodigitado)
        {
            ViewBag.Feedback = "";

            if (numerodigitado == _model.NumeroSecreto)
            {
                ViewBag.Feedback = "Parabéns! Você acertou!";
                ViewBag.NumeroGerado = 0;
            }
            else if (numerodigitado < _model.NumeroSecreto)
            {
                ViewBag.Feedback = "Tente um número maior.";
            }
            else
            {
                ViewBag.Feedback = "Tente um número menor.";
            }

            return View("Index");
        }
    }
}
