namespace AlgorithmsComparison;
public abstract class Algorithm
{
    public abstract string Name { get; }

    public List<double> Times { get; } = new();

    public abstract double GetTimeForCount(int count);      // Count is n (like O(n))
}
