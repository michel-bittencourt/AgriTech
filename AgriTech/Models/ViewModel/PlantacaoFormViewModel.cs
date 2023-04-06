namespace AgriTech.Models.ViewModel;

public class PlantacaoFormViewModel
{
    public Plantacao Plantacao { get; set; }
    public ICollection<Planta> Plantas { get; set; }
    public ICollection<Adubo> Adubos { get; set; }
}
