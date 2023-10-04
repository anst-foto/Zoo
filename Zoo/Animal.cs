namespace Zoo;

public abstract class Animal
{
    protected List<TypeHabitat> _habitats = new();
    public IEnumerable<TypeHabitat> TypeHabitats => new List<TypeHabitat>(_habitats);

    public int Age { get; set; }
    public string Name { get; set; }
}