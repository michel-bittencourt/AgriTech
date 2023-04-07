/*using AgriTech.Models;

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

        Planta p1 = new Planta("Allium sativum", "Salsa", "Primavera", "Verão", "15 cm", "15 cm", "1 cm", "6 a 7", "Organico/NPK", "Úmido, não encharcado", "Regar regularmente, evitando encharcar o solo", 20, "Plantar as sementes em solo úmido e cobri-las com uma fina camada de terra.", 80, "Cortar as folhas externas da planta, deixando as internas para continuar crescendo. Evitar cortar mais de um terço das folhas da planta de uma vez.", "5-10 dias", "Pendurar os ramos de salsa em local ventilado e com pouca luz até que estejam completamente secos. Armazenar em recipiente hermético.", "A salsa é uma erva bastante resistente e fácil de cultivar. Prefere sol pleno ou meia sombra e solos ricos em matéria orgânica. Pode ser cultivada em vasos ou canteiros e é uma ótima opção para temperar alimentos.");
        _context.Planta.Add(p1);

        Plantacao pl1 = new Plantacao("1", new Planta { }, new Adubo { }, new DateTime(2023, 01, 01), false, null, new DateTime(2023, 01, 01), new DateTime(2023, 01, 01));
        _context.Plantacao.Add(pl1);

        _context.SaveChanges();
    }
}*/