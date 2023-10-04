using Zoo.Aviarys;

namespace Zoo;

public class ZooPark
{
    public ICollection<Aviary> Aviaries { get; set; } = new List<Aviary>();
}