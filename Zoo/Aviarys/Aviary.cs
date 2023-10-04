using Zoo.Animals;

namespace Zoo.Aviarys;

public abstract class Aviary
{
    public ICollection<Animal> Animals { get; } = new List<Animal>();
    public int MaxCount { get; init; }

    public abstract bool AddAnimal(Animal animal);
}