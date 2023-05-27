namespace AlgorithmsComparison.Algorithms;
public sealed class DynamicAlgorithm : Algorithm
{
    public override string Name => "Dynamic programming";

    public override double GetTimeForCount(int count)
    {
        return 7.5 * count * 0.75 * count;
    }
}
