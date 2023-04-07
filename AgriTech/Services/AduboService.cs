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

    //Retorna todos os items da base de dados Adubo
    public List<Adubo> FindAll()
    {
        return _context.Adubo.ToList();
    }

    //Retorna item especifico da base de dados Adubo
    public Adubo FindById(int id)
    {
        return _context.Adubo.FirstOrDefault(x => x.Id == id);
    }

    //Insere um novo Adubo na base de dados
    public void Insert(Adubo obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }

    //Altera campos do item especifico da base de dados Adubo
    public void Update(Adubo adubo)
    {
        if (!_context.Adubo.Any(x => x.Id == adubo.Id))
        {
            throw new NotFoundException("Adudo não encontrado");
        }

        //O try abaixo evita excessão de conflito de concorrencia (DbUpdateConcurrencyException)
        try
        {
            _context.Update(adubo);
            _context.SaveChanges();
        }
        catch (DbUpdateConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }

    //Remove item especifico da base de dados Adubo
    public void Remove(int id)
    {
        var obj = _context.Adubo.Find(id);
        _context.Adubo.Remove(obj);
        _context.SaveChanges();
    }
}
