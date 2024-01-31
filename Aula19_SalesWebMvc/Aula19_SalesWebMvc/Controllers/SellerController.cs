using Aula19_SalesWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula19_SalesWebMvc.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            List<Seller> sellerList = new List<Seller>();
            sellerList.Add(new Seller { Id=1,Name="Vendedor1",Email="v1@vendas.com",BirthDate=DateTime.Now,BaseSalary=2000});
            sellerList.Add(new Seller { Id = 2, Name = "Vendedor2", Email = "v2@vendas.com", BirthDate = DateTime.Now, BaseSalary = 4000 });
            return View(sellerList);
        }
    }
}
