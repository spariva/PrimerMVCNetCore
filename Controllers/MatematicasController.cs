using Microsoft.AspNetCore.Mvc;

namespace PrimerMVCNetCore.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SumarNumerosGet(int? num1, int? num2)
        {   
            if (num1 != null && num2 != null)
            {
                string operation = num1.ToString() + " + " + num2.ToString() + "= ";
                ViewData["Resultado"] = operation + (num1 + num2);
            }
            else
            {
                ViewData["Resultado"] = "No hay números para sumar";
            }
            return View();
        }
        
        public IActionResult SumarNumerosForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SumarNumerosForm(int num1, int num2) {
            ViewBag.Resultado = num1 + " + " + num2 + " = " + (num1 + num2);
            return View();
        }
    }
}
