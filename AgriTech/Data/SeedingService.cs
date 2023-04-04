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
        if (_context.Adubo.Any() || _context.Planta.Any())
        {
            return;
        }

        Adubo a1 = new Adubo("Orgânico", "Humos", "Terra Preta, Minhoca", "Descrição", "Jogando", "Observações");
        _context.Adubo.Add(a1);

        Planta p1 = new Planta("Petroselinum crispum", "Salsinha", "Primavera/Verão", "1 a 2 cm", "20 cm", "0,5 a 1 cm", "6,0 a 7,0", "Levemente úmido", "14 a 21 dias", "70 a 90 dias", "2 a 3 dias", "");
        _context.Planta.Add(p1);

        _context.SaveChanges();
    }
}
