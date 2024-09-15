using System;

namespace Monobank.Client
{
    internal static class Int64Extensions
    {
        public static DateTime ToDateTime(this long seconds)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(seconds);
        }
    }
}