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

}
