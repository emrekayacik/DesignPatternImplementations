namespace StrategyPattern.Strategies.Concrete.QuackBehavior;
internal class Squack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squack!");
    }
}
