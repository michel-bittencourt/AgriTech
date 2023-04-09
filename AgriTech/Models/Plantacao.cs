using System.ComponentModel.DataAnnotations;

namespace AgriTech.Models;

public class Plantacao
{
    public int Id { get; set; }
    //-------------------------------------------------
    public string Lote { get; set; }
    //-------------------------------------------------
    //Serão populados automaticamente com dados da tabela planta
    public string NomePlanta { get; set; }
    public string NomeCientifico { get; set; }
    public string? TipoAdubo { get; set; }
    public string? NomeAdubo { get; set; }
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
    public List<Adubo>? Adubo { get; set; } = new List<Adubo>();
    public int? AduboId { get; set; }

    //Construct
    public Plantacao() { }

    public Plantacao(string lote, string nomePlanta, string nomeCientifico, string? tipoAdubo, string? nomeAdubo, DateTime? dataGerminacao, bool germinou, DateTime? dataGerminou, DateTime dataPlantio, DateTime dataColheita, Planta planta)
    {
        Lote = lote;
        NomePlanta = nomePlanta;
        NomeCientifico = nomeCientifico;
        TipoAdubo = tipoAdubo;
        NomeAdubo = nomeAdubo;
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
    public void CalculaTempoColheita(int diasColheita)
    {
        DataColheita = DataPlantio.AddDays(diasColheita);
    }
    public void CalculaTempoGerminacao(int diasGerminacao)
    {
        DataGerminacao = DataPlantio.AddDays(diasGerminacao);
    }

    //Atualiza o tempo de colheita para contar os dias para colher apos germinar
    /*public void AjustaTempoColheita()
    {
        if (DataGerminou != null)
        {
            TimeSpan diff = (DateTime)DataColheita - (DateTime)DataGerminou;
            int daysDiff = (int)diff.TotalDays;
            int monthsDiff = ((DateTime)DataColheita).Month - ((DateTime)DataGerminou).Month + 12 * (((DateTime)DataColheita).Year - ((DateTime)DataGerminou).Year);
            int yearsDiff = ((DateTime)DataColheita).Year - ((DateTime)DataGerminou).Year;

            if (daysDiff < 0)
            {
                if (monthsDiff > 0)
                {
                    DataColheita = ((DateTime)DataGerminou).AddMonths(monthsDiff).AddDays(diasColheita);
                }
                else if (yearsDiff > 0)
                {
                    DataColheita = ((DateTime)DataGerminou).AddYears(yearsDiff).AddDays(diasColheita);
                }
            }
        }
    }*/
}