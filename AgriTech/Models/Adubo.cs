namespace AgriTech.Models;

public class Adubo
{
    public int Id { get; set; }
    public string Tipo { get; set; }
    public string Nome { get; set; }
    public string DescricaoMontagem { get; set; }
    public string Observacao { get; set; }

    public Adubo(string tipo, string nome, string descricaoMontagem, string observacao)
    {
        Tipo = tipo;
        Nome = nome;
        DescricaoMontagem = descricaoMontagem;
        Observacao = observacao;
    }
}
