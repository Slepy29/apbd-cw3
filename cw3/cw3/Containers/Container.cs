using cw3.Interfaces;

namespace cw3.Containers;

public abstract class Container : IContainer
{
    public int Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string[] SerialNumber { get; set; }
    public int MaxWeight { get; set; }

    protected Container(int height, int weight, int depth, string type, int id, int maxWeight)
    {
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = new []{"KON", type, id.ToString()};
        MaxWeight = maxWeight;
    }

    public virtual void Unload()
    {
        Mass = 0;
    }

    public virtual void Load(int mass)
    {
        if (Mass + mass > MaxWeight)
            throw new OverflowException("Container will overflow");
        Mass = mass;
    }
}

