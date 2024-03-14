using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Chess.Models;
using System.Text.Json;

namespace Chess.Controllers;

public class HomeController : Controller  {

    private readonly ILogger<HomeController> _logger;

    private List<Players> getPlayers () {

        using StreamReader reader = new ("Data\\players.json");
        string data = reader.ReadToEnd();

        return JsonSerializer.Deserialize<List<Players>>(data);    
    }

    private List<Years> getYears () {

        using StreamReader reader = new ("Data\\years.json");
        string data = reader.ReadToEnd();

        return JsonSerializer.Deserialize<List<Years>>(data);    
    }

    public HomeController(ILogger<HomeController> logger) {
        _logger = logger;
    }

    public IActionResult Index() {

        List<Players> players = getPlayers();
        List<Years>   years   = getYears();

        ViewData["years"] = years;

        return View(players);
    }

    public IActionResult Details (int id) {

        List<Players> players = getPlayers();
        List<Years>   years   = getYears();

        DetailsVM details = new () {

            Years    = years,
            Current  = players.FirstOrDefault(p => p.Player_Id == id),
            Previous = players.OrderByDescending(p => p.Player_Id).FirstOrDefault(p => p.Player_Id < id),
            Next     = players.OrderBy(p => p.Player_Id).FirstOrDefault(p => p.Player_Id > id),
        };

        return View(details);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
