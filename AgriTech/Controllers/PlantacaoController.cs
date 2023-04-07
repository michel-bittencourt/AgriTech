using AgriTech.Models;
using AgriTech.Models.ViewModel;
using AgriTech.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AgriTech.Controllers;
public class PlantacaoController : Controller
{
    private readonly PlantacaoService _plantacaoService;
    private readonly PlantaService _plantaService;
    private readonly AduboService _aduboService;

    public PlantacaoController(PlantacaoService plantacaoService, PlantaService plantaService, AduboService aduboService)
    {
        _plantacaoService = plantacaoService;
        _plantaService = plantaService;
        _aduboService = aduboService;
    }

    public IActionResult Index()
    {
        var plantacoes = _plantacaoService.FindAll();
        return View(plantacoes);
    }

    public async Task<IActionResult> Details(int id)
    {
        var list = _plantacaoService.FindById(id);
        return View(list);
    }

    public async Task<IActionResult> Create()
    {
        var adubos = _aduboService.FindAll();
        var plantas = _plantaService.FindAll();
        var viewModel = new PlantacaoFormViewModel { Adubos = adubos , Plantas = plantas};
        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Plantacao plantacao)
    {
        var planta = _plantaService.FindById(plantacao.PlantaId);
        var adubo = _aduboService.FindById(plantacao.AduboId);

        plantacao.NomePlanta = planta.NomePopular;
        plantacao.NomeCientifico = planta.NomeCientifico;
        plantacao.TipoAdubo = adubo.Tipo;
        plantacao.NomeAdubo = adubo.Nome;
        plantacao.DataGerminacao = plantacao.DataPlantio.AddDays(planta.DiasGerminacao);
        plantacao.DataColheita = plantacao.DataPlantio.AddDays(planta.DiasGerminacao + planta.DiasColheita);

        _plantacaoService.Insert(plantacao);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var obj = _plantacaoService.FindById(id.Value);

        if (obj == null)
        {
            return NotFound();
        }

        return View(obj);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        _plantacaoService.Remove(id);
        return RedirectToAction(nameof(Index));
    }
}
