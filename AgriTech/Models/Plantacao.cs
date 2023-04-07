using System.ComponentModel.DataAnnotations;

namespace AgriTech.Models;

public class Plantacao
{
    public int Id { get; set; }

    [Display(Name = "Planta")]
    public string NomePlanta { get; set; }

    [Display(Name = "Nome Científico")]
    public string NomeCientifico { get; set; }
    public string Lote { get; set; }
    public Planta Planta { get; set; }
    public int PlantaId { get; set; }
    public Adubo Adubo { get; set; }
    public int AduboId { get; set; }

    [Display(Name = "Tipo de Adubo")]
    public string TipoAdubo { get; set; }

    [Display(Name = "Nome do Adubo")]
    public string NomeAdubo { get; set; }

    [Display(Name = "Germinação")]
    [DataType(DataType.Date)]
    public DateTime DataGerminacao { get; set; }
    public bool Germinou { get; set; } = false;

    [Display(Name = "Data que Germinou")]
    [DataType(DataType.Date)]
    public DateTime? DataGerminou { get; set; }

    [Display(Name = "Data Plantio")]
    [DataType(DataType.Date)]
    public DateTime DataPlantio { get; set; }

    [Display(Name = "Colheita")]
    [DataType(DataType.Date)]
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
