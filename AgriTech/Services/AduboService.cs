using AgriTech.Data;
using AgriTech.Models;

namespace AgriTech.Services;

public class AduboService
{
    private readonly AgriTechContext _context;

    public AduboService(AgriTechContext context)
    {
        _context = context;
    }

    public List<Adubo> FindAll()
    {
        return _context.Adubo.ToList();
    }
    public void Insert(Adubo obj)
    {
        _context.Add(obj);
        _context.SaveChanges();
    }
    public Adubo FindById(int id)
    {
        return _context.Adubo.FirstOrDefault(x => x.Id == id);
    }
    public void Remove(int id)
    {
        var obj = _context.Adubo.Find(id);
        _context.Adubo.Remove(obj);
        _context.SaveChanges();
    }
}
