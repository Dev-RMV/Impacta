using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Aula05.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int numTimes=1)
        {
            return HtmlEncoder.Default.Encode($"Ola {name}, esta e sua visita: {numTimes}");
        }
    }
}
