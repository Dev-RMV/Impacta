using Aula19_SalesWebMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula19_SalesWebMvc.Controllers
{
    public class SalesRecordController : Controller
    {
        public IActionResult Index()
        {
            List<SalesRecord> salesRecordList = new List<SalesRecord>();
            salesRecordList.Add(new SalesRecord { Id=1,Date=DateTime.Now,Amount=10000 });
            salesRecordList.Add(new SalesRecord { Id = 2, Date = DateTime.Now, Amount = 20000 });
            return View(salesRecordList);
        }
    }
}
