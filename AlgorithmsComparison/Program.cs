using AlgorithmsComparison;
using AlgorithmsComparison.Algorithms;
using Plotly.NET.CSharp;

var amounts = new List<int>();
var algorithms = new Algorithm[] { new GreedyAlgorithm(), new GeneticAlgorithm(), new BruteForceAlgorithm(), new DynamicAlgorithm() };
for (var i = 2; i <= 18; i += 2)
{
    amounts.Add(i);
    foreach (var algorithm in algorithms)
    {
        algorithm.Times.Add(algorithm.GetTimeForCount(i));
    }
}

var charts = new List<Plotly.NET.GenericChart.GenericChart>();
foreach (var algorithm in algorithms)
{
    charts.Add(Chart.Line<double, double, string>(
        x: amounts.Select(a => (double)a),
        y: algorithm.Times
    ).WithTraceInfo(algorithm.Name));
}

Chart.Combine(charts)
    .WithYAxisStyle<double, double, string>(Title: Plotly.NET.Title.init("Time (units)"))
    .WithXAxisStyle<double, double, string>(Title: Plotly.NET.Title.init("Objects count"))
    .WithSize(Width: 800)
    .Show();
