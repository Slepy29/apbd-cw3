namespace cw3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(int height, int weight, int depth, string type, int id) : base(height, weight, depth, type, id)
    {
    }

    public override void Load(int mass)
    {
        this.Mass += mass;
    }
}