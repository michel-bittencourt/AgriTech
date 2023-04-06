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
}
