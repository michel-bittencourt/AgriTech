namespace AgriTech.Models;

public class Plantacao
{
    public int Id { get; set; }
    public string NomePlanta { get; set; }
    public string Lote { get; set; }
    public Planta Planta { get; set; }
    public int PlantaId { get; set; }
    public Adubo Adubo { get; set; }
    public int AduboId { get; set; }
    public DateTime DataPlantio { get; set; }
    public DateTime DataColheita { get; set; }

    public Plantacao() { }
    public Plantacao (string nomePlanta, string lote, int plantaId, int aduboId, DateTime dataPlantio)
    {
        NomePlanta = nomePlanta;
        Lote = lote;
        PlantaId = plantaId;
        AduboId = aduboId;
        DataPlantio = dataPlantio;
    }
}
