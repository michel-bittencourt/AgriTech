using AgriTech.Models;
using AgriTech.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgriTech.Controllers;
public class PlantacaoController : Controller
{
    private readonly PlantacaoService _PlantacaoService;

    public PlantacaoController(PlantacaoService plantacaoService)
    {
        _PlantacaoService = plantacaoService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Create()
    {
        return View();
    }
}
