using AgriTech.Models;
using AgriTech.Models.ViewModel;
using AgriTech.Services;
using AgriTech.Services.Exceptions;
using Microsoft.AspNetCore.Mvc;

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

    public async Task<IActionResult> Details(int id, Planta planta)
    {
        var list = _plantacaoService.FindById(id, planta);
        return View(list);
    }

    public async Task<IActionResult> Create()
    {
        var adubos = await _aduboService.FindAllAsync();
        var plantas = _plantaService.FindAll();

        var viewModel = new PlantacaoFormViewModel { Adubos = adubos, Plantas = plantas };
        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Plantacao plantacao)
    {
        var plantas = _plantaService.FindById(plantacao.PlantaId);
        var adubos = _aduboService.FindByIdAsync(plantacao.AduboId);

        _plantacaoService.Insert(plantacao);

        return RedirectToAction(nameof(Index));
    }

    /*public async Task<IActionResult> Edit(int? id)
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

        List<Planta> plantas = _plantaService.FindAll();
        List<Adubo> adubos = _aduboService.FindAll();

        PlantacaoFormViewModel viewModel = new PlantacaoFormViewModel { Plantacao = obj, Plantas = plantas, Adubos = adubos };

        return View(viewModel);
    }*/

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Plantacao plantacao)
    {
        if (id != plantacao.Id)
        {
            return BadRequest();
        }
        var planta = _plantaService.FindById(id);
        var adubo = _aduboService.FindByIdAsync(id);

        try
        {     
            _plantacaoService.Update(plantacao);
            return RedirectToAction(nameof(Index));
        }
        catch (NotFoundException e)
        {
            throw new NotFoundException(e.Message);
        }
        catch (DbConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }

    /*public async Task<IActionResult> Delete(int? id)
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
    }*/

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        _plantacaoService.Remove(id);
        return RedirectToAction(nameof(Index));
    }
}
