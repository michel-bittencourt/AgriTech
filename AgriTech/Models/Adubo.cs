namespace AgriTech.Models;

public class Adubo
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public string Ingredientes { get; set; }
    public string DescricaoMontagem { get; set; }
    public string DescricaoUso { get; set; }
    public string? Observacao { get; set; }

    public Adubo() { }
    public Adubo(string tipo, string nome, string ingredientes, string descricaoMontagem, string descricaoUso, string? observacao)
    {
        Tipo = tipo;
        Nome = nome;
        Ingredientes = ingredientes;
        DescricaoMontagem = descricaoMontagem;
        DescricaoUso = descricaoUso;
        Observacao = observacao;
    }
}
