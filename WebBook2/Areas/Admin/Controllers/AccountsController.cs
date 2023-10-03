using Microsoft.AspNetCore.Mvc;

namespace WebBook2.Areas.Admin.Controllers
{
    public class AccountsController : Controller
    {
        [Area("Admin")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
