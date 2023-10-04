namespace Zoo;

public class Frog : Animal
{
    public Frog()
    {
        _habitats.Add(TypeHabitat.Water);
        _habitats.Add(TypeHabitat.Terra);
    }
}