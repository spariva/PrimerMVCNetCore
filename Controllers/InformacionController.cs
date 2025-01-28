using Microsoft.AspNetCore.Mvc;
using PrimerMVCNetCore.Models;

namespace PrimerMVCNetCore.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista()
        {
            ViewData["Nombre"] = "Alumno";
            ViewData["Apellido"] = "Apellido";
            ViewBag.DiaSemana = "Lunes";
            return View();
        }

        public IActionResult ControladorVistaModel()
        {
            Persona persona = new Persona();
            persona.Nombre = "Maki Spariva";
            persona.Email = "a@z.com";
            persona.Edad = 25;
            return View( persona );
        }

        public IActionResult VistaControllerGet(string saludo, int year)
        {
            if (saludo != null)
            {
                ViewBag.Data = "Hola " + saludo + " y año: " + year;
            }
            else {
                ViewBag.Data = "No hay saludo, solo días... =(";
            }
            return View();
        }

        public IActionResult VistaControllerPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaControllerPost(Persona persona, string aficiones)
        {
            ViewBag.Data = "Nombre: " + persona.Nombre + " Edad: " + persona.Email + " Edad: " + persona.Edad
                + "aficiones " + aficiones;
            return View();
        }
    }
}
