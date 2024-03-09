using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chess.Models;
using System.Text.Json;

namespace Chess.Controllers;

public class HomeController : Controller  {

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public IActionResult Index() {

        List<Players> players = [];

        using (StreamReader reader = new ("Data\\players.json")) {

            string data = reader.ReadToEnd();
            players = JsonSerializer.Deserialize<List<Players>>(data);
        }

        return View(players);
    }

    public IActionResult Privacy() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
