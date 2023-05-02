namespace StrategyPattern.Strategies.Concrete.FlyBehavior;

internal class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Flying with wings!");
    }
}
