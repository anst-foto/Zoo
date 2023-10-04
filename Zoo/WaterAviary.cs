namespace Zoo;

public class WaterAviary : Aviary
{
    public override bool AddAnimal(Animal animal)
    {
        if (_animals.Count >= MaxCount)
        {
            return false;
        }

        if (!animal.TypeHabitats.Contains(TypeHabitat.Water)) return false;
        
        _animals.Add(animal);
        return true;
    }
}