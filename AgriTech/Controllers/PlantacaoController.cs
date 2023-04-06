using AgriTech.Models;
using AgriTech.Services;
using Microsoft.AspNetCore.Mvc;

namespace AgriTech.Controllers;
public class PlantacaoController : Controller
{
    private readonly PlantacaoService _PlantacaoService;
    private readonly PlantaService _PlantaService;

    public PlantacaoController(PlantacaoService plantacaoService, PlantaService plantaService)
    {
        _PlantacaoService = plantacaoService;
        _PlantaService = plantaService;
    }
    

    public IActionResult Index()
    {
        var plantacoes = _PlantacaoService.FindAll();
        foreach (var plantacao in plantacoes)
        {
            var planta = _PlantaService.FindById(plantacao.PlantaId);
            plantacao.NomePlanta = planta.NomePopular;
        }
        return View(plantacoes);
    }

    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Plantacao plantacao)
    {
        var planta = _PlantaService.FindById(plantacao.PlantaId);

        plantacao.NomePlanta = planta.NomePopular;
        plantacao.DataColheita = plantacao.DataPlantio.AddDays(planta.TempoColheita);
        
        _PlantacaoService.Insert(plantacao);

        return RedirectToAction(nameof(Index));
    }
}
