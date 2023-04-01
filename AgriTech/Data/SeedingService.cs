using AgriTech.Models;

namespace AgriTech.Data;

public class SeedingService
{
    private AgriTechContext _context;

    public SeedingService(AgriTechContext context)
    {
        _context = context;
    }
    public void Seed()
    {
        if (_context.Adubo.Any())
        {
            return;
        }

        Adubo a1 = new Adubo("Orgânico", "Humos", " ", " ");
        Adubo a2 = new Adubo("Mineral", "Cloreto", " ", " ");

        _context.Adubo.AddRange(a1, a2);
        _context.SaveChanges();
    }
}
