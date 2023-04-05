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
        if (_context.Adubo.Any() || _context.Planta.Any() || _context.Plantacao.Any())
        {
            return;
        }

        Adubo a1 = new Adubo("Orgânico", "Humos", "Terra Preta, Minhoca", "Descrição", "Jogando", "Observações");
        _context.Adubo.Add(a1);

        Planta p1 = new Planta("Allium sativum", "Alho Branco", "Outono/Inverno", "Primavera/Verão", "10 a 15 cm", "15 a 20 cm", "2 a 3 cm", "6,0 a 7,0", "Úmido", "3 em 3 dias", "7 a 10 dias", "teste", "6 a 9 meses", "Colher quando as folhas começarem a secar e ficarem amareladas. Arrancar a planta inteira, retirar o excesso de terra.", "2 a 3 semanas", "Amarre os alhos em ramos e pendure em um local seco e ventilado.", "O alho branco é uma cultura de ciclo longo e sensível ao excesso de umidade. É importante plantar em solo bem drenado e com boa fertilidade.", "Orgânico");
        _context.Planta.Add(p1);

        Plantacao pl1 = new Plantacao("1", 2, 2, new DateTime(2023, 01, 01), 120);
        _context.Plantacao.Add(pl1);

        _context.SaveChanges();
    }
}
