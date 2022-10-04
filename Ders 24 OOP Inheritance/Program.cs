using System;

namespace Ders_24_OOP_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            SeedPlants seedPlants = new SeedPlants();
            seedPlants.Respiratory();
            seedPlants.Excretion();
            seedPlants.Nutrition();
            seedPlants.Photosynthesis();
            Birds birds = new Birds();
            birds.Adaption();
            birds.Excretion();
            birds.Fly();
            birds.Nutrition();
            birds.Respiratory();

        }
    }
}
