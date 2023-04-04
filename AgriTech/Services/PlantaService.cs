using AgriTech.Data;
using AgriTech.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
    public void Remove(int id)
    {
        var obj = _context.Planta.Find(id);
        _context.Planta.Remove(obj);
        _context.SaveChanges();
    }
}
