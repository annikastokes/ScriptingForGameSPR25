using UnityEngine;

public class Mammal : Animal
{
    protected virtual void Start()
    {
        bType = BloodType.WarmBlooded;
    }
    public override void Eat(int energyGained)
    {
        base.Eat(energyGained);
        Debug.Log("Chomp chomp eating with ma mouth");
    }

    public virtual void GiveBirth()
    {
        Debug.Log("Giving birth to a mammal");
    }
}
