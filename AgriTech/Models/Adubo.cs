using System.ComponentModel;

namespace AgriTech.Models;

public class Adubo
{
    public int Id { get; set; }
    //-------------------------------------------------
    [DisplayName("Tipo de Adubo")]
    public string Tipo { get; set; }
    //-------------------------------------------------
    [DisplayName("Nome do Adubo")]
    public string Nome { get; set; }
    //-------------------------------------------------
    [DisplayName("Ingredientes")]
    public string? Ingredientes { get; set; }
    //-------------------------------------------------
    [DisplayName("Descrição da Montagem")]
    public string? DescricaoMontagem { get; set; }
    //-------------------------------------------------
    [DisplayName("Descrição do Uso")]
    public string? DescricaoUso { get; set; }
    //-------------------------------------------------
    [DisplayName("Observações")]
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