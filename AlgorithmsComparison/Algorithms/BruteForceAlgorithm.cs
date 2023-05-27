namespace AlgorithmsComparison.Algorithms;
public sealed class BruteForceAlgorithm : Algorithm
{
    public override string Name => "Brute force";

    public override double GetTimeForCount(int count)
    {
        return Math.Pow(2, count);
    }
}
