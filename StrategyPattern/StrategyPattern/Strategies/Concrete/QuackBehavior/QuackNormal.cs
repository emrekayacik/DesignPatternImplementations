namespace StrategyPattern.Strategies.Concrete.QuackBehavior;
internal class QuackNormal : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}
