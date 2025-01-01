using Microsoft.AspNetCore.Mvc;
using Football.Services.Interfaces;

namespace Football.Controllers;

public class HomeController : Controller
{
    private readonly IFootballService _footbalService;

    public HomeController(IFootballService footbalService)
    {
        _footbalService = footbalService;
    }

    public async Task<IActionResult> Index()
    {
        var matches = await _footbalService.GetMatches();
        return View(matches);
    }
}
