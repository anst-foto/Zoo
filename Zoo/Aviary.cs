namespace Zoo;

public abstract class Aviary
{
    protected readonly List<Animal> _animals = new();
    public IEnumerable<Animal> Animals => new List<Animal>(_animals);

    public int MaxCount { get; init; }

    public abstract bool AddAnimal(Animal animal);
}