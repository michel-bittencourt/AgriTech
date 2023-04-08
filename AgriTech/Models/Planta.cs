using System.ComponentModel;

namespace AgriTech.Models;

public class Planta
{
    public int Id { get; set; }
    //-------------------------------------------------
    [DisplayName("Nome Científico")]
    public string NomeCientifico { get; set; }
    //-------------------------------------------------
    [DisplayName("Nome Popular")]
    public string NomePopular { get; set; }
    //-------------------------------------------------
    [DisplayName("Estação para Plantio")]
    public string? EstacaoParaPlantar { get; set; }
    //-------------------------------------------------
    [DisplayName("Estação para Colheita")]
    public string? EstacaoParaColher { get; set; }
    //-------------------------------------------------
    [DisplayName("Compri. Plantio")]
    public string? ComprimentoPlantio { get; set; }
    //-------------------------------------------------
    [DisplayName("Larg. Plantio")]
    public string? LarguraPlantio { get; set; }
    //-------------------------------------------------
    [DisplayName("Profun. para Plantio")]
    public string? ProfundidadePlantio { get; set; }
    //-------------------------------------------------
    [DisplayName("Ph do Solo")]
    public string? PhSolo { get; set; }
    //-------------------------------------------------
    [DisplayName("Umid. do Solo")]
    public string? UmidadeSolo { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Regar")]
    public string? ComoRegar { get; set; }
    //-------------------------------------------------
    [DisplayName("Dias para Germinar")]
    public int DiasGerminacao { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Germinar")]
    public string? ComoGerminar { get; set; }
    //-------------------------------------------------
    [DisplayName("Dias para Colheita")]
    public int DiasColheita { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Colher")]
    public string? ComoColher { get; set; }
    //-------------------------------------------------
    [DisplayName("Tempo para secagem")]
    public string? TempoSecagem { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Secar")]
    public string? ComoSecar { get; set; }
    //-------------------------------------------------
    [DisplayName("Observações")]
    public string? Observacoes { get; set; }
    //-------------------------------------------------
    public List<Plantacao> plantacaos { get; set; }

    //Construct
    public Planta() { }
    public Planta(string nomeCientifico, string nomePopular, string? estacaoParaPlantar, string? estacaoParaColher, string? comprimentoPlantio, string? larguraPlantio, string? profundidadePlantio, string? phSolo, string? umidadeSolo, string? comoRegar, int diasGerminacao, string? comoGerminar, int diasColheita, string? comoColher, string? tempoSecagem, string? comoSecar, string? observacoes)
    {
        NomeCientifico = nomeCientifico;
        NomePopular = nomePopular;
        EstacaoParaPlantar = estacaoParaPlantar;
        EstacaoParaColher = estacaoParaColher;
        ComprimentoPlantio = comprimentoPlantio;
        LarguraPlantio = larguraPlantio;
        ProfundidadePlantio = profundidadePlantio;
        PhSolo = phSolo;
        UmidadeSolo = umidadeSolo;
        ComoRegar = comoRegar;
        DiasGerminacao = diasGerminacao;
        ComoGerminar = comoGerminar;
        DiasColheita = diasColheita;
        ComoColher = comoColher;
        TempoSecagem = tempoSecagem;
        ComoSecar = comoSecar;
        Observacoes = observacoes;
    }
}