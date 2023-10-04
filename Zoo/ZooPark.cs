namespace Zoo;

public class ZooPark
{
    public ICollection<Aviary> Aviaries { get; init; } = new List<Aviary>();
}