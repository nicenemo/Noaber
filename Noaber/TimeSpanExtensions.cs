    using System;
    using System.Runtime.CompilerServices;

public static class TimeSpanExtensions
{

    public static TimeSpan Hours(this int value)
    {
        return new TimeSpan(value, 0, 0);
    }

    public static TimeSpan Minutes(this int value)
    {
        return new TimeSpan(0, value, 0);
    }

    public static TimeSpan Seconds(this int value)
    {
        return new TimeSpan(0, 0, value);
    }

    public static TimeSpan Ticks(this int value)
    {
        return new TimeSpan(value);
    }

    public static TimeSpan Days(this int value)
    {
        return new TimeSpan(value, 0, 0, 0, 0);
    }

    public static TimeSpan Millis(this int value)
    {
        return new TimeSpan(0, 0, 0, 0, value);
    }
}
