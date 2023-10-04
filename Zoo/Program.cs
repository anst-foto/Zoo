using Zoo;

var fish = new Fish()
{
    Age = 1,
    Name = "Dory"
};

var frog = new Frog()
{
    Age = 100,
    Name = "Crazy Frog"
};

var aquarium = new WaterAviary()
{
    MaxCount = 2
};
aquarium.AddAnimal(fish);
aquarium.AddAnimal(frog);

var zoo = new ZooPark();
zoo.Aviaries.Add(aquarium);

Console.WriteLine("Zoo : ");
foreach (var aviary in zoo.Aviaries)
{
    foreach (var animal in aviary.Animals)
    {
        Console.WriteLine($"{animal.Name} - {animal.Age}");
        foreach (var habitat in animal.TypeHabitats)
        {
            Console.Write($"{habitat}\t");
        }
        Console.WriteLine();
    }
}