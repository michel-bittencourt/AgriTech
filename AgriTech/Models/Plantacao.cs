namespace AgriTech.Models;

public class Plantacao
{
    public int Id { get; set; }
    public string NomePlanta { get; set; }
    public string NomeCientifico { get; set; }
    public string Lote { get; set; }
    public Planta Planta { get; set; }
    public int PlantaId { get; set; }
    public Adubo Adubo { get; set; }
    public int AduboId { get; set; }
    public DateTime DataGerminacao { get; set; }
    public bool Germinou { get; set; } = false;
    public DateTime? DataGerminou { get; set; }
    public DateTime DataPlantio { get; set; }
    public DateTime DataColheita { get; set; }

    public Plantacao() { }

    public Plantacao(string lote, Planta planta, Adubo adubo, DateTime dataGerminacao, bool germinou, DateTime? dataGerminou, DateTime dataPlantio, DateTime dataColheita)
    {
        Lote = lote;
        Planta = planta;
        Adubo = adubo;
        DataGerminacao = dataGerminacao;
        Germinou = germinou;
        DataGerminou = dataGerminou;
        DataPlantio = dataPlantio;
        DataColheita = dataColheita;
    }
}
