using Microsoft.AspNetCore.Mvc;

namespace SistemaDeControle.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Aluno()
        {
            return View();
        }
    }
}
