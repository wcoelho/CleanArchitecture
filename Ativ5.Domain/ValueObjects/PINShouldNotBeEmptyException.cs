﻿namespace Ativ5.Domain.ValueObjects
{
    public class PINShouldNotBeEmptyException : DomainException
    {
        internal PINShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
