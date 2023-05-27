namespace AlgorithmsComparison.Algorithms;
public sealed class GeneticAlgorithm : Algorithm
{
    public override string Name => "Genetic";

    public int GenerationsCount { get; set; } = 50;

    public int PopulationSize { get; set; } = 100;

    public override double GetTimeForCount(int count)
    {
        return GenerationsCount * PopulationSize * count;
    }
}
