using Zoo.Animals;
using Zoo.Habitats;

namespace Zoo.Aviarys;

public class WaterAviary : Aviary
{
    public override bool AddAnimal(Animal animal)
    {
        if (Animals.Count >= MaxCount)
        {
            return false;
        }
        
        if (animal is not IWater) return false;
        
        Animals.Add(animal);
        return true;
    }
}