using Microsoft.AspNetCore.Mvc;

namespace Controle_de_vendas.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
