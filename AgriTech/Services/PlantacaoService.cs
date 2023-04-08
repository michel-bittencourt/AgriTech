using AgriTech.Data;
using AgriTech.Models;
using AgriTech.Services.Exceptions;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Versioning;

namespace AgriTech.Services;

public class PlantacaoService
{
    private readonly AgriTechContext _context;

    public PlantacaoService(AgriTechContext context)
    {
        _context = context;
    }

    public List<Plantacao> FindAll()
    {
        return _context.Plantacao.ToList();
    }

    public Plantacao FindById(int id, Planta planta)
    {
        return _context.Plantacao.FirstOrDefault(x => x.Id == id && x.PlantaId == planta.Id);
    }

    public void Insert(Plantacao plantacao)
    {
        _context.Add(plantacao);
        _context.SaveChanges();
    }

    public void Update(Plantacao plantacao)
    {
        if (!_context.Plantacao.Any(x => x.Id == plantacao.Id))
        {
            throw new NotFoundException("Plantação não encontrada");
        }

        //O try abaixo evita excessão de conflito de concorrencia (DbUpdateConcurrencyException)
        try
        {
            _context.Update(plantacao);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }

    public void Remove(int id)
    {
        var obj = _context.Plantacao.Find(id);
        _context.Plantacao.Remove(obj);
        _context.SaveChanges();
    }
}
