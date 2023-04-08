using AgriTech.Data;
using AgriTech.Models;
using AgriTech.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace AgriTech.Services;

public class AduboService
{
    private readonly AgriTechContext _context;

    public AduboService(AgriTechContext context)
    {
        _context = context;
    }

    //Retorna todos os items do banco
    public async Task<List<Adubo>> FindAllAsync()
    {
        //ThenBy é a segunda ordenacao
        return await _context.Adubo.OrderBy(x => x.Tipo).ThenBy(x => x.Nome).ToListAsync();
    }

    //Retorna item especifico do banco
    public async Task<Adubo> FindByIdAsync(int id)
    {
        return await _context.Adubo.FirstOrDefaultAsync(x => x.Id == id);
    }

    //Insere um novo Adubo na base de dados
    public async Task InsertAsync(Adubo obj)
    {
        _context.Add(obj);
        await _context.SaveChangesAsync();
    }

    //Altera campos do item especifico da base de dados Adubo
    public async Task UpdateAsync(Adubo adubo)
    {
        if (!await _context.Adubo.AnyAsync(x => x.Id == adubo.Id))
        {
            throw new NotFoundException("Adudo não encontrado");
        }

        //O try abaixo evita excessão de conflito de concorrencia (DbUpdateConcurrencyException)
        try
        {
            _context.Update(adubo);
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }

    //Remove item especifico da base de dados Adubo
    public async Task RemoveAsync(int id)
    {
        var obj = await _context.Adubo.FindAsync(id);

        _context.Adubo.Remove(obj);
        await _context.SaveChangesAsync();
    }
}
