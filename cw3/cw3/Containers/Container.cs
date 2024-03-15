using cw3.Interfaces;

namespace cw3.Containers;

public abstract class Container : IContainer
{
    public int Mass { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Depth { get; set; }
    public string[] SerialNumber { get; set; }

    protected Container(int height, int weight, int depth, string type, int id)
    {
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = new []{"KON", type, id.ToString()};
    }

    public virtual void Unload()
    {
        Mass = 0;
    }

    public virtual void Load(int mass)
    {
        Mass = mass;
    }
}

