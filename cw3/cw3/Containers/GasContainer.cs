namespace cw3.Containers;

public class GasContainer : Container
{
    public GasContainer(int height, int weight, int depth, string type, int id, int maxWeight) : base(height, weight, depth, type, id, maxWeight)
    {
    }

    public override void Unload()
    {
        Mass *= 0.05;
    }
}