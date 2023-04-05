namespace AgriTech.Models;

public class Planta
{
    public int Id { get; set; }
    public string NomeCientifico { get; set; }
    public string NomePopular { get; set; }
    public string EstacaoParaPlantar { get; set; }
    public string EstacaoParaColher { get; set; }
    public string ComprimentoPlantio { get; set; }
    public string LarguraPlantio { get; set; }
    public string ProfundidadePlantio { get; set; }
    public string PhSolo { get; set; }
    public string AduboRecomendado { get; set; }
    public string UmidadeSolo { get; set; }
    public string ComoRegar { get; set; }
    public string TempoGerminacao { get; set; }
    public string ComoGerminar { get; set; }
    public string TempoColheita { get; set; }
    public string ComoColher { get; set; }
    public string TempoSecagem { get; set; }
    public string ComoSecar { get; set; }
    public string Observacoes { get; set; }

    public Planta() { }
    public Planta(string nomeCientifico, string nomePopular, string estacaoParaPlantar, string estacaoParaColher, string comprimentoPlantio, string larguraPlantio, string profundidadePlantio, string phSolo, string aduboRecomendado, string umidadeSolo, string comoRegar, string tempoGerminacao, string comoGerminar, string tempoColheita, string comoColher, string tempoSecagem, string comoSecar, string observacoes)
    {
        NomeCientifico = nomeCientifico;
        NomePopular = nomePopular;
        EstacaoParaPlantar = estacaoParaPlantar;
        EstacaoParaColher = estacaoParaColher;
        ComprimentoPlantio = comprimentoPlantio;
        LarguraPlantio = larguraPlantio;
        ProfundidadePlantio = profundidadePlantio;
        PhSolo = phSolo;
        AduboRecomendado = aduboRecomendado;
        UmidadeSolo = umidadeSolo;
        ComoRegar = comoRegar;
        TempoGerminacao = tempoGerminacao;
        ComoGerminar = comoGerminar;
        TempoColheita = tempoColheita;
        ComoColher = comoColher;
        TempoSecagem = tempoSecagem;
        ComoSecar = comoSecar;
        Observacoes = observacoes;
    }
}
