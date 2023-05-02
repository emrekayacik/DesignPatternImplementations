namespace StrategyPattern.Strategies.Concrete.FlyBehavior;
internal class NoFly : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Cannot fly");
    }
}
