using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AgriTech.Models;

public class Adubo
{
    public int Id { get; set; }
    //-------------------------------------------------
    [DisplayName("Tipo de Adubo")]
    [Required(ErrorMessage = "Campo obrigatório")]
    /*{0} Pega o nome do campo, no caso "Tipo", {1} pega o primeiro parametro, no caso o tamanho maximo "20", {2} pega o segundo paramentro, no caso tamanho minimo "3".*/
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string Tipo { get; set; }
    //-------------------------------------------------
    [DisplayName("Nome do Adubo")]
    [Required(ErrorMessage = "Campo obrigatório")]
    [StringLength(25, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string Nome { get; set; }
    //-------------------------------------------------
    [DisplayName("Ingredientes")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? Ingredientes { get; set; }
    //-------------------------------------------------
    [DisplayName("Descrição da Montagem")]
    [StringLength(300, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? DescricaoMontagem { get; set; }
    //-------------------------------------------------
    [DisplayName("Descrição do Uso")]
    [StringLength(300, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? DescricaoUso { get; set; }
    //-------------------------------------------------
    [DisplayName("Observações")]
    [StringLength(500, MinimumLength = 3, ErrorMessage = "Deve conter de {2} a {1} caracteres")]
    public string? Observacao { get; set; }
    //-------------------------------------------------
    public List<Plantacao> plantacaos { get; set; }

    //Construct
    public Adubo() { }
    public Adubo(int id, string tipo, string nome, string? ingredientes, string? descricaoMontagem, string? descricaoUso, string? observacao)
    {
        Id = id;
        Tipo = tipo;
        Nome = nome;
        Ingredientes = ingredientes;
        DescricaoMontagem = descricaoMontagem;
        DescricaoUso = descricaoUso;
        Observacao = observacao;
    }
}