using AgriTech.Data;
using AgriTech.Models;
using AgriTech.Services.Exceptions;

namespace AgriTech.Services;

public class PlantaService
{
    private readonly AgriTechContext _context;

    public PlantaService(AgriTechContext context)
    {
        _context = context;
    }

    public List<Planta> FindAll()
    {
        return _context.Planta.ToList();
    }
    public void Insert(Planta planta)
    {
        _context.Add(planta);
        _context.SaveChanges();
    }
    public Planta FindById(int id)
    {
        return _context.Planta.FirstOrDefault(x => x.Id == id);
    }

    public void Update(Planta planta)
    {
        if(!_context.Planta.Any(x => x.Id == planta.Id))
        {
            throw new NotFoundException("Planta não encontrada");
        }

        try
        {
            _context.Planta.Update(planta);
            _context.SaveChanges();
        }
        catch (DbConcurrencyException e)
        {
            throw new DbConcurrencyException(e.Message);
        }
    }

    public void Remove(int id)
    {
        var obj = _context.Planta.Find(id);
        _context.Planta.Remove(obj);
        _context.SaveChanges();
    }
}
