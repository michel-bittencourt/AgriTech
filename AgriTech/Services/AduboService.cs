using AgriTech.Data;
using AgriTech.Models;

namespace AgriTech.Services;

public class AduboService
{
    private readonly AgriTechContext _context;

    public AduboService (AgriTechContext context)
    {
        _context = context;
    }

    public List<Adubo> FindAll()
    {
        return _context.Adubo.ToList();
    }
}
