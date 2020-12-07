namespace ExactOnline.Client.Sdk.PerformanceTests.Helpers
{
    using System;
    using System.Diagnostics;

    public class TestTimer
    {
        public static TimeSpan Time(Action toTime)
        {
            var timer = Stopwatch.StartNew();
            toTime();
            timer.Stop();
            return timer.Elapsed;
        }
    }
}
