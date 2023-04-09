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

    public async Task<IActionResult> Index()
    {
        var plantacoes = await _plantacaoService.FindAllAsync();
        return View(plantacoes);
    }

    public async Task<IActionResult> Details(int id)
    {
        var list = await _plantacaoService.FindByIdAsync(id);
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

        plantacao.NomePlanta = plantas.NomePopular;
        plantacao.NomeCientifico = plantas.NomeCientifico;

        plantacao.CalculaTempoColheita(plantas.DiasColheita);
        plantacao.CalculaTempoGerminacao(plantas.DiasGerminacao);

        await _plantacaoService.InsertAsync(plantacao);

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

    /*[HttpPost]
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
    }*/

    //--------------------------------------------------------------------
    //Retorna a pagina de exclusao
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var obj = await _plantacaoService.FindByIdAsync(id.Value);

        if (obj == null)
        {
            return NotFound();
        }

        return View(obj);
    }
    //--------------------------------------------------------------------
    //Realiza a exclusao de uma plantacao especifico do banco
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _plantacaoService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }
        catch (IntegrityException e)
        {
            throw new IntegrityException(e.Message);
        }
    }
}
