using System;
using System.Collections.Generic;
using System.Text;

namespace iPAS.Services.Registration.Domain.Exceptions
{
    /// <summary>
    /// Exception type for domain exceptions
    /// </summary>
    public class RegistrationDomainException : Exception
    {
        public RegistrationDomainException()
        { }

        public RegistrationDomainException(string message)
            : base(message)
        { }

        public RegistrationDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
