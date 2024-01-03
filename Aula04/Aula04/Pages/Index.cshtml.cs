using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Aula04.Pages
{
    public class IndexModel : PageModel
    {
        public String Title { get; set; }
        public void OnGet()
        {
            Title = "Veio da PageModel";
        }
    }
}
