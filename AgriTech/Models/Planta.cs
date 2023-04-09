using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgriTech.Models;

public class Planta
{
    public int Id { get; set; }
    //-------------------------------------------------
    [DisplayName("Nome Científico")]
    [Required(ErrorMessage = "Campo obrigatório")]
    [StringLength(25, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string NomeCientifico { get; set; }
    //-------------------------------------------------
    [DisplayName("Nome da Planta")]
    [Required(ErrorMessage = "Campo obrigatório")]
    [StringLength(25, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string NomePopular { get; set; }
    //-------------------------------------------------
    [DisplayName("Estação para Plantio")]
    [StringLength(35, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? EstacaoParaPlantar { get; set; }
    //-------------------------------------------------
    [DisplayName("Estação para Colheita")]
    [StringLength(35, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? EstacaoParaColher { get; set; }
    //-------------------------------------------------
    [DisplayName("Compri. Plantio")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? ComprimentoPlantio { get; set; }
    //-------------------------------------------------
    [DisplayName("Larg. Plantio")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? LarguraPlantio { get; set; }
    //-------------------------------------------------
    [DisplayName("Profun. para Plantio")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? ProfundidadePlantio { get; set; }
    //-------------------------------------------------
    [DisplayName("Ph do Solo")]
    [StringLength(20, MinimumLength = 1, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? PhSolo { get; set; }
    //-------------------------------------------------
    [DisplayName("Umid. do Solo")]
    //[StringLength(40, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? UmidadeSolo { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Regar")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? ComoRegar { get; set; }
    //-------------------------------------------------
    [DisplayName("Dias para Germinar")]
    [Required(ErrorMessage = "Campo obrigatório")]
    //[StringLength(5, MinimumLength = 1, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public int DiasGerminacao { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Germinar")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? ComoGerminar { get; set; }
    //-------------------------------------------------
    [DisplayName("Dias para Colheita")]
    [Required(ErrorMessage = "Campo obrigatório")]
    //[StringLength(5, MinimumLength = 1, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public int DiasColheita { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Colher")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? ComoColher { get; set; }
    //-------------------------------------------------
    [DisplayName("Dias para secagem")]
    //[StringLength(15, MinimumLength = 1, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public int? TempoSecagem { get; set; }
    //-------------------------------------------------
    [DisplayName("Como Secar")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? ComoSecar { get; set; }
    //-------------------------------------------------
    [DisplayName("Observações")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? Observacoes { get; set; }
    //-------------------------------------------------
    public string? FontesPesquisa { get; set; }
    //-------------------------------------------------
    public List<Plantacao> plantacaos { get; set; }

    //Construct
    public Planta() { }
    public Planta(string nomeCientifico, string nomePopular, string? estacaoParaPlantar, string? estacaoParaColher, string? comprimentoPlantio, string? larguraPlantio, string? profundidadePlantio, string? phSolo, string? umidadeSolo, string? comoRegar, int diasGerminacao, string? comoGerminar, int diasColheita, string? comoColher, int? diasSecagem, string? comoSecar, string? observacoes, string? fontesPesquisa)
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
        TempoSecagem = diasSecagem;
        ComoSecar = comoSecar;
        Observacoes = observacoes;
        FontesPesquisa = fontesPesquisa;
    }
}