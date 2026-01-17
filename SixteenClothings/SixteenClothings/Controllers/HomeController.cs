using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SixteenClothings.Models;

namespace SixteenClothings.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}