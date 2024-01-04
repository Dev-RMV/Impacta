using Microsoft.AspNetCore.Mvc;

namespace Aula05_SisCad.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
