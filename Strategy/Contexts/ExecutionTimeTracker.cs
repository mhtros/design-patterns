using System.Diagnostics;

namespace Strategy.Contexts;

public abstract class ExecutionTimeTracker
{
    public abstract string TrackExecutionTime();

    protected static string TrackExecutionTime(Action actionToTrack)
    {
        if (actionToTrack is null) throw new ArgumentNullException(nameof(actionToTrack));

        var watch = Stopwatch.StartNew();
        actionToTrack.Invoke();
        watch.Stop();
        var elapsedMs = watch.ElapsedMilliseconds;

        var t = TimeSpan.FromMilliseconds(elapsedMs);
        return $"{t.Hours:D2}h:{t.Minutes:D2}m:{t.Seconds:D2}s:{t.Milliseconds:D3}ms";
    }
}