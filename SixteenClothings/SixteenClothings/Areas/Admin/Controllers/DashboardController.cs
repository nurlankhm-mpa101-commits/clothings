using Microsoft.AspNetCore.Mvc;

namespace SixteenClothings.Areas.Admin.Controllers;
[Area("Admin")]

public class DashboardController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}