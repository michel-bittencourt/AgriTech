using AgriTech.Data;
using AgriTech.Models;

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

    public void Insert(Plantacao plantacao)
    {
        _context.Add(plantacao);
        _context.SaveChanges();
    }

    public Plantacao FindById(int id)
    {
        return _context.Plantacao.FirstOrDefault(x => x.Id == id);
    }
    public void Remove(int id)
    {
        var obj = _context.Plantacao.Find(id);
        _context.Plantacao.Remove(obj);
        _context.SaveChanges();
    }
}
