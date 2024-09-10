using System;

namespace Monobank.Client
{
    public class MonobankApiException : Exception
    {
        public MonobankApiException(string message) : base(message)
        {
        }
    }
}