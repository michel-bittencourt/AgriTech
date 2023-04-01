namespace AgriTech.Models;

public class Planta
{
    public int Id { get; set; }
    public string NomeCientifico { get; set; }
    public string NomePopular { get; set; }
    public string Estacao { get; set; }
    public string Profundidade { get; set; }
    public string DistanciaComprimento { get; set; }
    public string DistanciaLargura { get; set; }
    public string Ph { get; set; }
    public string Umidade { get; set; }
    public ICollection<Adubo> Adubos { get; set; } = new List<Adubo>();
    public int DiasParaColher { get; set; }
    public string TempoParaSecagem { get; set; }
}
