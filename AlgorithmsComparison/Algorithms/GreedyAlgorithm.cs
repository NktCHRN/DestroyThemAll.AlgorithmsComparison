namespace AlgorithmsComparison.Algorithms;
public sealed class GreedyAlgorithm : Algorithm
{
    public override string Name => "Greedy";

    public override double GetTimeForCount(int count)
    {
        return count * Math.Log2(count);
    }
}
