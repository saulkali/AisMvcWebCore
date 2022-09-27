using Microsoft.AspNetCore.Mvc;
using Negocio;

namespace AisWebCore.Controllers
{

    public class CalculadoraController : Controller
    {
        NCalculadora nCalculadora = new NCalculadora();
        

        public IActionResult Index()
        {
            if (TempData["resultado"] != null)
                ViewBag.resultado = TempData["resultado"];
            return View();
        }

        [HttpPost]
        public IActionResult Factorial(IFormCollection form)
        {
            string? numeroStr = form["number"];
            if (numeroStr == null)
                ViewBag.error = "ingrese un numero valido";
            try
            {
                int numero = Convert.ToInt32(numeroStr);
                TempData["resultado"] = nCalculadora.Factorial(numero);
            }
            catch
            {
                ViewBag.error = "ingrese un numero valido";
            }

            return RedirectToAction("Index");
        }


    }
}
