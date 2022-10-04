using System;

class LivingThings
{
    public void Nutrition()
    {
        Console.WriteLine("LivingThings are Nutrition");
    }
    public void Respiratory()
    {
        Console.WriteLine("LivingThings are Respiratory");
    }
    public void Excretion()
    {
        Console.WriteLine("LivingThings are Excretion");

    }
    public virtual void ReactToStimuli()
    {
        Console.WriteLine("LivingThings react to stimuli");
    }
}