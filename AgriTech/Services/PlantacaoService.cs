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

    public async Task<List<Plantacao>> FindAllAsync()
    {
        return await _context.Plantacao.OrderBy(x => x.DataColheita).ThenBy(x => x.DataGerminacao).ThenBy(x => x.NomePlanta).ThenBy(x => x.NomeCientifico).ThenBy(x => x.Id).ToListAsync();
    }

    public async Task<Plantacao> FindByIdAsync(int id)
    {
        return await _context.Plantacao.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task InsertAsync(Plantacao plantacao)
    {
        _context.Add(plantacao);
        await _context.SaveChangesAsync();
    }

    /*public async Task Update(Plantacao plantacao)
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
    }*/

    //Remove item especifico do banco
    public async Task RemoveAsync(int id)
    {
        try
        {
            var obj = await _context.Plantacao.FindAsync(id);

            _context.Plantacao.Remove(obj);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateException e)
        {
            throw new IntegrityException(e.Message);
        }
    }
}
