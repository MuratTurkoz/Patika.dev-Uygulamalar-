using System;
class Animals : LivingThings
{
    public void Adaption()
    {
        Console.WriteLine("Animals are Adaption");
        // Console.WriteLine();
    }
    public override void ReactToStimuli()
    {
        base.ReactToStimuli();
        Console.WriteLine("animals react to contact ");
    }
}
class Reptiles : Animals
{

}
class Birds : Animals
{
    public Birds()
    {
        base.Adaption();
        base.Excretion();
        base.Nutrition();
        base.ReactToStimuli();
        base.Respiratory();
    }
    public void Fly()
    {
        Console.WriteLine("Birds are fly");
    }
}