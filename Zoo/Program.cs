using Zoo;
using Zoo.Animals;
using Zoo.Aviarys;

var aquarium = new WaterAviary()
{
    MaxCount = 2
};

var frog = new Frog()
{
    Type = "Amphibia",
    Name = "Crazy Frog",
    Age = 100
};

var fishDory = new Fish()
{
    Type = "Aqua",
    Name = "Dory",
    Age = 1
};

var fishNemo = new Fish()
{
    Type = "Aqua",
    Name = "Nemo",
    Age = 1
};

aquarium.AddAnimal(frog);
aquarium.AddAnimal(fishDory);
aquarium.AddAnimal(fishNemo);

var zoo = new ZooPark();
zoo.Aviaries.Add(aquarium);

Console.WriteLine($"Aviaries count = {zoo.Aviaries.Count}");
foreach (var aviary in zoo.Aviaries)
{
    Console.WriteLine("Aviary: ");
    foreach (var animal in aviary.Animals)
    {
        Console.WriteLine($"{animal.Name} - {animal.Age}");
    }
}