using ScottPlot;

namespace Adapter.ExternalLibrary;

// We pretend that this class belongs to a 3rd party library.
public sealed class ChartImageGenerator : IChartGenerator
{
    private readonly Plot _plot = new(1920, 1080);

    /// <summary>
    ///     Generates and stores a chart bar as PNG image.
    /// </summary>
    public void GenerateChartBar(double[] values, string[] labels, string filename)
    {
        var positions = Enumerable
            .Range(0, values.Length)
            .Select(i => (double) i)
            .ToArray();

        _plot.AddBar(values, positions);
        _plot.XTicks(positions, labels);
        _plot.SetAxisLimits(yMin: 0);
        _plot.SaveFig(filename);
    }
}