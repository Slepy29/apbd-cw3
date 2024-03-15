using cw3.Interfaces;

namespace cw3.Containers;

public class LiquidContainer : Container, IHazardNotifier
{
    public LiquidContainer(int height, int weight, int depth, string type, int id, int maxWeight) : base(height, weight, depth, type, id, maxWeight)
    {
    }

    public override void Load(int mass)
    {
        //if(hazard)
        {
            if (mass > 0.5 * MaxWeight)
                Console.WriteLine("Danger!!!");
            else
                base.Load(mass);
        }
        //else
        {
            if (mass > 0.9 * MaxWeight)
                Console.WriteLine("Danger!!!");
            else
                base.Load(mass);
        };
    }

    public void Notify()
    {
        Console.WriteLine(String.Join("-", SerialNumber));
    }
}