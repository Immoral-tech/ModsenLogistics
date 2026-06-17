using System.Reflection;

namespace ModsenLogistics.Exceptions
{
    public sealed class WaybillParseException : Exception
    {
        public WaybillParseException() : base() { }
        public WaybillParseException(string message) : base(message) { }
        public WaybillParseException(string message, Exception innerException) : base(message, innerException) { }
    }
}
