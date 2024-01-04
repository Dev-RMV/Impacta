using Microsoft.AspNetCore.Mvc;

namespace Aula05_SisCad.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
