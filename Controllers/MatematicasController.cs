using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

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
        public IActionResult SumarNumerosForm(int num1, int num2)
        {
            ViewBag.Resultado = num1 + " + " + num2 + " = " + (num1 + num2);
            return View();
        }

        public IActionResult Collatz()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Collatz(int numero)
        {
            List<int> numeros = new List<int>();
            while (numero != 1)
            {
                if (numero % 2 == 0)
                {
                    numero = numero / 2;
                }
                else
                {
                    numero = (numero * 3) + 1;
                }
                numeros.Add(numero);
            }
            return View(numeros);
        }

        public IActionResult Multiplicar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Multiplicar(int numero)
        {
            List<int> resultado = new List<int>();
            for (int i = 0; i < 11; i++)
            {
                resultado.Add(numero * i);
            }
            return View(resultado);
        }
    }
}
