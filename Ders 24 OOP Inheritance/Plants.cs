using System;

class Plants : LivingThings
{
    protected void Photosynthesis()
    {
        Console.WriteLine("Plants are Photosynthesis");
    }
}
class SeedPlants : Plants
{
    public SeedPlants()
    {
        base.Photosynthesis();
    }
    public void PropagationBySeed()
    {
        Console.WriteLine("SeedPlants are PropagationBySeed");
    }
}