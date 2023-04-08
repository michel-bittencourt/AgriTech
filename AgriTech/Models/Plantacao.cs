using System.ComponentModel.DataAnnotations;

namespace AgriTech.Models;

public class Plantacao
{
    public int Id { get; set; }
    //-------------------------------------------------
    public string Lote { get; set; } 
    //-------------------------------------------------
    [Display(Name = "Germinação")]
    [DataType(DataType.Date)]
    public DateTime? DataGerminacao { get; set; }
    //-------------------------------------------------
    public bool Germinou { get; set; } = false;
    //-------------------------------------------------
    [Display(Name = "Data que Germinou")]
    [DataType(DataType.Date)]
    public DateTime? DataGerminou { get; set; }
    //-------------------------------------------------
    [Display(Name = "Data Plantio")]
    [DataType(DataType.Date)]
    public DateTime DataPlantio { get; set; }
    //-------------------------------------------------
    [Display(Name = "Colheita")]
    [DataType(DataType.Date)]
    public DateTime DataColheita { get; set; }
    //-------------------------------------------------
    public Planta Planta { get; set; }
    public int PlantaId { get; set; }
    //-------------------------------------------------
    public List<Adubo> Adubo { get; set; } = new List<Adubo>();
    public int AduboId { get; set; }

    //Construct
    public Plantacao() { }

    public Plantacao(int id, string lote, DateTime? dataGerminacao, bool germinou, DateTime? dataGerminou, DateTime dataPlantio, DateTime dataColheita, Planta planta)
    {
        Id = id;
        Lote = lote;
        DataGerminacao = dataGerminacao;
        Germinou = germinou;
        DataGerminou = dataGerminou;
        DataPlantio = dataPlantio;
        DataColheita = dataColheita;
        Planta = planta;
    }


    //Functions
    //Adiciona Adubos
    public void AddAdubo(Adubo adubo)
    {
        Adubo.Add(adubo);
    }

    //Calcula o tempo de colheita levando em consideração dias para germinar e dias para colher
    public void CalculaTempoColheita()
    {
        DataColheita = DataPlantio.AddDays(Planta.DiasGerminacao + Planta.DiasColheita);
    }

    //Atualiza o tempo de colheita para contar os dias para colher apos germinar
    public void AjustaTempoColheita()
    {
        DataColheita = DataPlantio.AddDays(Planta.DiasColheita);
    }
}