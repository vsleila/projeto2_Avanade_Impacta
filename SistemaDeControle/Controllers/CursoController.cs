using Microsoft.AspNetCore.Mvc;

namespace SistemaDeControle.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Curso()
        {
            return View();
        }
    }
}
