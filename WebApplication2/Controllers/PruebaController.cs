using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Load()
        {
            PruebaModel model = new PruebaModel();
            model.id = 1;
            model.name = "Test";

            return PartialView("_DatosPersonales", model);
        }
    }
}