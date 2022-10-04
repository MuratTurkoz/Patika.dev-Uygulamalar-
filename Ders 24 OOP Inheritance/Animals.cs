using System;
class Animals : LivingThings
{
    public void Adaption()
    {
        Console.WriteLine("Animals are Adaption");
        // Console.WriteLine();
    }
}
class Reptiles : Animals
{

}
class Birds : Animals
{
    public void Fly()
    {
        Console.WriteLine("Birds are fly");
    }
}