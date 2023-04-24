namespace Adapter.ExternalLibrary;

// We pretend that this interface belongs to a 3rd party library.
public interface IChartGenerator
{
    public void GenerateChartBar(double[] values, string[] labels, string filename);
}