namespace StrategyPattern.Strategies.Concrete.QuackBehavior;
internal class NoQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Silence...");
    }
}