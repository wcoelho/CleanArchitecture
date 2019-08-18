namespace Ativ5.Domain
{
    using System;

    public class Ativ5Exception : Exception
    {
        internal Ativ5Exception()
        { }

        internal Ativ5Exception(string message)
            : base(message)
        { }

        internal Ativ5Exception(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
