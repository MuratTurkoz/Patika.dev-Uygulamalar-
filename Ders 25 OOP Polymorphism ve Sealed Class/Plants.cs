using System;

class Plants : LivingThings
{
    protected void Photosynthesis()
    {
        Console.WriteLine("Plants are Photosynthesis");
    }
    public override void ReactToStimuli()
    {
        base.ReactToStimuli();
        Console.WriteLine("Plants react to sun");
    }
}
class SeedPlants : Plants
{
    public SeedPlants()
    {
        base.Photosynthesis();
        base.Excretion();
        base.Nutrition();
        base.ReactToStimuli();
        base.Photosynthesis();
        base.Respiratory();
    }
    public void PropagationBySeed()
    {
        Console.WriteLine("SeedPlants are PropagationBySeed");
    }
}