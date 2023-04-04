namespace AgriTech.Models;

public class Planta
{
    public int Id { get; set; }
    public string NomeCientifico { get; set; }
    public string NomePopular { get; set; }
    public string EstacaoCrescimento { get; set; }
    public string ComprimentoPlantio { get; set; }
    public string LarguraPlantio { get; set; }
    public string ProfundidadePlantio { get; set; }
    public string PhSolo { get; set; }
    public string UmidadeSolo { get; set; }
    public string TempoGerminacao { get; set; }
    public string TempoColheita { get; set; }
    public string TempoSecagem { get; set; }
    public string? Observacoes { get; set; }

    public Planta() { }
    public Planta(string nomeCientifico, string nomePopular, string estacaoCrescimento, string comprimentoPlantio, string larguraPlantio, string profundidadePlantio, string phSolo, string umidadeSolo, string tempoGerminacao, string tempoColheita, string tempoSecagem, string? observacoes)
    {
        NomeCientifico = nomeCientifico;
        NomePopular = nomePopular;
        EstacaoCrescimento = estacaoCrescimento;
        ComprimentoPlantio = comprimentoPlantio;
        LarguraPlantio = larguraPlantio;
        ProfundidadePlantio = profundidadePlantio;
        PhSolo = phSolo;
        UmidadeSolo = umidadeSolo;
        TempoGerminacao = tempoGerminacao;
        TempoColheita = tempoColheita;
        TempoSecagem = tempoSecagem;
        Observacoes = observacoes;
    }
}
